using Base.Domain.DTO.Core;
using Base.Domain.Entidades.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Domain.Entidades.Periodos
{
    public class PeriodoDTO : BaseDTO
    {
        public string Nombre { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }

    }
}
