using E_Commeric.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commeric.Repository
{
    internal class ListUserRepository: IUserRepository
    {
        List<User> users = new List<User>();
       public void add(User u)
        {
            users.Add(u);
        }

        public void delete(User u)
        {
                foreach (var l in users)
                {
                    if (l.Id == u.Id)
                    {
                        users.Remove(u);
                        break;
                    }
                }
          
                throw new Exception("User not Found!");
            
        }

        public void Update(User o)
        {
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].Id == o.Id)
                {
                    users[i] = o;
                    return;
                }
            }
            throw new Exception("User not found!");
        }

       public List<User> GetAll()
        {
            return users;
        }

        public User GetById(int id)
        {
            foreach (var l in users)
            {
                if (l.Id == id)
                {
                    return l;
                    break;
                }
            }

            throw new Exception("User not Found!");
        }

        public User GetByEmail(string email)
        {
            foreach (var l in users)
            {
                if (l.Email == email)
                {
                    return l;
                    break;
                }
            }

            throw new Exception("User not Found!");
        }

       public bool IsEmailExist(string email)
        {
            foreach (var l in users)
            {
                if (l.Email==email)
                {
                    return true;
                    break;
                }
            }

            throw new Exception("User not Found!");
        }
        public bool CheckPassword(string email, string password)
        {

            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].Email== email)
                {
                    if(users[i].Password == password)
                    {
                        return true;
                    }
                }
            }
            throw new Exception("password is false or email is false try again!");
        }
        public void ChangePassword(int id, string oldPassword, string newPassword)
        {
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].Id == id&& users[i].Password == oldPassword)
                {
                    users[i].Password = newPassword;
                }
            }
            throw new Exception("password is false or email is false try again!");
        }
    }
}
