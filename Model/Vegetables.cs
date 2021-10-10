using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Online_platform_for_vegetables.Model
{
    public class Vegetables
    {
        public int VegetablesID { get; set; }
        public string Vegtable_image { get; set; }
        public String Name { get; set; }
        public double Max_control_price_Rs { get; set; }
        public DateTime Updated_time { get; set; }
        
        public Admin Updated_Admin { get; set; }
        
    }
}
