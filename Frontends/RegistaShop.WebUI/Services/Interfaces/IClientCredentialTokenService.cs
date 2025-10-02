namespace RegistaShop.WebUI.Services.Interfaces
{
	public interface IClientCredentialTokenService
	{
		Task<string> GetToken();
	}
}
