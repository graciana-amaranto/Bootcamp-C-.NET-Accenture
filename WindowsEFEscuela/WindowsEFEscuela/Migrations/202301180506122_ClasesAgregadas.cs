namespace WindowsEFEscuela.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ClasesAgregadas : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Alumnos", newName: "Alumno");
            RenameTable(name: "dbo.Profesores", newName: "Profesor");
            CreateTable(
                "dbo.Aula",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Capacidad = c.Int(nullable: false),
                        Codigo = c.String(nullable: false, maxLength: 1, fixedLength: true, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Materias",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50, unicode: false),
                        Programa = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Profesor", "Titulo", c => c.String(nullable: false, maxLength: 50, unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Profesor", "Titulo");
            DropTable("dbo.Materias");
            DropTable("dbo.Aula");
            RenameTable(name: "dbo.Profesor", newName: "Profesores");
            RenameTable(name: "dbo.Alumno", newName: "Alumnos");
        }
    }
}
