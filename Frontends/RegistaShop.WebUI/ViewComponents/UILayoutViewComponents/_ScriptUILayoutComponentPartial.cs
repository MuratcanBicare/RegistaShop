﻿using Microsoft.AspNetCore.Mvc;

namespace RegistaShop.WebUI.ViewComponents.UILayoutViewComponents
{
	public class _ScriptUILayoutComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}

	}
}
