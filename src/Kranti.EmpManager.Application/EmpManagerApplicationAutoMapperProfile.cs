using AutoMapper;
using Kranti.EmpManager.Skills;

namespace Kranti.EmpManager;

public class EmpManagerApplicationAutoMapperProfile : Profile
{
    public EmpManagerApplicationAutoMapperProfile()
    {
        CreateMap<Skill, SkillDto>();
        CreateMap<CreateUpdateSkillDto, Skill>();
    }
}
