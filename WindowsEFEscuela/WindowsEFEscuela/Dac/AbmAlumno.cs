using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsEFEscuela.Models;

namespace WindowsEFEscuela.Dac
{
    public class AbmAlumno

    {
        private static DBEscuelaEFContext context = new DBEscuelaEFContext();


        public static List<Alumno> SelectAll()
        {
            return context.Alumnos.ToList();
        }

        public static Alumno SelectWhereById(int IdAlumno)
        {
            return context.Alumnos.Find(IdAlumno);

        }

        public static int Insert(Alumno alumno)
        {
            context.Alumnos.Add(alumno);
            return context.SaveChanges();
        }

        public static int Update(Alumno alumno)
        {
            Alumno alumnoOrigen = context.Alumnos.Find(alumno.AlumnoId);
            alumnoOrigen.Nombre = alumno.Nombre;
            return context.SaveChanges();
        }

        public static int Delete(Alumno alumno)
        {


            Alumno alumnoOrigen = context.Alumnos.Find(alumno.AlumnoId);
            if (alumnoOrigen != null)
            {
                context.Alumnos.Remove(alumnoOrigen);
                return context.SaveChanges();
            }

            return 0;
        }
    }
}