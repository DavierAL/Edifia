using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Edifia_ADO;

namespace Edifia_BL
{
    public class EmpleadoBL
    {
        EmpleadoADO objEmpleadoADO = new EmpleadoADO();

        public DataTable ListarEmpleado()
        {
            return objEmpleadoADO.ListarEmpleado();
        }
    }
}
