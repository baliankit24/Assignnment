using System.Net;
using System.Net.Http;

namespace Assginment.Helpers
{
    class ApiHelper
    {
        public static string GetStock(string stockSymbol)
        {
            string result = string.Empty;
            var url = $"https://www.alphavantage.co/query?function=TIME_SERIES_DAILY&symbol={stockSymbol}&outputsize=full&apikey=ORFRJ9NZT53HJ7WY";

            using (var client = new HttpClient())
            {
                var response = client.GetAsync(url).Result;
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    result = response.Content.ReadAsStringAsync().Result;
                }
            }
            return result;
        }
    }
}