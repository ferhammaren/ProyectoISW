using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_ISW
{
    class Alumno : Usuario
    {
        private string nombre { get; set; }
        private string ap_paterno { get; set; }
        private string ap_materno { get; set; }
        private string idUsuario { get; set; }
        private int matricula { get; set; }
        private string unidadAcademica { get; set; }
        private string correoAlt { get; set; }
        private int horasPrimEtapa { get; set; }
        private int horasSegEtapa { get; set; }
        private DateTime fechaTallerPrimEtapa { get; set; }
        private DateTime fechaTallerSegEtapa { get; set; }
        private DateTime fechaAcPrimEtapa { get; set; }
        private DateTime fechaAcSegEtapa { get; set; }

    }
}
