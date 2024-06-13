using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RegistaShop.Discount.Controllers
{
	[Authorize]
	[Route("api/[controller]")]
	[ApiController]
	public class ApiBaseController : ControllerBase
	{
	}
}
