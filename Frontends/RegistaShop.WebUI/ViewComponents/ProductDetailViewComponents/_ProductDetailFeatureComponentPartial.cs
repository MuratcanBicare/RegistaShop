﻿using Microsoft.AspNetCore.Mvc;

namespace RegistaShop.WebUI.ViewComponents.ProductDetailViewComponents
{
	public class _ProductDetailFeatureComponentPartial : ViewComponent
	{

		public IViewComponentResult Invoke()
		{
			return View();
		}

	}
}
