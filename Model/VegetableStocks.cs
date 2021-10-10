using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Online_platform_for_vegetables.Model
{
    public class VegetableStocks
    {
        public int VegetableStocksID { get; set; }
        public double Amount_kg { get; set; }
        public DateTime Updated_Time { get; set; }
        public double Farmers_price_per_kg_Rs { get; set; }
        public Vegetables vegetable { get; set; }
        public Farmer Farmer { get; set; }

    }
}
