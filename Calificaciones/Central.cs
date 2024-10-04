using Calificaciones.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calificaciones
{
    class Central
    {
        static string constrg = "Data Source=DESKTOP-9LEERSH\\PROGRAMMING;" +
            "Initial Catalog=Calificaciones;User ID=sa;Password=123456;TrustServerCertificate=True";
        //"Data Source=DESKTOP-9LEERSH\\PROGRAMMING;Initial Catalog=unidep;User ID=sa;Password=123456;TrustServerCertificate=True");

        public static void RegistrarAlumno(Alumno alumno)
        {
            //codigo para registrar alumno
            SqlConnection conn = new SqlConnection(constrg);
            SqlCommand comm = new SqlCommand("insert into Alumnos (nombre,apellidos,matricula)values(@Nombre,@Apellidos,@Matricula) ", conn);
            comm.Parameters.AddWithValue("@Nombre", alumno.Nombre);
            comm.Parameters.AddWithValue("@Apellidos", alumno.Apellidos);
            comm.Parameters.AddWithValue("@Matricula", alumno.Matricula);
            try
            {
                conn.Open();
                comm.ExecuteNonQuery();
            }
            catch(Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
        }
        public static DataTable CaragarAlumnos()
        {
            DataTable dtalumnos = new DataTable();
            //codigo para obtener lista de alumnos
            return dtalumnos;
        }

        //se define el parametro com objeto para evitar el agregar mas campos si se requieren despues
        public static void RegistarMateria(Materia materia)
        {
            //codigp para registrar materia
        }
        public static DataTable CaragarMaterias()
        {
            DataTable dtmaterias = new DataTable();
            //codigo para obtener lista de materias
            return dtmaterias;
        }

    }
}
