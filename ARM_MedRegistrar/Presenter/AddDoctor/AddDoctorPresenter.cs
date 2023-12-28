using ARM_MedRegistrar.View.AddDoctor;
using ARM_MedRegistrar.Model.Persons.Doctors;
using ARM_MedRegistrar.Model.Persons;
using ARM_MedRegistrar.Data.Json.Dictionaries.DoctorRepository;
using ARM_MedRegistrar.Model.WorkSchedules;
using ARM_MedRegistrar.Model.Persons.PersonalDataOfHumans;
using ARM_MedRegistrar.Data.Json.Dictionaries.FreeTimeOfAppointments;
using ARM_MedRegistrar.Model.FreeTimeOfAppointments;
using ARM_MedRegistrar.Model.DaysWithFreeAppointments;
using ARM_MedRegistrar.Data.Json.Dictionaries;
using ARM_MedRegistrar.Model.WorksBeginningEnd;

namespace ARM_MedRegistrar.Presenter.AddDoctor
{
    public class AddDoctorPresenter : IAddDoctorPresenter
    {
        IAddDoctorForm _view;
        IDoctor _doctor;
        string result;
        int IAddDoctorPresenter.PlotNumber { set => _view.PlotNumber = value; }

        public AddDoctorPresenter(IAddDoctorForm view)
        {
            _view = view;
            _doctor = new Doctor(this);
        }


        public IList<string> SetSpecializations()
        {
            return Doctor.SetSpecialization();
        }

        public bool IsCorrectTime(DateTime timeBeginning, DateTime timeEnd)
        {
            return Doctor.IsCorrectTime(timeBeginning, timeEnd);
        }



        public string SetPlotNumber()
        {
            try
            {
                result = Doctor.SetPlotNumber(_view.Specializations, _view.PlotNumber);
            }

            catch (ArgumentException e)
            {
                return e.Message;
            }

            return result;
        }


        public string AddDoctor()
        {
            try
            {
                result = Doctor.AddDoctor(_view.Surname, _view.Name, _view.Patronymic, _view.PhoneNumber, _view.Specializations, _view.Cabinet, _view.DurationOfAppointment, _view.TimesOfWork);
            }

            catch (ArgumentException e)
            {
                return e.Message;
            }

            return result;
        }

        public string SuccessAdd()
        {
            return Doctor.SuccessAdd();
        }

        public string NoCorrectTime()
        {
            return Doctor.NoCorrectTime();
        }
    }
}
