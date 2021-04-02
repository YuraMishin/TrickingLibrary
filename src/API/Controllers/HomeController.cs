using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
  [ApiController]
  [Route("api/home")]
  public class HomeController : ControllerBase
  {
    [HttpGet]
    public string Index() => "Hello World from ASP";
  }
}
