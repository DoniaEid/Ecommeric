using E_Commeric.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commeric.Models
{
    internal class User
    {

        private int id;
        private string name;
        private string email;
        private string password;

        public User() { }

        public User(int id,string name,string email,string password)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.password = password;
        }
        public int Id {
            get
            {
                return id;
            }
            set{
                id = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Email {

            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }

        public string Password {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }
    }
}
