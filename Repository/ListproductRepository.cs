using E_Commeric.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commeric.Repository
{
    internal class ListproductRepository: IProductRepositrycs
    {


        List<Product> Products = new List<Product>();
        public void add(Product p)
        {
            Products.Add(p);
        }

        public void delete(Product p)
        {
            foreach (var l in Products)
            {
                if (l.Id == p.Id)
                {
                    Products.Remove(l);
                    return;
                }
            }

            throw new Exception("Product not Found!");

        }

        public void Update(Product o)
        {
            for (int i = 0; i < Products.Count; i++)
            {
                if (Products[i].Id == o.Id)
                {
                    Products[i] = o;
                    return;
                }
            }
            throw new Exception("Product not found!");
        }

        public List<Product> GetAll()
        {
            return Products;
        }

        public Product GetById(int id)
        {
            foreach (var l in Products)
            {
                if (l.Id == id)
                {
                    return l;
                }
            }

            throw new Exception("Product not Found!");
        }

        public int GetProductQuantity(int id)
        {
            foreach (var l in Products)
            {
                if (l.Id == id)
                {
                    return l.Quantity;
                }
            }

            throw new Exception("Product not Found!");
        }

        public List<Product> SearchByName(string name)
        {
            List <Product>li= new List<Product>();
            foreach (var l in Products)
            {
                if (l.Name == name)
                {
                    li.Add(l);
                }
            }
            if (li.Count == 0)
            {
                throw new Exception($"product {name} is not found");
            }
            return li;
        }
    }
}
