using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AngularCrud.Models;
using AngularCrudLibrary;

namespace AngularCrud.Controllers
{
    public class EmployeeController : BaseController
    {
        //
        // GET: /Employee/

        //EmployeeController()
        //{
        //     DataModel = new BaseModel(DataAccessType.Employee);
        //}
        [HttpGet]
        public ActionResult Index()
        {
            DataModel = new BaseModel(DataAccessType.Employee);
            var objects= DataModel.GetAll();
            return View(objects);
        }

         [HttpGet]
        public JsonResult GetAll()
        {
            DataModel = new BaseModel(DataAccessType.Employee);
            var objects = (Employee)DataModel.GetAll();
            return Json(objects, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult GetById(long id)
        {
            var results = DataModel.GetById(id);
            return Json(results);
        }

        [HttpPost]
        public JsonResult Update(Employee obj)
        {
           var emp= DataModel.Update(obj);
           return  Json(emp);
        }

        [HttpPost]
        public JsonResult Create(Employee obj)
        {
            var emp = DataModel.Create(obj);
            return Json(emp);
        }


        [HttpPost]
        public JsonResult Delete(long id)
        {
            var results = DataModel.Delete(id);
            return Json(results);
        }
    }
}
