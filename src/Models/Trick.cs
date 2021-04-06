namespace Models
{
  public class Trick : BaseModel<string>
  {
    public string Name { get; set; }
    public string Description { get; set; }
    public string DifficultyId { get; set; }
    public Difficulty Difficulty { get; set; }
  }
}
