﻿using Microsoft.AspNetCore.Mvc;

using Azure;
using ProjektniZadatak.Models.DTO;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace ProjektniZadatak.Controllers
{


    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {

        private readonly UserManager<IdentityUser> _userManager;

        private readonly RoleManager<IdentityRole> _roleManager;

        private readonly IConfiguration _configuration;


        public AuthController(
            UserManager<IdentityUser> userManager,
            RoleManager<IdentityRole> roleManager,
            IConfiguration configuration)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _configuration = configuration;
        }

        private JwtSecurityToken getToken(List<Claim> authClaims)
        {
            var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Secret"]));

            var token = new JwtSecurityToken(
                issuer: _configuration["JWT:ValidIssuer"],
                audience: _configuration["JWT:ValidAudience"],
                expires: DateTime.Now.AddHours(3),
                claims: authClaims,
                signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)
                );

            return token;
        }

        [HttpPost]
        [Route("login")]

        public async Task<IActionResult> Login([FromBody] LoginUserRequest model)
        {
            var korisnik = await _userManager.FindByNameAsync(model.Username);

            if (korisnik != null && await _userManager.CheckPasswordAsync(korisnik, model.Password))
            {
                var userRoles = await _userManager.GetRolesAsync(korisnik);

                var authClaims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, korisnik.UserName),
                    new Claim (JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                };

                foreach (var userRole in userRoles)
                {
                    authClaims.Add(new Claim(ClaimTypes.Role, userRole));
                }

                var token = getToken(authClaims);

                return Ok(new
                {
                    token = new JwtSecurityTokenHandler().WriteToken(token),
                    expiration = token.ValidTo
                });
            }

            return Unauthorized();
        }

        [HttpPost]
        [Route("register")]

        public async Task<IActionResult> Register([FromBody] RegisterUserRequest model)
        {
            var userExists = await _userManager.FindByNameAsync(model.Username);

            if (userExists != null)

                return StatusCode(StatusCodes.Status500InternalServerError);

            IdentityUser user = new()
            {
                Email = model.Email,
                SecurityStamp = Guid.NewGuid().ToString(),
                UserName = model.Username
            };

            var result = await _userManager.CreateAsync(user, model.Password);
            if (!result.Succeeded)
                return StatusCode(StatusCodes.Status500InternalServerError);

            if (!await _roleManager.RoleExistsAsync(Roles.Korisnik))
                await _roleManager.CreateAsync(new IdentityRole(Roles.Korisnik));

            if (await _roleManager.RoleExistsAsync(Roles.Korisnik))
                await _userManager.AddToRoleAsync(user, Roles.Korisnik);

            return Ok();
        }

        [HttpPost]
        [Route("register-admin")]

        public async Task<IActionResult> RegisterAdmin([FromBody] RegisterUserRequest model)
        {
            var userExists = await _userManager.FindByNameAsync(model.Username);

            if (userExists != null)

                return StatusCode(StatusCodes.Status500InternalServerError);

            IdentityUser user = new()
            {
                Email = model.Email,
                SecurityStamp = Guid.NewGuid().ToString(),
                UserName = model.Username
            };

            var result = await _userManager.CreateAsync(user, model.Password);
            if (!result.Succeeded)
                return StatusCode(StatusCodes.Status500InternalServerError);

            if (!await _roleManager.RoleExistsAsync(Roles.Admin))
                await _roleManager.CreateAsync(new IdentityRole(Roles.Admin));

            if (!await _roleManager.RoleExistsAsync(Roles.Korisnik))
                await _roleManager.CreateAsync(new IdentityRole(Roles.Korisnik));

            if (await _roleManager.RoleExistsAsync(Roles.Admin))
                await _userManager.AddToRoleAsync(user, Roles.Admin);

            if (await _roleManager.RoleExistsAsync(Roles.Korisnik))
                await _userManager.AddToRoleAsync(user, Roles.Korisnik);

            return Ok();


        }
    }
}
