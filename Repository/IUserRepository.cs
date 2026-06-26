using E_Commeric.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commeric.Repository
{
    internal interface IUserRepository : IRepositry<User>
    {
        User GetById(int id);
        User GetByEmail(string email);
        bool IsEmailExist(string email);
        bool CheckPassword(string email, string password);
        void ChangePassword(int id, string oldPassword, string newPassword);
    }
}
