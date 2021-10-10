using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Online_platform_for_vegetables.Model
{
    public class Courier
    {
        public string CourierID { get; set; }
        public string Vehicle_Photo { get; set; }
        public string Vehicle_reg_no { get; set; }
        public string vehicle_contact_no { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
