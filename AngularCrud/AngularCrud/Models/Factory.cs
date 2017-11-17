using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Configuration;
using AngularCrudLibrary;
using AngularDataAccess;

namespace AngularCrud.Models
{
    public class Factory 
    {
         public BaseDataAccess accessType = null;


        public Factory(DataAccessType t) 
        {
           
            switch (t)
            {
                case DataAccessType.Employee:
                    accessType = new EmployeeDataAccess(); 
                  //  accessType= typeof (EmployeeDataAccess); //EmployeeDataAccess(); 
                    break;

               // case DataAccessType.Products:
                 //   accessType = new EmployeeDataAccess();  // products dataacess
                  //  break;
            }

          
        }

    }
}