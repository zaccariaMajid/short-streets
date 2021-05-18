using System.Net;
using Newtonsoft.Json;
using System.IO;
using System.Linq;

namespace PCTO
{
    public class ApiCaller : IApiCaller
    {
        public ApiResult GetApiResult(string completeAddress)
        {
            var apiUrl = $"https://api.opencagedata.com/geocode/v1/json?key=6c0f85275a664fc7b6ac665d2e40df0a&q={completeAddress}&pretty=1";

            //api gratis
            //https://nominatim.openstreetmap.org/search?street=49+via+borgo+palazzo&city=bergamo&format=geojson&limit=1

            //position stack
            //http://api.positionstack.com/v1/forward?access_key=1555307b64886ccfe7546a7037046834&query={completeAddress}&output=json

            string jsonString = string.Empty;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(apiUrl);
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
                jsonString = reader.ReadToEnd();

            return ToApiResult(JsonConvert.DeserializeObject<Result>(jsonString));
        }

        ApiResult ToApiResult(Result input)
        {
            var result = new ApiResult();
            result.Data = input.Results.Select(x => new Coordinates()
            {
                Lat = x.Geometry.Lat,
                Lng = x.Geometry.Lng,
                Confidence = x.Confidence
            }).ToArray();
            return result;
        }

       public class Result
       {
            public Results[] Results { get; set; }
       }
      public  class Results
      {
            public Coordinates Geometry { get; set; }
            public int Confidence { get; set; }
      }
    }
}