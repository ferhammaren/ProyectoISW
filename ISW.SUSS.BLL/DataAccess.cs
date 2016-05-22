using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_ISW.Clases
{
    class DataAccess
    {
        private DataSet data;
        private ProgramaSS programa;
        private Usuario usuario;

        public/* Usuario*/void getUsuario(string nom, string pass)
        {
            //data = new DataSet();
            //Usuario usuario = new Usuario();
            //return usuario;
        }

        public ProgramaSS getProgramaAsignado(Alumno alumno)
        {
            data = new DataSet();
            programa = new ProgramaSS();
            return programa;
        }

        public ProgramaSS getProgramaSS(int id, int carrera, string nombre)
        {
            data = new DataSet();
            programa = new ProgramaSS();
        }
    }
}
