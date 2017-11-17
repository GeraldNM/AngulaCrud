using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AngularCrudLibrary;

namespace AngularDataAccess
{
    public class EmployeeDataAccess : BaseDataAccess
    {
        

        public override  object GetAll()
        {
             var emp = new Employee();         
            var data = DataAccessHelper.ReadData();

            if (!data.Any()) return emp;
            emp.Surname = data[0];
            emp.FirstName = data[1];
            emp.IdentityType = (IdentityTypeEnum) Convert.ToInt32(data[2]);
            emp.IdentityNumber = data[3];
            emp.DateOfBirth = new DateTime(Convert.ToInt32(data[4].Split('/')[0]), Convert.ToInt32(data[4].Split('/')[1]),  Convert.ToInt32(data[4].Split('/')[2]));

            return emp;
        }
        public override object GetById(long Id)
        { 
            //to implement
            return new Employee();
        }

        public override object Update(object employee)
        {
            var input = (Employee)Convert.ChangeType(employee, typeof(Employee));
            var data = DataAccessHelper.ReadData();

            if (!data.Any()) return employee;
            data[0] = input.Surname;
            data[1] = input.FirstName;
            data[2] = ((int)input.IdentityType).ToString(CultureInfo.InvariantCulture);
            data[3] = input.IdentityNumber;
            data[4] = input.DateOfBirth.ToString("YYYY/MM/DD");
            DataAccessHelper.WriteData(string.Join(",", data));
            return employee;

         
        }

        public override object Create(object employee)
        { 
            //to implement
            return Update(employee);
        }

        public override bool Delete(long id)
        {

            //to implement
            return true;
        }


        

    }
}
