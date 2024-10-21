using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Edifia_ADO;

namespace Edifia_BL
{
    public class EdificioBL
    {
        EdificioADO objEdificioADO = new EdificioADO();

<<<<<<< HEAD
        public DataTable ListarEdificios()
        {
            return objEdificioADO.ListarEdificios();
=======
        public DataTable ListarEdificio()
        {
            return objEdificioADO.ListarEdificio();
>>>>>>> ad178f82718c561339c10efb5feae9ded6c688e0
        }
    }
}
