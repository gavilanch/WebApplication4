using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models
{
    public class Usuario
    {
        public int UsuarioID { get; set; }
        public string NombreUsuario { get; set; }
        public string UserPass { get; set; }
        public string Email { get; set; }
        public bool Activo { get; set; }
        public int RolID { get; set; }
        public virtual Rol Rol { get; set; }
    }
}
