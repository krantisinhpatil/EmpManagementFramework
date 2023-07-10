using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Kranti.EmpManager.Skills
{
    public class Skill:AuditedAggregateRoot<Guid>
    {
        public string Name{ get; set; }
        public string Description { get; set; }
    }
}
