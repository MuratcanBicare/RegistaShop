namespace RegistaShop.WebUI.Settings
{
	public class ClientSettings
	{

		public Client RegistaShopVisitorClient { get; set; }
		public Client RegistaShopManagerClient { get; set; }
		public Client RegistaShopAdminClient { get; set; }

	}

	public class Client
	{

		public string ClientId { get; set; }
		public string ClientSecret { get; set; }

	}
}
