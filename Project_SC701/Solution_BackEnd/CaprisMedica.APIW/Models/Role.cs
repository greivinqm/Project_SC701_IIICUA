﻿using System;
using System.Collections.Generic;

#nullable disable

namespace CaprisMedica.APIW.Models
{
    public partial class Role
    {
        public Role()
        {
            Usuarios = new HashSet<Usuario>();
        }

        public int RolId { get; set; }
        public string RolNombre { get; set; }
        public string RolDescripcion { get; set; }

        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
