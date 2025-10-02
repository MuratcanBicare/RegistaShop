using RegistaShop.WebUI.Models;
using RegistaShop.WebUI.Services.Interfaces;

namespace RegistaShop.WebUI.Services.Concrete
{
	public class UserService : IUserService
	{

		private HttpClient _httpClient;

		public UserService(HttpClient httpClient)
		{
			_httpClient = httpClient;
		}

		public async Task<UserDetailViewModel> GetUserInfo()
		{
			return await _httpClient.GetFromJsonAsync<UserDetailViewModel>("/api/users/getuser");
		}
	}
}
