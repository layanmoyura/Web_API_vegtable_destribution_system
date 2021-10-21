using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Online_platform_for_vegetables.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Online_platform_for_vegetables.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private IMapper mapper;

        public UserManager<Customer> userManager;

        public CustomerController(IMapper mapper, UserManager<Customer> userManager)
        {
            this.mapper = mapper;
            this.userManager = userManager;

        }

        [Route("register")]
        [HttpPost]
        public async Task<ActionResult> Register(CustomerRegister customerRegister)
        {
            var user = mapper.Map<Customer>(customerRegister);
            var result = await userManager.CreateAsync(user, customerRegister.Password);

            if (result.Succeeded)
            {
                return Ok(201);
            }

            return BadRequest(result.Errors);

        }







    }
}
