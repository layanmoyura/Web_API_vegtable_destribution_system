using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Online_platform_for_vegetables.Model
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        public double required_amount_kg { get; set; }
        public string Deadline { get; set;  }
        public int progress { get; set; }
        public bool Supplied_or_not { get; set; }


        public int VegetableStocksId { get; set; }
        public VegetableStock vegetableStock { get; set; }

        public int FarmerId { get; set; }
        public Farmer Farmer { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set;  }

       public List<Delivery> Deliveries { get; set; }
        public List<Payment> Payments { get; set; }


    }
}
