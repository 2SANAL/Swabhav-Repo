using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaskManagment.Core.Services;
using TaskManagment.Core.BusinessModel;

namespace TaskManagement.Tests
{
    [TestClass]
    public class UserTesting
    {
        private readonly UserService service;

        public UserTesting()
        {
            service = new UserService();
        }
        //[TestMethod]
        //public void AddUserTest()
        //{
        //    User user = new User();
        //    user.Address = "Mumbai";
        //    user.Email = "akash@a.com";
        //    user.Mobile = 8446997740;
        //    user.Password = "123";
        //    user.UserName = "Akash";
        //    user.Role = "User";
        //    var r = service.AddUser(user);
        //    Assert.AreEqual(true, r);

        //}

        //[TestMethod]
        //public void GetAllUserTest()
        //{
        //  var users = service.GetAllUsers();
        //    Assert.AreEqual(2,users.Count);
        //}
        //[TestMethod]
        //public void RemoveUserTest()
        //{
        //    Guid id=Guid.Parse("0D1AC8E4-6BF2-4191-8E0D-AA970127526A");

        //   var result= service.RemoveTask(id);
        //   Assert.AreEqual(true,result);
        //}

        //[TestMethod]
        //public void UpdateUnitTest()
        //{
        //    Guid id = Guid.Parse("ABD74488-D356-4698-B27F-AA970123ED2A");
        //    User user = new User();
        //    user.Address = "Pune";
        //    user.Email = "akash@a.com";
        //    user.Mobile = 8446997740;
        //    user.Password = "987";
        //    user.UserName = "Akash";
        //    user.Role = "Admin";
        //    var result = service.UpdateUser(user, id);
        //    Assert.AreEqual(true, result);
        //}
    }
}
