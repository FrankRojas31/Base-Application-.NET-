using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Domain.Entidades.Personas
{
    public class ProfesorDTO : PersonaDTO
    {
        public string Cedula { get; set; }
        public string Especialidad { get; set; }
        public string Grado { get; set; }
        public int NoEmpleado { get; set; }
    }
}
