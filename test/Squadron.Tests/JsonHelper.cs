using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;

namespace Squadron.Tests
{
    public static class JsonHelper
    {
        public static T Deserialize<T>(string jsonString)
        {
            var serializer = new DataContractJsonSerializer(typeof(T));
            using (var memoryStream = new MemoryStream(Encoding.UTF8.GetBytes(jsonString)))
            {
                var result = (T)serializer.ReadObject(memoryStream);
                return result;
            }
        }
    }
}