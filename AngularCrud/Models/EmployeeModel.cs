using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AngularDataAccess;

namespace AngularCrud.Models
{
    public class EmployeeModel
    {
        public List<Employee> GetEmployees()
        {
            return new EmployeeDataAccess().GetAll();
        }

        public Employee GetEmployeeById( long id)
        {
            return new EmployeeDataAccess().GetById(id);
        }

        public Employee UpdateEmployee(Employee emp)
        {
            return new EmployeeDataAccess().Update(emp);
        }

        public Employee CreateEmployee(Employee emp)
        {
            return new EmployeeDataAccess().Create(emp);
        }

        public bool DeleteEmployee( long id)
        {
            return new EmployeeDataAccess().Delete(id);
        }
    }
}