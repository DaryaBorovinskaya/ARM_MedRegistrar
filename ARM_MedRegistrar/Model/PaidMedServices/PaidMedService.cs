using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARM_MedRegistrar.Model.PaidMedServices
{
    public class PaidMedService : IPaidMedService
    {
        private string _title;
        private decimal _price;
        public string Title 
        {
            get => _title; 
            set
            {
                if (value == "" || value == " " || value == null)
                    throw new ArgumentException("Наименование услуги не задано");

                _title = value;
            }
               
        }
        public decimal Price
        {
            get => _price;
            set
            {
                if (value == 0)
                    throw new ArgumentException("Цена не может иметь значение 0");

                _price = value;
            }

        }
        public uint Id { get; }

        public PaidMedService(string title, decimal price, uint id) 
        {
            Title = title;
            Price = price;
            Id = id;
        }
    }
}
