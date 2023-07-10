using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Kranti.EmpManager.Skills
{
    public class SkillAppService : CrudAppService<
        Skill, //The Book entity
        SkillDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateSkillDto>, //Used to create/update a book
    ISkillAppService //implement the IBookAppService
    {
        public SkillAppService(IRepository<Skill, Guid> repository)
        : base(repository)
        {

        }
    }
}
