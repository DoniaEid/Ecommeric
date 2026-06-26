using E_Commeric.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commeric.Repository
{
    internal interface IProductRepositrycs:IRepositry<Product>
    {
        Product GetById(int id);
        int GetProductQuantity(int id);
        List<Product> SearchByName(string name);
    }

}
