using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Domain.Entidades.Personas
{
    public class AlumnoDTO : PersonaDTO
    {
        public string Nombres { get; set; }
        public string Apellido_Materno { get; set; }
        public string Apellido_Paterno { get; set; }
        public int Matricula { get; set; }
        //public int? IdPersona { get; set; }
    }
}
