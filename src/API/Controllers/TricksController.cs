using System.Linq;
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

    // /api/tricks/{id}
    [HttpGet("{id}")]
    public IActionResult Get(int id) => Ok(_store.All.FirstOrDefault(x => x.Id.Equals(id)));
  }
}
