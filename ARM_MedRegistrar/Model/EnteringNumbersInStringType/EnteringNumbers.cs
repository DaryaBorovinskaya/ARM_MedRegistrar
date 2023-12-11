using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARM_MedRegistrar.Model.EnteringNumbersInStringType
{
    public class EnteringNumbers : IEnteringNumbers
    {
        public static bool IsContainLetter(string line)
        {
            foreach (var item in line)
                if (line[item] < 48 || line[item] > 57)
                    return true;
            
            return false;
        }
    }
}
