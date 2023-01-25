namespace WindowsEFEscuela.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cambioDeVariables : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Alumnoes", newName: "Alumnos");
            RenameTable(name: "dbo.Profesors", newName: "Profesores");
            AlterColumn("dbo.Alumnos", "Nombre", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Alumnos", "Apellido", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Alumnos", "FechaNacimiento", c => c.DateTime());
            AlterColumn("dbo.Profesores", "Apellido", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Profesores", "Nombre", c => c.String(nullable: false, maxLength: 50, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Profesores", "Nombre", c => c.String());
            AlterColumn("dbo.Profesores", "Apellido", c => c.String());
            AlterColumn("dbo.Alumnos", "FechaNacimiento", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Alumnos", "Apellido", c => c.String());
            AlterColumn("dbo.Alumnos", "Nombre", c => c.String());
            RenameTable(name: "dbo.Profesores", newName: "Profesors");
            RenameTable(name: "dbo.Alumnos", newName: "Alumnoes");
        }
    }
}
