using System.Threading.Tasks;

namespace DataTree.Data;

public interface IDataTreeDbSchemaMigrator
{
    Task MigrateAsync();
}
