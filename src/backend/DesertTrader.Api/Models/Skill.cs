namespace DesertTrader.Api.Models;

public class Skill
{
    public int Id { get; set; }
    public string Name { get; set; } // "Combat", "Fishing", etc.
    public int Level { get; set; } = 1;
    public int Experience { get; set; } = 0;
}