using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARM_MedRegistrar.Model.Addresses
{
    public class Address : IAddress
    {
        private string _city;
        private string _region;
        private string _street;
        private int _numbOfHouse;
        private int _numbOfFlat;
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
        public int NumbOfHouse
        {
            get => _numbOfHouse;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Номер дома не может быть меньше или равным нулю");
                _numbOfHouse = value;
            }
        }
        public int NumbOfFlat
        {
            get => _numbOfFlat;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Номер квартиры не может быть меньше или равным нулю");
                _numbOfFlat = value;
            }
        }

        public Address(string city, string region, string street, int numbOfHouse = 1, int numbOfFlat = 1)
        {
            City = city;
            Region = region;
            Street = street;
            NumbOfHouse = numbOfHouse;
            NumbOfFlat = numbOfFlat;
        }

        public string Format()
        {
            return $"г. {City}, район {Region}, ул. {Street}, д. {NumbOfHouse}, кв. {NumbOfFlat}";
        }
    }
}
