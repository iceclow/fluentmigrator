using FluentMigrator.Runner.Shared;
using FluentMigrator.Runner.Shared.Generators;
namespace FluentMigrator.Runner.Shared
{
    public static class CompatabilityModeExtension
    {
        public static string HandleCompatabilty(this CompatabilityMode mode, string message)
        {
            if (CompatabilityMode.STRICT == mode)
            {
                throw new DatabaseOperationNotSupportedExecption(message);
            }
            return string.Empty;
        }
    }
}
