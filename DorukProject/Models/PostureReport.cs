namespace DorukProject.Models
{
    /// <summary>
    ///Duruş raporunun toplam ve duruş nedenlerini tutar
    /// </summary> 
    /// <returns></returns>
    public class PostureReport
    {
        public int Total { get; set; }
        public List<PostureReason> Reasons { get; set; } = new List<PostureReason>();
    }
}
 