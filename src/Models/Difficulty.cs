using System.Collections.Generic;

namespace Models
{
  public class Difficulty : BaseModel<string>
  {
    public string Description { get; set; }
    public IList<Trick> Tricks { get; set; } = new List<Trick>();
  }
}
