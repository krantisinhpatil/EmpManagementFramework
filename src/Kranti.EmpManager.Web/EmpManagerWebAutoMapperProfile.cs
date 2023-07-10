using AutoMapper;
using Kranti.EmpManager.Skills;

namespace Kranti.EmpManager.Web;

public class EmpManagerWebAutoMapperProfile : Profile
{
    public EmpManagerWebAutoMapperProfile()
    {
        CreateMap<SkillDto, CreateUpdateSkillDto>();
    }
}
