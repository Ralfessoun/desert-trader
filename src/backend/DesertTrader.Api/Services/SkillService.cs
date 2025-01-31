using DesertTrader.Api.Models;

namespace DesertTrader.Api.Services;

public class SkillService
{
    // Mock data for testing
    private readonly List<Skill> _skills = new()
    {
        new Skill { Id = 1, Name = "Combat", Level = 1 },
        new Skill { Id = 2, Name = "Fishing", Level = 1 }
    };

    public List<Skill> GetSkills() => _skills;
}