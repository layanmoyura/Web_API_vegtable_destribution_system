using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Online_platform_for_vegetables.Model
{
    public class Admin:IdentityUser
    {
        [Key]
        public int AdminId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NIC_No { get; set; }
        public string Profile_Photo { get; set; }

        public List<Vegetable> Vegetables { get; set; }
        public List<Delivery> Deliveries { get; set; }



    }
}
