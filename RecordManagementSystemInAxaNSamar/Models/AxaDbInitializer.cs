using System.Data.Entity;

namespace RecordManagementSystemInAxaNSamar.Model
{
    internal class AxaDbInitializer : CreateDatabaseIfNotExists<AxaContext>
    {
    }
}