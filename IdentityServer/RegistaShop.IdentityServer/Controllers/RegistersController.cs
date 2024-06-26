﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RegistaShop.IdentityServer.Dtos;
using RegistaShop.IdentityServer.Models;
using System.Threading.Tasks;
using static IdentityServer4.IdentityServerConstants;

namespace RegistaShop.IdentityServer.Controllers
{
	[Authorize(LocalApi.PolicyName)]
	[Route("api/[controller]")]
	[ApiController]
	public class RegistersController : ControllerBase
	{

		private readonly UserManager<ApplicationUser> _userManager;

		public RegistersController(UserManager<ApplicationUser> userManager)
		{
			_userManager = userManager;
		}

		[HttpPost]
		public async Task<IActionResult> UserRegister(UserRegisterDto userRegisterDto)
		{

			var value = new ApplicationUser()
			{
				UserName = userRegisterDto.Username,
				Email = userRegisterDto.Email,
				Name = userRegisterDto.Name,
				Surname = userRegisterDto.Surname
			};

			var result = await _userManager.CreateAsync(value, userRegisterDto.Password);

			if (result.Succeeded)
			{
				return Ok("Kullanıcı başarılı şekilde oluşturuldu.");
			}
			else
			{
				return Ok("Bir hata oluştu tekrar deneyiniz.");
			}
		}
	}
}
