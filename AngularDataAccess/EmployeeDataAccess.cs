using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace AngularDataAccess
{
    public class EmployeeDataAccess : IBaseDataAccess<Employee>
    {

        public  List<Employee> GetAll()
        {
                     
            using (var db = new AngularCrudDbEntities())
            {
              return   db.Employees.ToList();
            }

        }

        public  Employee GetById(long id)
        {
            using (var db = new AngularCrudDbEntities())
            {
              return  db.Employees.FirstOrDefault(x => x.EmployeeId == id);              
            }

        }

        public  Employee Update(Employee employee)
        {
            using (var db = new AngularCrudDbEntities())
            {
                var updateEmployeeObj=  db.Employees.FirstOrDefault(x => x.EmployeeId == employee.EmployeeId);

                if (updateEmployeeObj == null) return employee;

                updateEmployeeObj.DateOfBirth = employee.DateOfBirth;
                updateEmployeeObj.Surname = employee.Surname;
                updateEmployeeObj.FirstName = employee.FirstName;
                updateEmployeeObj.IdentityNumber = employee.IdentityNumber;
                updateEmployeeObj.IdentityType = employee.IdentityType;
                db.SaveChanges();
            }

            return   employee;
        }

        public  Employee Create(Employee employee)
        {    
            using (var db = new AngularCrudDbEntities())
            {
                db.Employees.Add(employee);
                db.SaveChanges();
            }
   
            return employee;
        }

        public  bool Delete(long id)
        {
            using (var db = new AngularCrudDbEntities())
            {
                var employee = db.Employees.FirstOrDefault(x => x.EmployeeId == id);

                if (employee != null) return false;
                db.Employees.Remove(employee);
                db.SaveChanges();
            }

            return true;
        }


        

    }
}
