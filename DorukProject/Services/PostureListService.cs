using DorukProject.Models;

namespace DorukProject.Services
{
    /// <summary>
    /// Duruş listesi çeken methodu içeren method
    /// </summary>
    /// <returns></returns>
    public interface IPostureList
    {
        /// <summary>
        /// Duruş listesini getirir
        /// </summary> 
        /// <returns></returns>
        List<PostureList> GetPostureList();
    }
    /// <summary>
    /// Duruş listesinin metodlarının bulunduğu servis sınıfı
    /// </summary>
    public class PostureListService: IPostureList
    {
        /// <summary>
        /// Duruş listesini getirir
        /// </summary> 
        /// <returns></returns>
        public List<PostureList> GetPostureList() => new()
        {
            new()
            {
                ReasonForPosture="Mola",
                WorkStartDate=Convert.ToDateTime("1.01.2017 10:00:00"),
                WorkEndDate=Convert.ToDateTime("1.01.2017 10:10:00")
            },

            new()
            {
                ReasonForPosture="Arıza",
                WorkStartDate=Convert.ToDateTime("1.01.2017 10:30:00"),
                WorkEndDate=Convert.ToDateTime("1.01.2017 11:00:00")
            },
            new()
            {
                ReasonForPosture="Mola",
                WorkStartDate=Convert.ToDateTime("1.01.2017 12:00:00"),
                WorkEndDate=Convert.ToDateTime("1.01.2017 12:30:00")
            },
            new()
            {
                ReasonForPosture="Mola",
                WorkStartDate=Convert.ToDateTime("1.01.2017 14:00:00"),
                WorkEndDate=Convert.ToDateTime("1.01.2017 14:10:00")
            },
            new()
            {
                ReasonForPosture="Setup",
                WorkStartDate=Convert.ToDateTime("1.01.2017 15:00:00"),
                WorkEndDate=Convert.ToDateTime("1.01.2017 16:30:00")
            },
            new()
            {
                ReasonForPosture="Mola",
                WorkStartDate=Convert.ToDateTime("1.01.2017 18:00:00"),
                WorkEndDate=Convert.ToDateTime("1.01.2017 18:10:00")
            },
            new()
            {
                ReasonForPosture="Mola",
                WorkStartDate=Convert.ToDateTime("1.01.2017 20:00:00"),
                WorkEndDate=Convert.ToDateTime("1.01.2017 20:30:00")
            },
            new()
            {
                ReasonForPosture="Mola",
                WorkStartDate=Convert.ToDateTime("1.01.2017 22:00:00"),
                WorkEndDate=Convert.ToDateTime("1.01.2017 22:10:00")
            },
            new()
            {
                ReasonForPosture="Arge",
                WorkStartDate=Convert.ToDateTime("1.01.2017 23:00:00"),
                WorkEndDate=Convert.ToDateTime("2.01.2017 08:30:00")
            },
            new()
            {
                ReasonForPosture="Mola",
                WorkStartDate=Convert.ToDateTime("2.01.2017 10:00:00"),
                WorkEndDate=Convert.ToDateTime("2.01.2017 10:10:00")
            },
            new()
            {
                ReasonForPosture="Mola",
                WorkStartDate=Convert.ToDateTime("2.01.2017 12:00:00"),
                WorkEndDate=Convert.ToDateTime("2.01.2017 12:30:00")
            },
            new()
            {
                ReasonForPosture="Arıza",
                WorkStartDate=Convert.ToDateTime("2.01.2017 13:00:00"),
                WorkEndDate=Convert.ToDateTime("2.01.2017 13:45:00")
            },
            new()
            {
                ReasonForPosture="Mola",
                WorkStartDate=Convert.ToDateTime("2.01.2017 14:00:00"),
                WorkEndDate=Convert.ToDateTime("2.01.2017 14:10:00")
            },
            new()
            {
                ReasonForPosture="Mola",
                WorkStartDate=Convert.ToDateTime("2.01.2017 18:00:00"),
                WorkEndDate=Convert.ToDateTime("2.01.2017 18:10:00")
            },
            new()
            {
                ReasonForPosture="Arge",
                WorkStartDate=Convert.ToDateTime("2.01.2017 20:00:00"),
                WorkEndDate=Convert.ToDateTime("3.01.2017 02:10:00")
            },
            new()
            {
                ReasonForPosture="Mola",
                WorkStartDate=Convert.ToDateTime("3.01.2017 04:00:00"),
                WorkEndDate=Convert.ToDateTime("3.01.2017 04:30:00")
            },
            new()
            {
                ReasonForPosture="Setup",
                WorkStartDate=Convert.ToDateTime("3.01.2017 06:00:00"),
                WorkEndDate=Convert.ToDateTime("3.01.2017 09:30:00")
            },
            new()
            {
                ReasonForPosture="Mola",
                WorkStartDate=Convert.ToDateTime("3.01.2017 10:00:00"),
                WorkEndDate=Convert.ToDateTime("3.01.2017 10:10:00")
            },
            new()
            {
                ReasonForPosture="Mola",
                WorkStartDate=Convert.ToDateTime("3.01.2017 12:00:00"),
                WorkEndDate=Convert.ToDateTime("3.01.2017 12:30:00")
            },
            new()
            {
                ReasonForPosture="Mola",
                WorkStartDate=Convert.ToDateTime("3.01.2017 14:00:00"),
                WorkEndDate=Convert.ToDateTime("3.01.2017 14:10:00")
            },
            new()
            {
                ReasonForPosture="Arıza",
                WorkStartDate=Convert.ToDateTime("3.01.2017 15:00:00"),
                WorkEndDate=Convert.ToDateTime("3.01.2017 18:45:00")
            },
            new()
            {
                ReasonForPosture="Mola",
                WorkStartDate=Convert.ToDateTime("3.01.2017 20:00:00"),
                WorkEndDate=Convert.ToDateTime("3.01.2017 20:30:00")
            },
            new()
            {
                ReasonForPosture="Mola",
                WorkStartDate=Convert.ToDateTime("3.01.2017 22:00:00"),
                WorkEndDate=Convert.ToDateTime("3.01.2017 22:10:00")
            },
        };
    }
}
