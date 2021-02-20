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
    class Place
    {
        public Place(string number="29", string road="Via Mauro Gavazzeni", string town="Bergamo", string province="BG")
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

        string _number;
        public string Number { get { return _number; } set { _number = PropertyControl.ValidString(value); } }

        string _road;
        public string Road { get { return _road; } set { _road = PropertyControl.ValidString(value); } }

        string _town;
        public string Town { get { return _town; } set { _town = PropertyControl.ValidString(value); } }

        string _province;
        public string Province { get { return _province; } set { _province = PropertyControl.Province(value); } }

        //void a()
        //{
        //    string jsonString = string.Empty;
        //    HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://positionstack.com/");
        //    using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
        //    using (Stream stream = response.GetResponseStream())
        //    using (StreamReader reader = new StreamReader(stream))
        //        jsonString = reader.ReadToEnd();
        //    dynamic stuff = JsonConvert.DeserializeObject(jsonString);

        //}
        

        public string Latitude { get; set; }
        public string Longitude { get; set; }
    }
}
