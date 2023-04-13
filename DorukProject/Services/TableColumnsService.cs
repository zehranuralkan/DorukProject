namespace DorukProject.Services
{
    public interface ITableColumnsService
    {
        /// <summary>
        /// Tablonun sutun degerlerini getirir
        /// </summary> 
        /// <returns></returns>
        public List<string> GetTableColumns();
    }
    public class TableColumnsService : ITableColumnsService
    {
        private readonly IPostureList _postureList;
        /// <summary>
        /// Tablo columnlarını getiren metodun bulunduğu servis sınıfının yapıcı metodu
        /// <param name="postureList"></param> 
        /// </summary>
        public TableColumnsService(IPostureList postureList)
        {
            _postureList = postureList;
        }

        /// <summary>
        /// Tablonun sütun değerlerini getirir.
        /// </summary>
        /// <returns>Tablonun sütun değerleri.</returns>
        public List<string> GetTableColumns()
        {
            var result = _postureList.GetPostureList()
                .GroupBy(x => x.ReasonForPosture)
                .Select(x => x.Key)
                .ToList();
            return result;
        }
    }
}
