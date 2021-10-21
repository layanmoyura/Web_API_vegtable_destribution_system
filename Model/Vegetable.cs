using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Online_platform_for_vegetables.Model
{
    public class Vegetable
    {
        [Key]
        public int VegetablesId { get; set; }
        public string Vegtable_image { get; set; }
        public String Name { get; set; }
        public double Max_control_price_country { get; set; }

        public int AdminId { get; set; }
        public Admin Admin { get; set; }

        public List<VegetableStock> VegetableStocks { get; set; }


    }
}
