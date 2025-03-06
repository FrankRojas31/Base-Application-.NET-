using Base.Domain.DTO.Core;
using Base.Domain.Entidades.Core;
using Base.Domain.Entidades.Personas;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Domain.Entidades.Grupos
{
    public class GruposAlumnosDTO : BaseDTO
    {
        public int IdGrupo { get; set; }
        public int IdAlumno { get; set; }
    }
}
