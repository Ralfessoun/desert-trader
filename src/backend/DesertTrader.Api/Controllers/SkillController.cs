using DesertTrader.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace DesertTrader.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SkillsController : ControllerBase
{
    private readonly SkillService _skillService;
    public SkillsController(SkillService skillService) => _skillService = skillService;

    [HttpGet]
    public IActionResult GetSkills() => Ok(_skillService.GetSkills());
}