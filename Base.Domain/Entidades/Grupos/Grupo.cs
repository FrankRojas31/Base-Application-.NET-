using Base.Domain.Entidades.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Domain.Entidades.Grupos
{
    [Table("Tbl_Grupos")]
    public class Grupo : BaseEntity
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
    }
}
