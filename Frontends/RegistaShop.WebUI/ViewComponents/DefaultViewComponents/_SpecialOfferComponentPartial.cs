﻿using Microsoft.AspNetCore.Mvc;

namespace RegistaShop.WebUI.ViewComponents.DefaultViewComponents
{
	public class _SpecialOfferComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}

	}
}
