namespace WebApi.Controllers
{
    public class DataService : IDataService
    {
        public string GetData()
        {
            return DateTime.Now.ToString();
        }
    }
}
