using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARM_MedRegistrar.Model.AttachedStreets
{
    public class AttachedStreets : IAttachedStreets
    {
        private string _city;
        private string _region;
        private string _street;
        private int _numbOfHouse;

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

        public AttachedStreets(string city, string region, string street, int numbOfHouse) 
        {
            City = city;
            Region = region;
            Street = street;
            NumbOfHouse = numbOfHouse;
        }

        public string Format()
        {
            return $"ул. {Street}, д. {NumbOfHouse}, район {Region}, город {City}";
        }
    }
}
