using System.Threading.Tasks;

namespace Kranti.EmpManager.Data;

public interface IEmpManagerDbSchemaMigrator
{
    Task MigrateAsync();
}
