using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace PCTO
{
    public class Address
    {
        public Address(string number = "29a", string street = "Via Gavazzeni", string town = "Bergamo", string province = "BG")
        {
            if (number == "")
                _number = number;
            else
                Number = number;
            if (street == "")
                _street = street;
            else
                Street = street;
            if (town == "")
                _town = town;
            else
                Town = town;
            if (province == "")
                _province = province;
            else
                Province = province;
            Coordinates = new Coordinates();
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