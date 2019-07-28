using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagment.Core.Services;
using TaskManagment.Core.BusinessModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TaskManagement.Tests
{
    [TestClass]
    public class UserTaskUnitTest
    {
        private readonly UserTaskService _userTaskService;
        private readonly UserService _userService;

        public UserTaskUnitTest()
        {
            _userTaskService = new UserTaskService();
            _userService = new UserService();
        }

        //[TestMethod]
        //public void AddTaskUnitTest()
        //{
        //    User user = new User();
        //    user.Address = "Mumbai";
        //    user.Email = "akash@a.com";
        //    user.Mobile = 8446997740;
        //    user.Password = "123";
        //    user.UserName = "Akash";
        //    user.Role = "User";

        //    UserTask userTask = new UserTask();

        //    userTask.TaskTitle = "Create new Task";
        //    userTask.TaskDescription = "new description";
        //    userTask.CreateDate = DateTime.Now;
        //    userTask.ModifyDate = DateTime.Now;
        //    userTask.User = user;
        //    _userService.AddUser(user);

        //   var result = _userTaskService.AddTask(userTask);
        //    Assert.AreEqual(true, result);
        //}

        //[TestMethod]
        //public void GetAllDataUserTaskUnitTest()
        //{
        //    Guid id = Guid.Parse("E865F33D-D68B-4087-A84E-AA970130187D");
        //    var task = _userTaskService.GetAllTasks(id);
        //    Assert.AreEqual(1, task.Count);
        //}

        //[TestMethod]
        //public void GetTaskById()
        //{
        //    Guid id = Guid.Parse("118A8BF7-FC7E-4223-B1BA-AA97013018B2");
        //    var task = _userTaskService.GetTaskById(id);
        //    Assert.AreEqual("Create new Task",task.TaskTitle );
        //}

        //[TestMethod]
        //public void UpdateTaskUnitTest()
        //{
        //    Guid id = Guid.Parse("118A8BF7-FC7E-4223-B1BA-AA97013018B2");
        //    UserTask userTask = new UserTask();

        //    userTask.TaskTitle = "Update Task title";
        //    userTask.TaskDescription = "new description";
        //    userTask.ModifyDate = DateTime.Now;

        //    var result = _userTaskService.UpdateTask(userTask ,id);

        //    Assert.AreEqual(true, result);
        //}
        //[TestMethod]
        //public void RemoveUserUnitTest()
        //{
        //    Guid id = Guid.Parse("118A8BF7-FC7E-4223-B1BA-AA97013018B2");
        //    var result = _userTaskService.RemoveTask(id);
        //    Assert.AreEqual(true, result);
        //}
    }
}
