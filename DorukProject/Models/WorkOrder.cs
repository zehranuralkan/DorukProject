namespace DorukProject.Models
{
    /// <summary>
    ///İş emirleri
    /// </summary> 
    /// <returns></returns>
    public class WorkOrder
    {
        public int WorkOrderID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
