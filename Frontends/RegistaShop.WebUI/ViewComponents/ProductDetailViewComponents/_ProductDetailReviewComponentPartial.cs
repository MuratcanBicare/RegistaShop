﻿using Microsoft.AspNetCore.Mvc;

namespace RegistaShop.WebUI.ViewComponents.ProductDetailViewComponents
{
	public class _ProductDetailReviewComponentPartial : ViewComponent
	{

		public IViewComponentResult Invoke() 
		{ 
			
			return View();
			
		}

	}
}
