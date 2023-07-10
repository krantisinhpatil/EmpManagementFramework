using System.Threading.Tasks;
using Kranti.EmpManager.Skills;
using Microsoft.AspNetCore.Mvc;

namespace Kranti.EmpManager.Web.Pages.Skills
{
    public class CreateModalModel : EmpManagerPageModel
    {
        [BindProperty]
        public CreateUpdateSkillDto Skill { get; set; }

        private readonly ISkillAppService _skillAppService;

        public CreateModalModel(ISkillAppService skillAppService)
        {
            _skillAppService = skillAppService;
        }

        public void OnGet()
        {
            Skill = new CreateUpdateSkillDto();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _skillAppService.CreateAsync(Skill);
            return NoContent();
        }
    }
}
