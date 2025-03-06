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
        public int Matricula { get; set; }
    }
}
