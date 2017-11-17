using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AngularCrud.Models;

namespace AngularCrud.Controllers
{
    public class BaseController : Controller
    {
        public BaseController()
        {
        }

        public BaseModel DataModel { get; set; }

     

    }
}
