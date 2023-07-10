using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Kranti.EmpManager.Skills
{
    public interface ISkillAppService: ICrudAppService< //Defines CRUD methods
        SkillDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateSkillDto> //Used to create/update a book
    {

    }
}
