using System;

namespace CSharpIntermediate_Interfaces
{
    class DBMigrator
    {
        readonly ILogger _logger;
        public DBMigrator(ILogger logger)
        {
            _logger = logger;
        }
        public void Migrate()
        {
            _logger.LogInfo("Migration success at " + DateTime.Now);
        }
    }
}
