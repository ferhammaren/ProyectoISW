﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_ISW.Clases
{
    class ProgramaSS
    {
        private int idPrograma { get; set; }
        private int idCarrera { get; set; }
        private string nombrePrograma { get; set; }
        private int etapa { get; set; }
        private int unidadReceptora { get; set; }
        private int cupo { get; set; }
        private int asignados { get; set; }
        private int sector { get; set; }
        private int localidad { get; set; }

        public ProgramaSS(int idProg, int idCarr, string nombre, int etapa, int uniRec, int cupo, int asig, int sector, int loc)
        {
            this.idPrograma = idProg;
            this.idCarrera = idCarr;
            this.nombrePrograma = nombre;
            this.etapa = etapa;
            //this.
        } 
    }
}
