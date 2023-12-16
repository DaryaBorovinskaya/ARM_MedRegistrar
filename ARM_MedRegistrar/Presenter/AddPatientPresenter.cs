using ARM_MedRegistrar.Model.Addresses;
using ARM_MedRegistrar.Model.AttachedStreets;
using ARM_MedRegistrar.Model.Json.AttachedStreets;
using ARM_MedRegistrar.Model.Json.PatientRepository;
using ARM_MedRegistrar.Model.Patients;
using ARM_MedRegistrar.Model.Persons;
using ARM_MedRegistrar.View.AddPatient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARM_MedRegistrar.Presenter
{
    public class AddPatientPresenter
    {
        IFullName _fullName;
        IPatient _newPatient;
        IAddress _address;
        IAddPatientForm _view;
        IAttachedStreetsRepository jsonAttachedStreetsRepository;
        IList<IAttachedStreets>? _attStreets;

        JsonPatientRepository jsonPatientRepository = new("patients.json");
        public AddPatientPresenter(IAddPatientForm view) 
        { 
            _view = view;
            jsonAttachedStreetsRepository = new JsonAttachedStreetsRepository("attachedStreets.json");
            _attStreets = jsonAttachedStreetsRepository.GetAll();
        }

        public void AddPatient()
        {
            _fullName = new FullName(_view.Surname, _view.Name, _view.Patronymic);

            _address = new Address(_view.City, _view.Region, _view.Street, _view.NumbOfHouse, _view.NumbOfFlat);
                 
             //numericPlotNumber.Value = _plotNumber;    // выгружать данные из файла


            _newPatient = new Patient(_fullName, _view.DateOfBirth, _address, _view.PlotNumber, 
                _view.NumbOfPatientCard, _view.PolicySeries, _view.PolicyNumb, _view.DocumentSeries,
                _view.DocumentNumber, _view.BloodType, _view.RhFactor, _view.Allergies);

            jsonPatientRepository.Add(_newPatient);

        }

    }
}
