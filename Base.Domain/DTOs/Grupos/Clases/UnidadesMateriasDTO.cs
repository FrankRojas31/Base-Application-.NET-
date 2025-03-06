using Base.Domain.DTO.Core;
using Base.Domain.Entidades.Grupos.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Domain.DTOs.Grupos.Clases
{
    public class UnidadesMateriasDTO : BaseDTO
    {
        public int IdUnidad { get; set; }
        public int IdMateria { get; set; }
    }
}
