using DorukProject.Models;

namespace DorukProject.Services
{
    /// <summary>
    /// Genel rapor hangi iş emrinde kaç dakika duruş oldugunu belirler
    /// </summary>
    /// <returns></returns>
    public interface IReportService
    {
        /// <summary>
        /// İş emirlerine göre raporları getirir
        /// </summary> 
        /// <returns></returns>
        public List<ReportViewModel> GetReport();
      
    }
    /// <summary>
    /// Rapor metodlarının bulunduğu servis sınıfı
    /// </summary>
    public class ReportService : IReportService
    {
        private readonly ITimeSpanConverter _timeSpanConverter;
        private readonly IWorkOrder _workOrder;
        private readonly IPostureList _postureList;
        /// <summary>
        /// Reporlama metodlarının bulunduğu servis sınıfının yapıcı metodu
        /// <param name="timeSpanConverter"></param>
        /// <param name="workOrder"></param>
        /// <param name="postureList"></param>
        /// </summary>
        public ReportService(ITimeSpanConverter timeSpanConverter, IWorkOrder workOrder, IPostureList postureList)
        {
            _timeSpanConverter = timeSpanConverter;
            _workOrder = workOrder;
            _postureList = postureList;
        }

        /// <summary>
        /// İş raporunu getirir
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public List<ReportViewModel> GetReport()
        {
            var workOrderList = _workOrder.GetWorkOrder();
            var postureList = _postureList.GetPostureList();
            var result = GetReportData(workOrderList, postureList);
            return result;
        }
        /// <summary>
        /// İş analizi için verilerin getirildiği  method
        /// </summary>
        /// <param name="workOrderList"></param>
        /// <param name="postureList"></param>
        /// <returns></returns>
        public List<ReportViewModel> GetReportData(List<WorkOrder> workOrderList, List<PostureList> postureList)
        {
            var reportList = new List<ReportViewModel>();
            foreach (var workOrder in workOrderList)
            {
                var postureReason = new List<PostureReason>();
                var postureListForWorkOrder = postureList.Where(x => x.WorkStartDate <= workOrder.EndDate && x.WorkEndDate >= workOrder.StartDate).ToList();
                var result = DowntownMinuteAndReason(postureListForWorkOrder, workOrder, postureReason);
                var report=GetRaport(result, workOrder);
                reportList.Add(report);
            }
            return reportList;
        }
        /// <summary>
        /// İş analizi için verilerin tiplere göre kesinti sürelerini hesaplamaya  gönderildiği method
        /// </summary>
        /// <param name="postureListForWorkOrder"></param>
        /// <param name="workOrder"></param>
        /// <returns></returns>
        public PostureReport DowntownMinuteAndReason(List<PostureList> postureListForWorkOrder, WorkOrder workOrder, List<PostureReason> reasons)
        {
            var postureReport = new PostureReport();

            foreach (var posture in postureListForWorkOrder)
            {
                var minute = 0;
                TimeSpan time;
                if (posture.WorkStartDate >= workOrder.StartDate)
                {
                    if (posture.WorkEndDate >= workOrder.EndDate)
                    {
                        time = workOrder.EndDate - posture.WorkStartDate;
                        minute = _timeSpanConverter.CalculateTotalMinutes(time);
                    }
                    else
                    {
                        time = posture.WorkEndDate - posture.WorkStartDate;
                        minute = _timeSpanConverter.CalculateTotalMinutes(time);
                    }
                }
                else
                {
                    posture.WorkStartDate = workOrder.StartDate;
                    if (posture.WorkEndDate >= workOrder.EndDate)
                    {
                        time = workOrder.EndDate - posture.WorkStartDate;
                        minute = _timeSpanConverter.CalculateTotalMinutes(time);
                    }
                    else
                    {
                        time = posture.WorkEndDate - posture.WorkStartDate;
                        minute = _timeSpanConverter.CalculateTotalMinutes(time);
                    }
                }
                postureReport.Total += minute;
                var existingReason = postureReport.Reasons.FirstOrDefault(r => r.Name == posture.ReasonForPosture);

                if (existingReason != null)
                {
                    existingReason.Time += minute;
                }
                else
                {
                    postureReport.Reasons.Add(new PostureReason
                    {
                        Name = posture.ReasonForPosture,
                        Time = minute
                    });
                }
            }
            return postureReport;
        }
        /// <summary>
        /// İş emrine göre raporu dinamik olarak getirir
        /// </summary>
        /// <param name="postureReport"></param>
        /// <param name="workOrderList"></param>
        /// <returns></returns>
        public ReportViewModel GetRaport(PostureReport postureReport, WorkOrder workOrderList)
        {
            var report = new ReportViewModel
            {
                WorkOrderID = workOrderList.WorkOrderID,
                Total = postureReport.Total,
                Reasons = postureReport.Reasons
            };
            return report;
        }
  

    }

}



