using ARM_MedRegistrar.Model.Persons;
using ARM_MedRegistrar.Model.Persons.PersonalDataOfHumans;
using Microsoft.VisualBasic.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ARM_MedRegistrar.Model.Persons.Users
{

    public class User : IUser
    {
        //private IPersonalData _personalData;
        //private string _post;
        

        public IPersonalData PersonalData { get; set; }
        //{
        //    get => _personalData;
        //    set
        //    {
        //        if (value == null)
        //            throw new ArgumentException("Попытка присвоить значение null полю Персональные данные");
        //        _personalData = value;
        //    }
        //}
        public string Login { get; set; }
        public string SaltPassword { get; set; }
        public string Post { get; set; }
        //{
        //    get => _post;
        //    set
        //    {
        //        if (value == "" || value == " " || value == null)
        //            throw new ArgumentException("Должность не задана");

        //        _post = value;
        //    }
        //}

        public byte[] Salt { get; set; }


        public User()
        {

        }

        [JsonConstructor]
        public User(IPersonalData personalData, string login, byte[] salt, string saltPassword,  string post)
        {
            if (personalData == null)
                throw new ArgumentException("Попытка присвоить значение null полю Персональные данные");
            if (login == "" || login == " " || login == null)
                throw new ArgumentException("Логин не задан");

            if (saltPassword == "" || saltPassword == " " || saltPassword == null)
                throw new ArgumentException("Пароль не задан");
            if (post == "" || post == " " || post == null)
                throw new ArgumentException("Должность не задана");


            PersonalData = personalData;
            Login = login;
            Post = post;
            Salt = salt;
            SaltPassword = saltPassword; 
        }

        
        


    }
}
