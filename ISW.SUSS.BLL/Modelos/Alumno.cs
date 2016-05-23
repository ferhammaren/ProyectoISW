using Proyecto_ISW.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Modelos
{
    public class Alumno 
    {
        private string nombre /*{ get; set; }*/;
        public string ap_paterno { get; set; }
        public string ap_materno { get; set; }
        private string idUsuario /*{ get; set; }*/;
        private int matricula /*{ get; set; }*/;
        private string unidadAcademica /*{ get; set; }*/;
        public string correoAlt { get; set; }
        public int horasPrimEtapa { get; set; }
        public int horasSegEtapa { get; set; }
        public DateTime fechaTallerPrimEtapa { get; set; }
        public DateTime fechaTallerSegEtapa { get; set; }
        public DateTime fechaAcPrimEtapa { get; set; }
        public DateTime fechaAcSegEtapa { get; set; }
        private ProgramaSS[] programas { get; set; }

        public Alumno(string nombre, int matricula, string unidadAc, string idUsuario)
        {
            this.nombre = nombre;
            this.matricula = matricula;
            this.unidadAcademica = unidadAc;
            this.idUsuario = idUsuario;
        }

    }
}
