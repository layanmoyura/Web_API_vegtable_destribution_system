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
    public class FarmerController : ControllerBase
    {
        private IMapper mapper;

        public UserManager<Farmer> userManager;

        public FarmerController(IMapper mapper, UserManager<Farmer> userManager)
        {
            this.mapper = mapper;
            this.userManager = userManager;

        }

        [Route("register")]
        [HttpPost]
        public async Task<ActionResult> Register(FarmerRegister farmerRegister)
        {
            var user = mapper.Map<Farmer>(farmerRegister);
            var result = await userManager.CreateAsync(user, farmerRegister.Password);

            if (result.Succeeded)
            {
                return Ok(201);
            }

            return BadRequest(result.Errors);

        }







    }
}
