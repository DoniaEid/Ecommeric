using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commeric.Models
{
    internal class Customer:User
    {
        private string address;
        private string phone;
        public string Address {
            get
            {
                return address;
            }
            set
            {
                phone = value;
            }
        
        }
        public string Phone {
            get
            {
                return phone;
            }
            set
            {
                phone = value;
            }
        
        }
    }
}
