using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EngineeringCollegeApp
{
    class ConvertToString
    {
        public string StringConvertor(Branches branch)
        {
            if (branch.Equals(Branches.CHEMICAL_ENGINEERING))
            {

                return "Chemical Engineering";
            }
            if (branch.Equals(Branches.COMPUTER_ENGINEERING))
            {

                return "Computer Engineering";
            }
            if (branch.Equals(Branches.ETRX_ENGINEERING))
            {

                return "ETRX Engineering";
            }
            if (branch.Equals(Branches.EXTC_ENGINEERING))
            {

                return "EXTC Engineering";
            }
            if (branch.Equals(Branches.INFORMATION_TECHNOLOGY_ENGINEERING))
            {

                return "Information Technology Engineering";
            }
            if (branch.Equals(Branches.INSTRUMENTATION_ENGINEERING))
            {

                return "Instrumentation Engineering";
            }
            return "";
        }
    }
}
