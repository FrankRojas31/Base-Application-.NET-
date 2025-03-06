using Base.Domain.Entidades.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Domain.Entidades.Grupos.Clases
{
    [Table("Tbl_Unidades")]
    public class Unidades : BaseEntity
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
    }
}
