using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commeric.Repository
{
    internal interface IRepositry<T>
    {
        void add(T t);
        void delete(T t);
        void Update(T o);
        List<T> GetAll();
    }
}
