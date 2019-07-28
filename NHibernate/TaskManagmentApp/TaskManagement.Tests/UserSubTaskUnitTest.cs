using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaskManagment.Core.BusinessModel;
using TaskManagment.Core.Services;

namespace TaskManagement.Tests
{
    [TestClass]
    public class UserSubTaskUnitTest
    {
        private readonly UserSubTask _userSubTask;
        private readonly UserSubTaskService _userSubTaskService;

        public UserSubTaskUnitTest()
        {
            _userSubTaskService = new UserSubTaskService();
            _userSubTask = new UserSubTask();
        }

        //[TestMethod]
        //public void AddUserSubTaskUnitTest()
        //{

        //    UserTaskService  userTaskService=new UserTaskService();

        //    var task = userTaskService.GetTaskById(Guid.Parse("88E7CC9F-0564-4E88-8C8A-AA97014680BE"));

        //    _userSubTask.SubTaskTitle = "Create Sub Task";
        //    _userSubTask.SubTaskDescription = "create sub task description";
        //    _userSubTask.SubCreateDate = DateTime.Now;
        //    _userSubTask.SubModifyDate = DateTime.Now;
        //    _userSubTask.UserTask = task;
        //    var r= _userSubTaskService.AddSubTask(_userSubTask);
        //    Assert.AreEqual(true,r);
        //}
        //[TestMethod]
        //public void GetAllSubTaskByTaskIdUnitTest()
        //{
        //    Guid id = Guid.Parse("88E7CC9F-0564-4E88-8C8A-AA97014680BE");
        //    var subtask = _userSubTaskService.GetAllTasks(id);

        //    Assert.AreEqual(1,subtask.Count);
        //}
        //[TestMethod]
        //public void UpdateSubTask()
        //{
        //    Guid id = Guid.Parse("0A669862-9EAD-4AF0-B352-AA9701602AE8");
        //    var subtask = _userSubTaskService.GetTaskById(id);
        //    subtask.SubTaskTitle = "Create Sub Task";
        //    subtask.SubTaskDescription = "update sub task description";
        //    subtask.SubModifyDate = DateTime.Now;
        //    var result = _userSubTaskService.UpdateTask(subtask);
        //    Assert.AreEqual(true, result);
        //}

        //[TestMethod]
        //public void DeleteSubTaskUnitTest()
        //{
        //    Guid id = Guid.Parse("0A669862-9EAD-4AF0-B352-AA9701602AE8");
        //    var result = _userSubTaskService.RemoveTask(id);
        //    Assert.AreEqual(true, result);
        //}
    }
}
