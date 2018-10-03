
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Assginment.Helpers
{
    public class FileHelper<T> where T : class
    {
        public static List<T> ReadJsonNodes(string filePath)
        {
            var resultList = JsonConvert.DeserializeObject<List<T>>(File.ReadAllText(filePath));
            using (StreamReader file = File.OpenText(filePath))
            {
                JsonSerializer serializer = new JsonSerializer();
                resultList = (List<T>)serializer.Deserialize(file, typeof(List<T>));
            }
            return resultList;
        }
    }
}