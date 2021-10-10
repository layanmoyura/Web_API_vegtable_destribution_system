using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Online_platform_for_vegetables.Model
{
    public class Farmer
    {
        public int FarmerID { get; set; }
        public string Profile_Picture { get; set; }
        public string Name { get; set; }
        public string Living_city { get; set; }
        public string Bank { get; set; }
        public string Account_no { get; set; }
        public string Phone_or_Email { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public string Ratings { get; set; }
    }
}
