using E_Commeric.Models;
using E_Commeric.Repository;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commeric.Services
{
    internal class ProductService
    {

        private IProductRepositrycs L;

        public ProductService(IProductRepositrycs L) {
            this.L = L;
        }

        public void AddProduct(Product p)
        {
            L.add(p);
        }

        public void RemoveProduct(int id){
            Product p = L.GetById(id);
            L.delete(p);
        }

        public Product GetId(int id)
        {
            return L.GetById(id);
        }

        public void UpdateProduct(Product c){
            L.Update(c);
        }

        public void IncreaseQuantity(int id, int amount)
        {
            if (amount <= 0)
            {
                throw new Exception("Amount can't Negative.");

            }
            Product p = L.GetById(id);
            p.Quantity += amount;
            L.Update(p);
        }

        public void DecreaseQuantity(int id, int amount)
        {
            if (amount <= 0)
            {
                throw new Exception("Amount must be greater than zero.");
            }

            Product p = L.GetById(id);

            if (p == null)
            {
                throw new Exception("Product not found.");
            }

            if (p.Quantity < amount)
            {
                throw new Exception("Amount is larger than product quantity.");
            }

            p.Quantity -= amount;
            L.Update(p);
        }
        public List<Product> GetAllProducts()
        {
            return L.GetAll();
        }
        public bool Exists(int id)
        {
            return L.GetById(id) != null;
        }
        public List<Product> SearchByName(string name)
        {
            return L.SearchByName(name);
        }



    }
}
