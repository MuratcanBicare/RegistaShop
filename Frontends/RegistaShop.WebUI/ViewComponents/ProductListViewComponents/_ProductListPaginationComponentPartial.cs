﻿using Microsoft.AspNetCore.Mvc;

namespace RegistaShop.WebUI.ViewComponents.ProductListViewComponents
{
	public class _ProductListPaginationComponentPartial : ViewComponent
	{

		public IViewComponentResult Invoke()
		{
			return View();
		}

	}
}
