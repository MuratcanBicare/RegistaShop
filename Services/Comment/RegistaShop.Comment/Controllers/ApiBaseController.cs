using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RegistaShop.Comment.Controllers
{
	[Authorize]
	[Route("api/[controller]")]
	[ApiController]
	public class ApiBaseController : ControllerBase
	{
	}
}
