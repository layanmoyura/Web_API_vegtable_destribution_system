using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Online_platform_for_vegetables.Model
{
    public class Order
    {
        public int OrderID { get; set; }
        public double required_amount_kg { get; set; }
        public string Deadline { get; set;  }
        public int progress { get; set; }
        public VegetableStocks vegetableStock { get; set; }
        public Farmer Farmer { get; set; }
        public Customer Customer { get; set;  }
       
        
    }
}
