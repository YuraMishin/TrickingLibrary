using System.Collections.Generic;
using API.Models;

namespace API
{
  public class TrickyStore
  {
    private readonly List<Trick> _tricks;

    public TrickyStore()
    {
      _tricks = new List<Trick>
      {
        new Trick { Id = 1, Name = "trick1" },
        new Trick { Id = 2, Name = "trick2" }
      };
    }

    public IEnumerable<Trick> All => _tricks;
  }
}
