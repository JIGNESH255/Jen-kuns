using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JenkinsAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ValuesController : ControllerBase
	{
		[HttpGet("getstring")]
		public string Getstring()
		{
			return "abc";
		}

		[HttpGet("jjj")]
		public string Getstring(string name)
		{
			return "abc";
		}
	}
}
