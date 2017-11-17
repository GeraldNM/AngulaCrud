using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngularDataAccess
{
     public interface IBaseDataAccess<T> where T : new()
     {
         List<T> GetAll();
         T GetById(long id);
         T Update(T t);
         bool Delete(long id);
         T Create(T t);
     }

}
