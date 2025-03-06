using Base.Domain.DTO.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Domain.DTOs.Grupos.Clases
{
    public class MateriasDTO : BaseDTO
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
    }
}
