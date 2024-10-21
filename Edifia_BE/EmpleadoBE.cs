using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edifia_BE
{
    public class EmpleadoBE
    {
        public String nombre { get; set; }

        public String apellido { get; set; }

        public String documento { get; set; }

        public String horario { get; set; }

        public DateOnly fecha_inicio { get; set; }

        public DateOnly fecha_fin { get; set; }

        public Int16 tipo_id { get; set; }

        public DateOnly fec_reg { get; set; }

        public String usu_reg { get; set; }


    }
}
