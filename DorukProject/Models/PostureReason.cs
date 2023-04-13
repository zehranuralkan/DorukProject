namespace DorukProject.Models
{
    /// <summary>
    /// Duruş nedenleri dinamik değişebilmesi icin bu sınıfın her bir örneği farklı duruş nedenini temsil eder
    /// </summary> 
    /// <returns></returns>
    public class PostureReason
    {
        public string Name { get; set; }
        public int Time { get; set; }
    }
}
