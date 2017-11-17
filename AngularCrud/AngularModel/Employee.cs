using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngularCrudLibrary
{
    public class Employee 
    {
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public IdentityTypeEnum IdentityType { get; set; }
        public string IdentityNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
