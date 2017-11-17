using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace AngularDataAccess
{
    public class AngularCrudIOStream
    {
        private string FileName {
            get
            {
                string xsltPath = Path.Combine(System.Web.HttpContext.Current.Server.MapPath(@"~/App_Data"),
                    ConfigurationSettings.AppSettings["DATAFILE"]);
               

                return xsltPath;
            }

            //HttpContext.Current.Server.MapPath(ConfigurationSettings.AppSettings["DATAFILE"]); }
            }
        
   
        public string ReadFile()
        {
            try
            {
                var data = "";
                using (var stream = new StreamReader(FileName))
                {
                    data = stream.ReadLine();
                  
                }

                return data;
            }
            catch (Exception ex)
            {
                throw;
            }
           
        }

        public void WriteFile(string data)
        {
            try
            {
                using (var stream = new StreamWriter(FileName))  // just overite evrything
                {
                    stream.WriteLine(data);
                }
            }
            catch (Exception ex)
            {
                throw;

            }
           

        }
    }
}
