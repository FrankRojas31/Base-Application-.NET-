using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Base.Domain.DTO.Security
{
    public class RoleDTO
    {
        public string? Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
