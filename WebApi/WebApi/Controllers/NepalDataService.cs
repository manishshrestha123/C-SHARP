namespace WebApi.Controllers
{
    public class NepalDataService : IDataService
    {
        public string GetData()
        {
            return DateTime.Now.AddYears(57).ToString();
        }
    }
}
