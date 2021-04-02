using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
  [ApiController]
  [Route("api/tricks")]
  public class TricksController : ControllerBase
  {
    private readonly TrickyStore _store;

    public TricksController(TrickyStore store)
    {
      _store = store;
    }

    // /api/tricks
    [HttpGet]
    public IActionResult All() => Ok(_store.All);
  }
}
