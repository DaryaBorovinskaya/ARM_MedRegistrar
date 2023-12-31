﻿
namespace ARM_MedRegistrar.Model.AddressesOfBuilding
{
    public class AddressOfBuilding :IAddressOfBuilding
    {
        private string _city;
        private string _region;
        private string _street;
        private int _numbOfHouse;

        public string City
        {
            get => _city; 
            set
            {
                if (value == "" || value == " " || value == null)   
                    throw new ArgumentNullException(nameof(value));
                    
                _city = value;
            }
        }
        public string Region
        {
            get => _region; 
            set
            {
                if (value == "" || value == " " || value == null)
                    throw new ArgumentNullException(nameof(value));
                _region = value;
            }
        }
        public string Street
        {
            get => _street; 
            set
            {
                if (value == "" || value == " " || value == null)
                    throw new ArgumentNullException(nameof(value));
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

        public uint Id { get; }
        public AddressOfBuilding(string city, string region, string street, int numbOfHouse)
        {
            City = city;
            Region = region;
            Street = street;
            NumbOfHouse = numbOfHouse;
        }

        public string Format()
        {
            return $"Город: {City}\nРайон: {Region}\nУлица: {Street}\nДом: {NumbOfHouse}\n";
        }

        public string FormatOneLine()
        {
            return $"г. {City}, р-н {Region}, ул. {Street}, д. {NumbOfHouse}";
        }
    }
}
