﻿using Base.Domain.DTO.Core;
using Base.Domain.Entidades.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Domain.Entidades.Grupos
{
    public class GruposDTO : BaseDTO
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
    }
}
