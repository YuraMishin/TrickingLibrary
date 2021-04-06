using System.Collections.Generic;

namespace Models
{
  public class Trick : BaseModel<string>
  {
    public string Name { get; set; }
    public string Description { get; set; }
    public string DifficultyId { get; set; }
    public Difficulty Difficulty { get; set; }

    public IList<TrickRelationship> Prerequisites { get; set; } = new List<TrickRelationship>();
    public IList<TrickRelationship> Progressions { get; set; } = new List<TrickRelationship>();

    public IList<TrickCategory> TrickCategories { get; set; } = new List<TrickCategory>();
  }
}
