﻿using Microsoft.AspNetCore.Mvc;

namespace RegistaShop.WebUI.ViewComponents.ProductListViewComponents
{
	public class _ProductListComponentPartial : ViewComponent
	{

		public IViewComponentResult Invoke()
		{
			return View();
		}

	}
}
