using System;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DepartmentMvcApp.Controllers;
using DepartmentMvcApp.Model;

namespace DepartmentUnitTest
{
    [TestClass]
    public class DepartmentTestCase
    {
        //DepartmentController departmentController = new DepartmentController();
        //AddViewModel addViewModel = new AddViewModel();

        //[TestMethod]
        //public void TestDepartmentIndex()
        //{

        //    ActionResult result = departmentController.Index() as ViewResult;
        //    Assert.IsNotNull(result);

        //}

        //[TestMethod]
        //public void TestDeaprtmentAdd()
        //{
        //    ActionResult result = departmentController.Add() as ViewResult;
        //    Assert.IsNotNull(result);
        //}

        ////[TestMethod]
        ////public void TestDeptAddDeparamete()
        ////{

        ////    addViewModel.DepartmentName = "Extc";
        ////    addViewModel.Location = "Mum";
        ////    addViewModel.Id = Guid.NewGuid();
        ////    ActionResult result = departmentController.Add(addViewModel);
        ////    Assert.IsInstanceOfType(result, typeof(RedirectToRouteResult));
        ////}

        //[TestMethod]
        //public void TestEditDepartment()
        //{
        //    Guid id = Guid.Parse("4dc2091b-e418-4107-b394-29f652c11dca");
        //    ViewResult result = departmentController.Edit(id) as ViewResult;
        //    Assert.IsNotNull(result);
        //}

        //[TestMethod]
        //public void TestEditPostDept()
        //{EditViewModel editViewModel=new EditViewModel();
        //editViewModel.Id=Guid.Parse("4dc2091b-e418-4107-b394-29f652c11dca");
        //editViewModel.DepartmentName = "EE";
        //editViewModel.Location = "Thane";
        //ActionResult result = departmentController.Edit(editViewModel);
        //Assert.IsInstanceOfType(result,typeof(RedirectToRouteResult));
        //}
    }
}
