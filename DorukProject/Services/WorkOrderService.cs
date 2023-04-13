using DorukProject.Models;

namespace DorukProject.Services
{
    /// <summary>
    /// İş emri listesini ceken method
    /// </summary>
    /// <returns></returns>
    public interface IWorkOrder
    {
        /// <summary>
        ///İş emir listesini getirir
        /// </summary> 
        /// <returns></returns>
        List<WorkOrder> GetWorkOrder();
    }
    /// <summary>
    /// İş emir listesinin metodlarının bulunduğu servis sınıfı
    /// </summary>
    public class WorkOrderService : IWorkOrder
    {
        /// <summary>
        /// İş emri listesini getirir
        /// </summary> 
        /// <returns></returns>
        public List<WorkOrder> GetWorkOrder() => new()
        {
            new()
            {
                WorkOrderID=1001,
                StartDate=Convert.ToDateTime("1.01.2017 08:00:00"),
                EndDate=Convert.ToDateTime("1.01.2017 16:00:00"),
            },
            new()
            {
                WorkOrderID=1002,
                StartDate=Convert.ToDateTime("1.01.2017 16:00:00"),
                EndDate=Convert.ToDateTime("2.01.2017 00:00:00"),
            },
             new()
            {
                WorkOrderID=1003,
                StartDate=Convert.ToDateTime("2.01.2017 00:00:00"),
                EndDate=Convert.ToDateTime("2.01.2017 08:00:00"),
            },
             new()
            {
                WorkOrderID=1004,
                StartDate=Convert.ToDateTime("2.01.2017 08:00:00"),
                EndDate=Convert.ToDateTime("2.01.2017 16:00:00"),
            },
             new()
            {
                WorkOrderID=1005,
                StartDate=Convert.ToDateTime("2.01.2017 16:00:00"),
                EndDate=Convert.ToDateTime("3.01.2017 00:00:00"),
            },
            new()
            {
                WorkOrderID=1006,
                StartDate=Convert.ToDateTime("3.01.2017 00:00:00"),
                EndDate=Convert.ToDateTime("3.01.2017 08:00:00"),
            },
            new()
            {
                WorkOrderID=1007,
                StartDate=Convert.ToDateTime("3.01.2017 08:00:00"),
                EndDate=Convert.ToDateTime("3.01.2017 16:00:00"),
            },
            new()
            {
                WorkOrderID=1008,
                StartDate=Convert.ToDateTime("3.01.2017 16:00:00"),
                EndDate=Convert.ToDateTime("4.01.2017 00:00:00"),
            },
            new()
            {
                WorkOrderID=1009,
                StartDate=Convert.ToDateTime("4.01.2017 00:00:00"),
                EndDate=Convert.ToDateTime("4.01.2017 08:00:00"),
            }
        };
    }
}
