using CourseworkTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARM_MedRegistrar
{
    public class SchedOfCallingAtHome            //расписание приёмов на дому
    {
        private List<CallingAtHome> _callingsAtHome;

        public SchedOfCallingAtHome()
        {
            _callingsAtHome = new List<CallingAtHome>();
        }



        public bool AddCallingAtHome(CallingAtHome callingAtHome)
        {
            if (callingAtHome == null) throw new ArgumentNullException(nameof(callingAtHome));

            if (_callingsAtHome.Contains(callingAtHome))
                return false;

            _callingsAtHome.Add(callingAtHome);
            return true;
        }



        public bool DelCallingAtHome(CallingAtHome callingAtHome)
        {
            if (!_callingsAtHome.Contains(callingAtHome))
                return false;

            _callingsAtHome.Remove(callingAtHome);
            return true;
        }


        
    }
}
