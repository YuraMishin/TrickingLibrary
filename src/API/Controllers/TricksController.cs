using System.Linq;
using API.Models;
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

    // /api/tricks
    [HttpPost]
    public IActionResult Create([FromBody] Trick trick)
    {
      _store.Add(trick);
      return Ok();
    }
  }
}
