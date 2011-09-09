using FluentMigrator.Runner.Shared;
namespace FluentMigrator.Runner.Shared.Processors
{
    public interface IMigrationProcessorFactory
    {
        IMigrationProcessor Create(string connectionString, IAnnouncer announcer, IMigrationProcessorOptions options);

        bool IsForProvider(string provider);

        string Name { get; }
    }
}