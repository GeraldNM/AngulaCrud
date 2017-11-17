using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngularDataAccess
{
    public class DataAccessHelper
    {

        public static List<string> ReadData()
        {
             var data = new AngularCrudIOStream().ReadFile();
            return data.Split(',').ToList();
        }

        public  static void WriteData(string data)
        {
            new AngularCrudIOStream().WriteFile(data);
         
        }
       
    }
}
