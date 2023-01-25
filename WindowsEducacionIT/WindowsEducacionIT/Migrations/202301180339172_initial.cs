namespace WindowsEducionIT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Carrera",
                c => new
                    {
                        IdCarrera = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.IdCarrera);
            
            CreateTable(
                "dbo.Plan",
                c => new
                    {
                        IdPlan = c.Int(nullable: false, identity: true),
                        IdCarrera = c.Int(nullable: false),
                        Nombre = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.IdPlan)
                .ForeignKey("dbo.Carrera", t => t.IdCarrera, cascadeDelete: true)
                .Index(t => t.IdCarrera);
            
            CreateTable(
                "dbo.Planilla",
                c => new
                    {
                        IdPlanilla = c.Int(nullable: false, identity: true),
                        IdCarrera = c.Int(nullable: false),
                        IdMateria = c.Int(nullable: false),
                        IdProfesor = c.Int(nullable: false),
                        IdCurso = c.Int(nullable: false),
                        Fecha = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.IdPlanilla)
                .ForeignKey("dbo.Carrera", t => t.IdCarrera, cascadeDelete: true)
                .ForeignKey("dbo.Curso", t => t.IdCurso, cascadeDelete: true)
                .ForeignKey("dbo.Profesor", t => t.IdProfesor, cascadeDelete: true)
                .ForeignKey("dbo.Materia", t => t.IdMateria, cascadeDelete: true)
                .Index(t => t.IdCarrera)
                .Index(t => t.IdMateria)
                .Index(t => t.IdProfesor)
                .Index(t => t.IdCurso);
            
            CreateTable(
                "dbo.Curso",
                c => new
                    {
                        IdCurso = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.IdCurso);
            
            CreateTable(
                "dbo.Detalle",
                c => new
                    {
                        IdDetalle = c.Int(nullable: false, identity: true),
                        IdEstado = c.Int(nullable: false),
                        IdPlanilla = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdDetalle)
                .ForeignKey("dbo.Estado", t => t.IdEstado, cascadeDelete: true)
                .ForeignKey("dbo.Planilla", t => t.IdPlanilla, cascadeDelete: true)
                .Index(t => t.IdEstado)
                .Index(t => t.IdPlanilla);
            
            CreateTable(
                "dbo.Estado",
                c => new
                    {
                        IdEstado = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.IdEstado);
            
            CreateTable(
                "dbo.Evaluacion",
                c => new
                    {
                        IdEvaluacion = c.Int(nullable: false, identity: true),
                        IdTipo = c.Int(nullable: false),
                        IdEstudiante = c.Int(nullable: false),
                        IdDetalle = c.Int(nullable: false),
                        Nota = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdEvaluacion)
                .ForeignKey("dbo.Detalle", t => t.IdDetalle, cascadeDelete: true)
                .ForeignKey("dbo.Estudiante", t => t.IdEstudiante, cascadeDelete: true)
                .ForeignKey("dbo.Tipo", t => t.IdTipo, cascadeDelete: true)
                .Index(t => t.IdTipo)
                .Index(t => t.IdEstudiante)
                .Index(t => t.IdDetalle);
            
            CreateTable(
                "dbo.Estudiante",
                c => new
                    {
                        IdEstudiante = c.Int(nullable: false, identity: true),
                        IdLocalidad = c.Int(nullable: false),
                        Nombre = c.String(nullable: false, maxLength: 50, unicode: false),
                        Apellido = c.String(nullable: false, maxLength: 50, unicode: false),
                        Telefono = c.String(nullable: false, maxLength: 50, unicode: false),
                        Calle = c.String(),
                        Numero = c.String(),
                    })
                .PrimaryKey(t => t.IdEstudiante)
                .ForeignKey("dbo.Localidad", t => t.IdLocalidad, cascadeDelete: true)
                .Index(t => t.IdLocalidad);
            
            CreateTable(
                "dbo.Localidad",
                c => new
                    {
                        IdLocalidad = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.IdLocalidad);
            
            CreateTable(
                "dbo.Profesor",
                c => new
                    {
                        IdProfesor = c.Int(nullable: false, identity: true),
                        IdLocalidad = c.Int(nullable: false),
                        Nombre = c.String(nullable: false, maxLength: 50, unicode: false),
                        Apellido = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.IdProfesor)
                .ForeignKey("dbo.Localidad", t => t.IdLocalidad, cascadeDelete: false)
                .Index(t => t.IdLocalidad);
            
            CreateTable(
                "dbo.Tipo",
                c => new
                    {
                        IdTipo = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.IdTipo);
            
            CreateTable(
                "dbo.Materia",
                c => new
                    {
                        IdMateria = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.IdMateria);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Planilla", "IdMateria", "dbo.Materia");
            DropForeignKey("dbo.Detalle", "IdPlanilla", "dbo.Planilla");
            DropForeignKey("dbo.Evaluacion", "IdTipo", "dbo.Tipo");
            DropForeignKey("dbo.Evaluacion", "IdEstudiante", "dbo.Estudiante");
            DropForeignKey("dbo.Planilla", "IdProfesor", "dbo.Profesor");
            DropForeignKey("dbo.Profesor", "IdLocalidad", "dbo.Localidad");
            DropForeignKey("dbo.Estudiante", "IdLocalidad", "dbo.Localidad");
            DropForeignKey("dbo.Evaluacion", "IdDetalle", "dbo.Detalle");
            DropForeignKey("dbo.Detalle", "IdEstado", "dbo.Estado");
            DropForeignKey("dbo.Planilla", "IdCurso", "dbo.Curso");
            DropForeignKey("dbo.Planilla", "IdCarrera", "dbo.Carrera");
            DropForeignKey("dbo.Plan", "IdCarrera", "dbo.Carrera");
            DropIndex("dbo.Profesor", new[] { "IdLocalidad" });
            DropIndex("dbo.Estudiante", new[] { "IdLocalidad" });
            DropIndex("dbo.Evaluacion", new[] { "IdDetalle" });
            DropIndex("dbo.Evaluacion", new[] { "IdEstudiante" });
            DropIndex("dbo.Evaluacion", new[] { "IdTipo" });
            DropIndex("dbo.Detalle", new[] { "IdPlanilla" });
            DropIndex("dbo.Detalle", new[] { "IdEstado" });
            DropIndex("dbo.Planilla", new[] { "IdCurso" });
            DropIndex("dbo.Planilla", new[] { "IdProfesor" });
            DropIndex("dbo.Planilla", new[] { "IdMateria" });
            DropIndex("dbo.Planilla", new[] { "IdCarrera" });
            DropIndex("dbo.Plan", new[] { "IdCarrera" });
            DropTable("dbo.Materia");
            DropTable("dbo.Tipo");
            DropTable("dbo.Profesor");
            DropTable("dbo.Localidad");
            DropTable("dbo.Estudiante");
            DropTable("dbo.Evaluacion");
            DropTable("dbo.Estado");
            DropTable("dbo.Detalle");
            DropTable("dbo.Curso");
            DropTable("dbo.Planilla");
            DropTable("dbo.Plan");
            DropTable("dbo.Carrera");
        }
    }
}
