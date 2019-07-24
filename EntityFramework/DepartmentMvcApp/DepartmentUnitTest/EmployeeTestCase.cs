using System;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DepartmentMvcApp.Controllers;
using DepartmentMvcApp.Model;

namespace DepartmentUnitTest
{
    [TestClass]
    public class EmployeeTestCase
    {
        EmployeeController employeeController = new EmployeeController();


        [TestMethod]
        public void TestEmployeeIndex()
        {
            Guid id = Guid.Parse("1cf71900-2f71-4bc2-ae50-a994866ab9d2");
            ActionResult result = employeeController.Index(id) as ViewResult;
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void TestEmployeeAdd()
        {
            ActionResult result = employeeController.Add() as ViewResult;
            Assert.IsNotNull(result);
        }

        //[TestMethod]
        //public void TestAddPostEmployee()
        //{
        //    addViewModel.DepartmentName = "Extc";
        //    addViewModel.Location = "Mum";
        //    addViewModel.Id = Guid.NewGuid();
        //    ActionResult result = departmentController.Add(addViewModel);
        //    Assert.IsInstanceOfType(result, typeof(RedirectToRouteResult));
        //}

        [TestMethod]
        public void TestEditGetEmployee()
        {
            Guid id = Guid.Parse("819c998c-dbc2-4890-a6e3-0f2bb8f8f133");
            var result = employeeController.EditEmployee(id) as ViewResult;
            Assert.IsNotNull(result);
        }

        //[TestMethod]
        //public void TestGetAllEmployee()
        //{
        //var result=  employeeController.EmployeDetails() as ViewResult;
        //Assert.IsNotNull(result);
        //}
    }
}
