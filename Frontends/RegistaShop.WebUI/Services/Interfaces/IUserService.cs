using RegistaShop.WebUI.Models;

namespace RegistaShop.WebUI.Services.Interfaces
{
	public interface IUserService
	{
		Task<UserDetailViewModel> GetUserInfo();
	}
}