using System;
using System.Collections.Generic;
using System.Linq;
using FluentNHibernate.Testing.Values;
using TaskManagment.Core.Repository;
using TaskManagment.Core.BusinessModel;


namespace TaskManagment.Core.Services
{
    public class UserService
    {
        private readonly UserRepository _userRepository;

        public UserService()
        {
            _userRepository = new UserRepository();
        }

        public bool Loginvalidation(string username, string password)
        {
            return _userRepository.Loginvalidation(username, password);
        }

        public bool AddUser(User user)
        {
            if (user != null)
            {
                var result = _userRepository.AddUser(user);
                return result;
            }
            else
            {
                return false;
            }
        }

        public bool RemoveTask(Guid id)
        {
            var result = _userRepository.RemoveTask(id);
            return result;
        }
        public bool UpdateUser(User user,Guid id)
        {
            if (user != null)
            {
                var result = _userRepository.UpdateUser(user,id);
                return result;
            }
            else
            {
                return false;
            }
        }

        public List<User> GetAllUsers()
        {
            return _userRepository.GetAllUser().ToList();
        }
    }
}
