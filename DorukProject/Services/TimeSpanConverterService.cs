namespace DorukProject.Services
{
    /// <summary>
    /// CalculateTotalMinutes methodunu içermekte ve zaman aralığının dakikaya dönüştürülmesini sağlamaktadır
    /// </summary>
    /// <returns></returns>
    public interface ITimeSpanConverter
    {
        /// <summary>
        /// Toplam dakikayı hesaplayan method
        /// </summary> 
        /// <returns></returns>
        int CalculateTotalMinutes(TimeSpan timeSpan);
    }
    public class TimeSpanConverterService : ITimeSpanConverter
    {
        private readonly IDayMinutesCalculator _dayMinutesCalculator;
        private readonly IHourMinutesCalculator _hourMinutesCalculator;
        /// <summary>
        /// TimeSpanConverterService ile ilgili işlevleri barındıran servisin yapıcı metodu
        /// </summary>
        /// <param name="dayMinutesCalculator"></param>
        /// <param name="hourMinutesCalculator"></param> 
        public TimeSpanConverterService(IDayMinutesCalculator dayMinutesCalculator, IHourMinutesCalculator hourMinutesCalculator)
        {
            _dayMinutesCalculator = dayMinutesCalculator;
            _hourMinutesCalculator = hourMinutesCalculator;
        }
        /// <summary>
        /// Toplam dakikayı hesaplayan method
        /// </summary>
        /// <param name="timeSpan"></param>
        /// <returns></returns>
        public int CalculateTotalMinutes(TimeSpan timeSpan)
        {
            int totalMinutes = 0;
            totalMinutes += _dayMinutesCalculator.CalculateDayMinutes(timeSpan.Days);
            totalMinutes += _hourMinutesCalculator.CalculateHourMinutes(timeSpan.Hours);
            totalMinutes += timeSpan.Minutes;
            totalMinutes += timeSpan.Seconds / 60; // Saniyeleri dakikaya dönüştür
            return totalMinutes;
        }

    }
    /// <summary>
    /// Günleri dakikaya çeviren hesaplama yöntemi arayüzü
    /// </summary> 
    /// <returns></returns>
    public interface IDayMinutesCalculator
    {
        int CalculateDayMinutes(int days);
    }
    /// <summary>
    /// IHourMinutesCalculator ile ilgili işlevleri barındıran, <see cref="IDayMinutesCalculator"/> interface'ini baz alan class.
    /// </summary>
    public class DayMinutesCalculator : IDayMinutesCalculator
    {
        public int CalculateDayMinutes(int days)
        {
            return days * 24 * 60;
        }
    }
    /// <summary>
    /// Saatleri dakikaya ceviren hesaplama yontemi arayuzu
    /// </summary> 
    /// <returns></returns>
    public interface IHourMinutesCalculator
    {
        int CalculateHourMinutes(int hours);
    }
    /// <summary>
    /// IHourMinutesCalculator ile ilgili işlevleri barındıran, <see cref="IHourMinutesCalculator"/> interface'ini baz alan class.
    /// </summary>
    public class HourMinutesCalculator : IHourMinutesCalculator
    {
        public int CalculateHourMinutes(int hours)
        {
            return hours * 60;
        }
    }
}
