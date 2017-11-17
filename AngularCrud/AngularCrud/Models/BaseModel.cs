using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AngularCrudLibrary;
using AngularDataAccess;
using Antlr.Runtime;
using Microsoft.Ajax.Utilities;

namespace AngularCrud.Models
{
    public class BaseModel
    {

        public BaseModel(DataAccessType tt)
        {
            _dataAccess = new  Factory(tt);
        }

        private readonly Factory _dataAccess = null;

        public object GetAll()
        {
            var _objs = _dataAccess.accessType.GetAll();

            return _objs;
        }


        public object GetById(long Id)
        {
            var _obj = _dataAccess.accessType.GetById(Id);

            return _obj;
        }

        public object Create (object obj)
        {
            var _obj = _dataAccess.accessType.Create(obj);

            return _obj;
        }


        public object Update(object obj)
        {
            var _obj = _dataAccess.accessType.Update(obj);

            return _obj;
        }

        public object Delete(long Id)
        {
            var employee = _dataAccess.accessType.Delete(Id);

            return employee;
        }

    }
}