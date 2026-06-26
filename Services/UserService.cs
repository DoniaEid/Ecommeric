using E_Commeric.Repository;
using E_Commeric.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commeric.Services
{
    internal class UserService
    {
        private IUserRepository repository;

        public UserService(IUserRepository repository)
        {
            this.repository = repository;
        }
        void Login(string email,string password)
        {
                repository.CheckPassword(email, password);
          
        }
        void Register(User u)
        {
                if (repository.IsEmailExist(u.Email))
                {
                    Console.WriteLine("Email already exists!");
                }
                repository. add(u);
        }
        public void UpdateProfile(User user)
        {
           
            repository.Update(user);           
        }
        public void DeleteUser(User user)
        {
                repository.delete(user);
            
        }

        public List<User> GetAllUsers()
        {
            return repository.GetAll();
        }

        public User GetUserById(int id)
        {
               return repository.GetById(id);
            
        }

        public void ChangePassword(int id, string oldPassword, string newPassword)
        {
                repository.ChangePassword(id, oldPassword, newPassword);
        }




    }
}
