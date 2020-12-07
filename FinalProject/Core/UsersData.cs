using FinalProject.Roles;
using System;
using System.Collections.Generic;

namespace FinalProject
{
    public class UsersData
    {


        private List<User> _users;

        public UsersData()
        {
            _users = new List<User>();
            AddDefaultUsers(_users);
        }
        private void AddDefaultUsers(List<User> list)
        {
            list.Add(new User { Email = "admin@", Password = "12345",UserType = UserRole.Admin});

            list.Add(new User { Name = "Ali" , Surname = "Mecidzade", Email = "ali@", Password = "12345",Age = 14, UserType = UserRole.User});

        }
        

        
   
        public void Add(User user)
        {
            if(user != null)
            {
                _users.Add(user);
            }
        }


        public User FindUser(string email,string password)
        {
            User foundUser = null;
            foreach (User user in _users)
            {
                if(user.Email == email && user.Password == password)
                {
                    foundUser = user;
                }
            }
            return foundUser;
        }
        public bool UserExist(User user)
        {
            bool userExists = false;
            if (user != null)
            {
                foreach (User _user in _users)
                {
                    if (user.Email == _user.Email && user.Password == _user.Password)
                    {
                        userExists = true;
                    }
                }           
            }
            return userExists;
        }
         
        public bool UserExist(string email,string password)
            {
                bool userExists = false;
            if(!string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(password))
            {
                foreach (User user in _users)
                {
                    if (user.Email == email && user.Password == password)
                    {
                        userExists = true;
                    }
                }
            }
            return userExists;
            }
        public List<User> GetAll()
        {
            return _users;
        }

        public List<User> GetUsers()
        {
            List<User> onlyUsers = new List<User>();
            foreach (var user in _users)
            {
                if (user.UserType == Roles.UserRole.User)
                {
                    onlyUsers.Add(user);
                }
                
            }
            return onlyUsers;
        }
    }
}
