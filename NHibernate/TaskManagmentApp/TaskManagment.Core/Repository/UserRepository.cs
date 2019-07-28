using System;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Linq;
using TaskManagment.Core.BusinessModel;

namespace TaskManagment.Core.Repository
{
    public class UserRepository
    {
        public bool AddUser(User user)
        {
            using (var session = Helper.OpenSession())
            {
                using (var transaction=session.BeginTransaction())
                {
                    session.Save(user);
                    transaction.Commit();
                    return true;
                }
               
            }
            
        }
        public ICollection<User> GetAllUser()
        {
            using (var session = Helper.OpenSession())
            {
                var allData = session.Query<User>().ToList();
                return allData;
            }
        }

        public User GetUserById(Guid id)
        {
            using (var session = Helper.OpenSession())
            {
                var user = session.Query<User>().Single(m => m.Id == id);
                return user;
            }
        }

        public bool RemoveTask(Guid id)
        {
            using (var session = Helper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    var user = GetUserById(id);
                    session.Delete(user);
                    transaction.Commit();
                    return true;
                }
            }
        }

        public bool Loginvalidation(string username,string password)
        {
            using (var session=Helper.OpenSession())
            {
                var user = session.Query<User>().Where(m => m.UserName.Equals(username) && m.Password.Equals(password));

                if (user.Any())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public bool UpdateUser(User user,Guid id)
        {
            using (var session = Helper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    var user1 = GetUserById(id);
                    user1.Email = user.Email;
                    user1.Mobile = user.Mobile;
                    user1.Password = user.Password;
                    user1.UserName = user.UserName;
                    user1.Address = user.Address;
                    session.SaveOrUpdate(user1);
                    transaction.Commit();
                    return true;
                }
            }
        }
    }
}
