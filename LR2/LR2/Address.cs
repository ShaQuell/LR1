using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2
{
    class Address
    {
        public int _index;
        public string _country;
        public string _city;
        public string _street;
        public string _house;
        public int _apartment;

        public Address(int index, string country, string city, string street, string house, int apartment)
        {
            this._index = index;
            this._country = country;
            this._city = city;
            this._street = street;
            this._house = house;
            this._apartment = apartment;
        }
    }
}
