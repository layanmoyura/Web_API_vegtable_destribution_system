using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Online_platform_for_vegetables.Model
{
    public class VegetableStock
    {
        [Key]
        public int VegetableStocksId { get; set; }
        public double Amount { get; set; }
        public DateTime Updated_Time { get; set; }
        public double Farmers_price_per_kg { get; set; }

        public int VegetablesId { get; set; }
        public Vegetable vegetables { get; set; }

        public int FarmerId { get; set; }
        public Farmer Farmer { get; set; }


        public List<Order> Orders { get; set; }

    }
}
