﻿using Microsoft.AspNetCore.Mvc;

namespace RegistaShop.WebUI.ViewComponents.ProductListViewComponents
{
	public class _ProductListGetProductCountComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}

	}
}
