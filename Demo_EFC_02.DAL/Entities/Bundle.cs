using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_EFC_02.DAL.Entities
{
    public class Bundle
    {
        public int BundleId { get; set; }
        public string Name { get; set; }
        public double Discount { get; set; }


        public List<Product> Products { get; set; } = new();
    }
}
