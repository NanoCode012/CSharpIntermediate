namespace CSharpIntermediate_AssociationBetweenClasses
{
    class Installer
    {
        private readonly Logger logger;

        public Installer(Logger logger)
        {
            this.logger = logger;
        }

        public void Install()
        {
            logger.Log("App is installing");
        }
    }
}
