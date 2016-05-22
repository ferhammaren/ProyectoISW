using DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    class Usuarios
    {
        Usuarios user;


        public Boolean autenticarUsuario(String correo, String pass,int rol)
        {
            DataSet resultado;
          resultado= USUARIOS.SelectSingle(correo, pass, rol);
            if (resultado.Tables.Count > 0)
                return true;
            else
                return false;
        }
    }
}
