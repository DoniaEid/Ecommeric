using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commeric.Models
{
    internal class Product
    {
        private int id;
        private string name;
        private double price;
        private int quantity;
        public Product() { }
        public Product(int id,string name,double price,int quantity)
        {
            this.id = id;
            this.name = name;
            this.Price = price;
            this.quantity = quantity;
        }
        public int Id {
            get
            {
                return id;
            }
            set
            {
                this.id = value;

            }
        }

        public string Name {

            get
            {
                return name;
            }
            set
            {
                this.name = value;
            }
        }

        public double Price {
            get
            {
                return price;
            }
            set
            {
                this.price = value;
            }

        }

        public int Quantity {
            get
            {
                return quantity;
            }
            set
            {
                this.quantity = value;
            }
        }
    }
}
