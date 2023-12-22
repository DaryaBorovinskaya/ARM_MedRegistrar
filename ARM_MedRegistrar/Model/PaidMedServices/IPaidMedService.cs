using System;
using ARM_MedRegistrar.Model.Identifications;

namespace ARM_MedRegistrar.Model.PaidMedServices
{
    public interface IPaidMedService : IIdentification
    {
        public string Title {  get; set; }
        public decimal Price { get; set; }
    }
}
