﻿using ARM_MedRegistrar.Model.Formatter;
using ARM_MedRegistrar.Model.Identifications;
using ARM_MedRegistrar.Model.AddressesOfBuilding;
namespace ARM_MedRegistrar.Model.AttachedStreets
{
    public interface IAttachedStreets: IFormatter, IIdentification
    {
        public IAddressOfBuilding AddressOfBuilding { get; set; }
    }
}
