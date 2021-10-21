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
    public class AdminController : ControllerBase
    {
        private IMapper mapper;

        public UserManager<Admin> userManager;

        public AdminController(IMapper mapper,UserManager<Admin> userManager)
        {
            this.mapper = mapper;
            this.userManager = userManager;

        }

        [Route("register")]
        [HttpPost]
        public async Task<ActionResult> Register(AdminRegister adminRegister)
        {
            var user = mapper.Map<Admin>(adminRegister);
            var result = await userManager.CreateAsync(user, adminRegister.Password);

            if (result.Succeeded)
            {
                return Ok(201);
            }

            return BadRequest(result.Errors);

        }







    }
}
