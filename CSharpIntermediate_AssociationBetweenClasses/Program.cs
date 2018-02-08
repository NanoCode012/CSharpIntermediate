namespace CSharpIntermediate_AssociationBetweenClasses
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Inheritance - "is-a" relationship
            var text = new TextBox();
            text.Copy();
            text.Delete();
            text.Width = 100;

            //Composition - "has-a" relationship
            var logger = new Logger();
            var dbMigrator = new DbMigrator(logger);
            var installer = new Installer(logger);
            dbMigrator.Migrate();
            installer.Install();
        }
    }
}
