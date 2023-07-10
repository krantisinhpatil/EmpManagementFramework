using System;
using System.Threading.Tasks;
using Kranti.EmpManager.Skills;
using AutoMapper.Internal.Mappers;
using Microsoft.AspNetCore.Mvc;

namespace Kranti.EmpManager.Web.Pages.Skill;

public class EditModalModel : EmpManagerPageModel
{
    [HiddenInput]
    [BindProperty(SupportsGet = true)]
    public Guid Id { get; set; }

    [BindProperty]
    public CreateUpdateSkillDto Skill { get; set; }

    private readonly ISkillAppService _skillAppService;

    public EditModalModel(ISkillAppService skillAppService)
    {
        _skillAppService = skillAppService;
    }

    public async Task OnGetAsync()
    {
        var skillDto = await _skillAppService.GetAsync(Id);
        Skill = ObjectMapper.Map<SkillDto, CreateUpdateSkillDto>(skillDto);
    }

    public async Task<IActionResult> OnPostAsync()
    {
        await _skillAppService.UpdateAsync(Id, Skill);
        return NoContent();
    }
}