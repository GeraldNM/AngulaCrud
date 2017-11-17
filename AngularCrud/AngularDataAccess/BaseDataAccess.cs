using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngularDataAccess
{
    abstract public class BaseDataAccess 
    {
       public  abstract object GetAll();
       public abstract object GetById(long id);
       public abstract object Update(object t);
       public abstract bool Delete(long id);
       public abstract object Create(object t);
    }
}
