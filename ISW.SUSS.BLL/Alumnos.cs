using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Proyecto_ISW.Clases;
using Clases.Modelos;
using DataAccess;

namespace ISW.SUSS.Clases
{
   public class Alumnos
    {
       private Alumno al=new Alumno();
       private static DataSet ds;

        public static void getInfoAlumno(int numero)
        {
            ds = INFOALUMNO.SelectSingle(numero);
        }

        private void setAlumnoInfo()
        {
            Alumno.ap_paterno=(ds.Tables[0].Rows[0]["ap_paterno"]);
        }

    }
}
