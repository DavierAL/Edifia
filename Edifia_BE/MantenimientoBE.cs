﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edifia_BE
{
    public class MantenimientoBE
    {
        public Int16 actividad_id {  get; set; }

        public DateTime fecha_programada { get; set; }

        public DateTime fecha_realizacion { get; set; }

        public String responsable {  get; set; }

        public Int16 edificio_id { get; set; }

        public String Usu_Registro { get; set; }
    }
}
