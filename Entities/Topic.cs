namespace MyQuizzApplication.Entities;

public class Topic : EntityBase
{
    public string? Name { get; set; }
    public string? NameHash { get; set; }
    public string? Description { get; set; }

    public ETopicDifficulty Difficulty { get; set; }
}