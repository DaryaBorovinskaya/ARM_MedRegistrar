using ARM_MedRegistrar.Data.Json.Dictionaries.PatientRepository;
using ARM_MedRegistrar.Model.Patients;
using ARM_MedRegistrar.Model.Persons;
using ARM_MedRegistrar.View.MainWindow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARM_MedRegistrar.Presenter
{
    public class MainWindowPresenter
    {
        IMainWindowForm _view;
        IPatientRepository _jsonPatientRepository;
        IDictionary<uint, IPatient>? _patients;
        IFullName _fullName;
        int _countOfLine = -1;
        bool _isSuccess;
        public MainWindowPresenter(IMainWindowForm view)
        { 
            _view = view;
            _jsonPatientRepository = new JsonPatientRepository("patients.json");
        }


        public bool SearchPatient()
        {
            _countOfLine = -1;
            _isSuccess = false;
            _fullName = new FullName(_view.Surname, _view.Name, _view.Patronymic);
            _patients = _jsonPatientRepository.GetAll();
            if (_patients == null || _patients.Count == 0) 
                return false;

            if (_patients != null && _patients.Count != 0)
            {
                foreach(IPatient patient in _patients.Values)
                {
                    if (patient.DocumentSeries == _view.DocumentSeries && patient.DocumentNumber == _view.DocumentNumber)
                    {
                        _isSuccess = true;
                        _countOfLine++;
                        _view.CountOfLine = _countOfLine;
                        _view.Id = patient.Id;
                        _view.Surname = patient.FullName.Surname;
                        _view.Name = patient.FullName.Name;
                        _view.Patronymic = patient.FullName.Patronymic;
                        _view.DateOfBirth = patient.DateOfBirth;
                        _view.DocumentSeries = patient.DocumentSeries;
                        _view.DocumentNumber = patient.DocumentNumber;
                        _view.PlotNumber = patient.PlotNumber;
                        _view.NumbOfPatientCard = patient.NumbOfPatientCard; 
                    }
                }
                if (_isSuccess) 
                    return true;
                else 
                    return false;
            }

            return false;
        }

        public bool ShowAllPatients()
        {
            _countOfLine= -1;
            _isSuccess = false;
            _patients = _jsonPatientRepository.GetAll();
            if (_patients == null || _patients.Count == 0)
                return false;

            if (_patients != null && _patients.Count != 0)
            {
                foreach (IPatient patient in _patients.Values)
                {
                    _isSuccess = true;
                    _countOfLine++;
                    _view.CountOfLine = _countOfLine;
                    _view.Id = patient.Id;
                    _view.Surname = patient.FullName.Surname;
                    _view.Name = patient.FullName.Name;
                    _view.Patronymic = patient.FullName.Patronymic;
                    _view.DateOfBirth = patient.DateOfBirth;
                    _view.DocumentSeries = patient.DocumentSeries;
                    _view.DocumentNumber = patient.DocumentNumber;
                    _view.PlotNumber = patient.PlotNumber;
                    _view.NumbOfPatientCard = patient.NumbOfPatientCard;
                }
                if (_isSuccess)
                    return true;
                else
                    return false;
            }
            return false;
        }

        public void ShowInfoAboutPatient()
        {
            _patients = _jsonPatientRepository.GetAll();
            if (_patients == null || _patients.Count == 0)
                return;

            if (_patients != null && _patients.Count != 0 && _view.SelectedId != 0)
                _view.InfoAboutPatient = _patients[_view.SelectedId].Format();
        }
        public void RemovePatient()
        {
            _jsonPatientRepository.Remove(_view.SelectedId);
        }
    }
}
