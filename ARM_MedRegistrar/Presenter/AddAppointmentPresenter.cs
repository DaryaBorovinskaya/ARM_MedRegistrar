using ARM_MedRegistrar.Data.Json.Dictionaries.DoctorRepository;
using ARM_MedRegistrar.Data.Json.Dictionaries.PatientRepository;
using ARM_MedRegistrar.Model.Persons.Doctors;
using ARM_MedRegistrar.Model.Persons.Patients;
using ARM_MedRegistrar.Model.WorkSchedules;
using ARM_MedRegistrar.View.AddAppointment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARM_MedRegistrar.Presenter
{
    public class AddAppointmentPresenter
    {
        IAddAppointmentForm _view;
        IDoctorRepository _jsonDoctorRepository;
        IDictionary<uint, IDoctor>? _doctors;
        IPatientRepository _jsonPatientRepository;
        IDictionary<uint, IPatient>? _patients;
        int _countOfLine = -1;
        bool _isSuccess;

        public AddAppointmentPresenter(IAddAppointmentForm view)
        {
            _view = view;
            _jsonDoctorRepository = new JsonDoctorRepository();
            _jsonPatientRepository = new JsonPatientRepository();
        }

        public bool ShowAllDoctors()
        {
            _countOfLine = -1;
            _isSuccess = false;
            _doctors = _jsonDoctorRepository.GetAll();
            if (_doctors == null || _doctors.Count == 0)
                return false;

            if (_doctors != null && _doctors.Count != 0)
            {
                foreach (IDoctor doctor in _doctors.Values)
                {
                    _isSuccess = true;
                    _countOfLine++;
                    _view.DoctorCountOfLine = _countOfLine;
                    _view.DoctorId = doctor.Id;
                    _view.DoctorSurname = doctor.FullName.Surname;
                    _view.DoctorName = doctor.FullName.Name;
                    _view.DoctorPatronymic = doctor.FullName.Patronymic;
                    _view.DoctorSpecialization = doctor.Specialization;
                    _view.DoctorCabinet = doctor.Cabinet;
                    _view.DoctorPlotNumber = doctor.PlotNumber;
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
            _countOfLine = -1;
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
                    _view.PatientCountOfLine = _countOfLine;
                    _view.PatientId = patient.Id;
                    _view.PatientSurname = patient.FullName.Surname;
                    _view.PatientName = patient.FullName.Name;
                    _view.PatientPatronymic = patient.FullName.Patronymic;
                    _view.PatientDateOfBirth = patient.DateOfBirth;

                }
                if (_isSuccess)
                    return true;
                else
                    return false;
            }
            return false;
        }

        public bool WorkingDoctors()
        {
            _isSuccess = false;
            _doctors = _jsonDoctorRepository.GetAll();
            if (_doctors == null || _doctors.Count == 0)
                return false;

            //if (_doctors != null && _doctors.Count != 0)
            //{
            //    foreach(IDoctor doctor in _doctors.Values)
            //    {
            //        foreach(IWorkSchedule workSchedule in doctor.WorkSchedule)
            //        {
            //            if (workSchedule.DayOfWeek == _view.DayOfAppointment.DayOfWeek.ToString())
            //        }
            //    }



            //    return true;
            //}
            return false;
        }
    }
}
