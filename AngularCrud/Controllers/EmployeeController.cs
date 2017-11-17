using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AngularCrud.Models;
using AngularDataAccess;

namespace AngularCrud.Controllers
{
    public class EmployeeController : Controller
    {
        //
        // GET: /Employee/
        readonly EmployeeModel _model = new EmployeeModel();

       public ActionResult Index()
       {

           var dd = _model.GetEmployees();
           return View();
       }

       [HttpGet]
       public JsonResult GetEmployees()
       {
       
           var dd = _model.GetEmployees();
           return Json(_model.GetEmployees(), JsonRequestBehavior.AllowGet);
       }

       [HttpGet]
       public JsonResult GetEmployeeById(long id)
       {
           return Json(_model.GetEmployeeById(id), JsonRequestBehavior.AllowGet);
       }

       [HttpPost]
       public JsonResult CreateEmployee(Employee emp)
       {
           return Json(_model.CreateEmployee(emp), JsonRequestBehavior.AllowGet);
       }

       [HttpPost]
       public JsonResult UpdateEmployee(Employee emp)
       {
           return Json(_model.UpdateEmployee(emp), JsonRequestBehavior.AllowGet);
       }

       [HttpPost]
       public JsonResult DeleteEmployee(long id)
       {
           return Json(_model.DeleteEmployee(id), JsonRequestBehavior.AllowGet);
       }

    }
}
