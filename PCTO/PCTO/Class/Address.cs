using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;

namespace PCTO
{
    public class Address
    {
        public Address(string number = "29a", string road = "Via Gavazzeni", string town = "Bergamo", string province = "BG")
        {
            this._number = number;
            this._road = road;
            this._town = town;
            this._province = province;
        }
        public override string ToString()
        {
            return $"{this.Road} {this.Number}, {this.Town} ({this.Province})";
        }
        public string ToCompleteAddress()
        {
            return $"{this.Number} {this.Road}, {this.Town}";
        }

        string _number;
        public string Number
        {
            get { return _number; }
            set { _number = PropertyControl.ValidString(value); }
        }

        string _road;
        public string Road
        {
            get { return _road; }
            set { _road = PropertyControl.ValidString(value); }
        }

        string _town;
        public string Town
        {
            get { return _town; }
            set { _town = PropertyControl.ValidString(value); }
        }

        string _province;
        public string Province
        {
            get { return _province; }
            set { _province = PropertyControl.Province(value); }
        }      

        
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
    }

    public interface IApiCaller
    {
        ResultApi GetApiResult(string completeAddress);
    }

    public class ApiCaller : IApiCaller
    {
        public ResultApi GetApiResult(string completeAddress)
        {
            var apiUrl = $"http://api.positionstack.com/v1/forward?access_key=1555307b64886ccfe7546a7037046834&query={completeAddress}&output=json";
            string jsonString = string.Empty;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(apiUrl);
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
                jsonString = reader.ReadToEnd();

             return JsonConvert.DeserializeObject<ResultApi>(jsonString);
        }
    }

    public class CoordinateHelper
    {
        private readonly IApiCaller caller;

        public CoordinateHelper(IApiCaller caller)
        {
            this.caller = caller;
        }        

        public List<Coordinates> GetCoordinates(string completeAddress)
        {            
            completeAddress = WebUtility.UrlEncode(completeAddress);
            var stuff = caller.GetApiResult(completeAddress);            
            return stuff.Data.Select(x => new Coordinates() { Latitude = x.Latitude, Longitude = x.Longitude }).ToList();
        }

        public void SetCoordinates( Address address)
        {
            var a = GetCoordinates(address.ToCompleteAddress());
            address.Latitude = a[0].Latitude;
            address.Longitude = a[0].Longitude;
        }
    }

    public class Coordinates
    {
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
    }

    public class ResultApi
    {
        public ApiData[] Data { get; set; }
        public class ApiData
        {
            public decimal Latitude { get; set; }
            public decimal Longitude { get; set; }
            public string Postal_code { get; set; }
            public string Map_url { get; set; }
        }
    }
}
