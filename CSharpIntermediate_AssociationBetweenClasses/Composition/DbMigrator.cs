namespace CSharpIntermediate_AssociationBetweenClasses
{
    public class DbMigrator
    {
        private readonly Logger logger;

        public DbMigrator(Logger logger)
        {
            this.logger = logger;
        }

        public void Migrate()
        {
            logger.Log("We are migrating file X to Y");
        }
    }
}
