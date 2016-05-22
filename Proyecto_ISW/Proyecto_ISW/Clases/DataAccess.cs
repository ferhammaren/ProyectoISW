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

        public Usuario getUsuario(string nom, string pass)
        {
            data = new DataSet();
            Usuario usuario = new Usuario();
            return usuario;
        }

        public ProgramaSS getProgramaAsignado(Alumno alumno)
        {
            data = new DataSet();
            ProgramaSS programa = new ProgramaSS();
            return programa;
        }
    }
}
