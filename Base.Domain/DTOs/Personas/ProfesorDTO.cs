using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Domain.Entidades.Personas
{
    public class ProfesorDTO : PersonaDTO
    {
        public string Nombres { get; set; }
        public string Apellido_Materno { get; set; }
        public string Apellido_Paterno { get; set; }
        public string Cedula { get; set; }
        public string Especialidad { get; set; }
        public string Grado { get; set; }
        public int NoEmpleado { get; set; }
        //public int? IdPersona { get; set; }
    }
}
