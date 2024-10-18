using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Edifia_ADO;
using Edifia_BE;

namespace Edifia_BL
{
    public class MantenimientoBL
    {
        MantenimientoADO objMantenimientoADO = new MantenimientoADO();


        public DataTable ListarMantenimeinto()
        {
            return objMantenimientoADO.ListarMantenimiento();
        }
    }
}
