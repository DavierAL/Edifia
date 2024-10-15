using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edifia_BE
{
    public class UsuarioBE
    {
        public short Id { get; set; }
        public string LoginUsuario { get; set; }
        public String PassUsuario { get; set; }
        public short NivelUsuario { get; set; }
        public Int16 PersonaId { get; set; }
        public Int16 EstadoUsuario { get; set; }
        public DateTime FecRegistro { get; set; }
    }
}
