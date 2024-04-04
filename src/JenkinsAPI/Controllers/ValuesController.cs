using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JenkinsAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ValuesController : ControllerBase
	{
		[HttpGet(Name = "getstring")]
		public string Getstring()
		{
			return "abc";
		}

		[HttpGet(Name ="jjj")]
		public string Getstring(string name)
		{
			return "abc";
		}
	}
}
