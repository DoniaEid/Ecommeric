using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commeric.Models
{
    internal class Admin:User
    {
        private DateTime hireDate;
        private double salary;
        public DateTime HireDate {
            get
            {
                return hireDate;
            }
            set
            {
                hireDate = value;
            }
         }
        public double Salary {

            get
            {
                return salary;
            }
            set
            {
                if (value >= 0)
                    salary = value;
            }

        }
    }
}
