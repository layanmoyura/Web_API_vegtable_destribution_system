﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Online_platform_for_vegetables.Model
{
    public class Customer: IdentityUser
    {
        [Key]
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { set; get; }
        public string Living_City { get; set; }
        public string Profile_Picture { get; set; }
        public string NIC_No { get; set; }
        public string Profile_Photo { get; set; }

        public List<Order> Orders { get; set; }
        public List<Payment> payments { get; set; }




    }

}
