using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_EFC_02.DAL.Entities
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }


        public Category Category { get; set; }
        public List<Bundle> Bundles { get; set; } = new();
    }
}
