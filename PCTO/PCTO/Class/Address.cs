using System;
using System.Text;
using System.Threading.Tasks;

namespace PCTO
{
    public class Address
    {
        public Address(string number = "29a", string road = "Via Gavazzeni", string town = "Bergamo", string province = "BG")
        {
            this._number = number;
            this._street = road;
            this._town = town;
            this._province = province;
        }
        public override string ToString()
        {
            return $"{this.Street} {this.Number}, {this.Town} ({this.Province})";
        }
        public string ToCompleteAddress()
        {
            //return $"{this.Number} {this.Road}, {this.Town}";
            return $"{Street} {Number} {Town}";
        }

        string _number;
        public string Number
        {
            get { return _number; }
            set { _number = PropertyControl.ValidString(value); }
        }

        string _street;
        public string Street
        {
            get { return _street; }
            set { _street = PropertyControl.ValidString(value); }
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

        public Coordinates Coordinates { get; set; }
    }
}