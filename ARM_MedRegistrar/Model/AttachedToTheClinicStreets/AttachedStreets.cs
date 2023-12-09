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

        public AttachedStreets(string city, string region, string street) 
        {
            City = city;
            Region = region;
            Street = street;
        }
    }
}
