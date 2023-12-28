using ARM_MedRegistrar.Data.Json.Dictionaries;
using ARM_MedRegistrar.Data.Json.Dictionaries.DoctorRepository;
using ARM_MedRegistrar.Model.Persons.Doctors;
using ARM_MedRegistrar.View.Doctors;


namespace ARM_MedRegistrar.Presenter.Doctors
{
    public class DoctorsPresenter : IDoctorPresenter
    {
        string result;
        IDoctorsForm _view;
        IDoctor _doctor;
        uint IDoctorPresenter.Id { set => _view.Id = value; }
        int IDoctorPresenter.CountOfLine { set => _view.CountOfLine = value; }
        string IDoctorPresenter.Surname { set => _view.Surname = value; }
        string IDoctorPresenter.Name { set => _view.Name = value; }
        string? IDoctorPresenter.Patronymic { set => _view.Patronymic = value; }
        string IDoctorPresenter.Specialization { set => _view.Specialization = value; }
        int IDoctorPresenter.PlotNumber { set => _view.PlotNumber = value; }
        int IDoctorPresenter.Cabinet { set => _view.Cabinet = value; }
        string IDoctorPresenter.InfoAboutDoctor { set => _view.InfoAboutDoctor = value; }

        public DoctorsPresenter(IDoctorsForm view)
        {
            _view = view;
            _doctor = new Doctor(this);
        }

        public IList<string> SetSpecialization()
        {
            return Doctor.SetSpecialization();
        }
        public string EmptyList()
        {
            return Doctor.EmptyList();
        }

        public string SuccessRemove()
        {
            return Doctor.SuccessRemove();
        }

        public string FailureRemove()
        {
            return Doctor.FailureRemove();
        }


        public string CheckAccessLevel()
        {
            try
            {
                result = Doctor.CheckAccessLevel();
            }

            catch (ArgumentException e)
            {
                return e.Message;
            }

            return result;
        }


        public string ConfirmationRemove(string line)
        {
            return Doctor.ConfirmationRemove(line);
        }



        public string SearchDoctor()
        {
            try
            {
                result = Doctor.SearchDoctor(_view.Surname, _view.Name, _view.Specialization);
            }

            catch (ArgumentException e)
            {
                return e.Message;
            }

            return result;

        }





        public string ShowAllDoctors()
        {
            try
            {
                result = Doctor.ShowAllDoctors();
            }

            catch (ArgumentException e)
            {
                return e.Message;
            }

            return result;
        }

        public string ShowInfoAboutDoctor()
        {
            try
            {
                result = Doctor.ShowInfoAboutDoctor(_view.SelectedId);
            }

            catch (ArgumentException e)
            {
                return e.Message;
            }

            return result;
        }
        public string RemoveDoctor(IList<uint> _listOfId)
        {
            try
            {
                result = Doctor.RemoveDoctor(_listOfId);
            }

            catch (ArgumentException e)
            {
                return e.Message;
            }

            return result;
        }

        public string MultiSelect()
        {
            return Doctor.MultiSelect();
        }


    }

}
