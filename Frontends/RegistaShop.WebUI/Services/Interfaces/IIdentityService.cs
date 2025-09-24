using RegistaShop.DtoLayer.IdentityDtos.LoginDtos;

namespace RegistaShop.WebUI.Services.Interfaces
{
	public interface IIdentityService
	{
		Task<bool> SignIn(SignInDto signInDto);
	}
}
