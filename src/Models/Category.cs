using System.Collections.Generic;

namespace Models
{
  public class Category : BaseModel<string>
  {
    public string Description { get; set; }
    public IList<TrickCategory> Tricks { get; set; } = new List<TrickCategory>();
  }
}
