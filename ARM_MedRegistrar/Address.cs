using CourseworkTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ARM_MedRegistrar
{
    public class Address
    {
        string _city;
        string _region; //район
        string _street;
        //uint _numbOfHouse;
        //uint _numbOfFlat;

        public string City
        {
            get => _city; set
            {
                if (value == "" || value == " " || value == null)
                    throw new ArgumentException("Город не задан");
                _city = value;
            }
        }

        public string Region
        {
            get => _region; set
            {
                if (value == "" || value == " " || value == null)
                    throw new ArgumentException("Район не задан");
                _region = value;
            }
        }

        public string Street
        {
            get => _street; set
            {
                if (value == "" || value == " " || value == null)
                    throw new ArgumentException("Улица не задана");
                _street = value;
            }
        }

        public uint NumbOfHouse { get; set; }
        public uint NumbOfFlat { get; set; }


        public Address(string city, string region, string street, uint numbOfHouse, uint numbOfFlat)
        {
            City = city;
            Region = region;
            Street = street;
            NumbOfHouse = numbOfHouse;
            NumbOfFlat = numbOfFlat;
        }

    }
}
