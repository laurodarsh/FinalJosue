using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal.Classes
{
    public class Product
    {
        private int id = 0;
        private string name;
        private float price;
        private bool active;
        Category category;

        public Product(string name, float price, bool active, Category category)
        {
            this.name = name;
            this.price = price;
            this.active = active;
            this.category = category;
        }

        public Product()
        {
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public float Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }

        public bool Active
        {
            get
            {
                return active;
            }

            set
            {
                active = value;
            }
        }

        public Category Category
        {
            get
            {
                return category;
            }

            set
            {
                category = value;
            }
        }
    }
}
