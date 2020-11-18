﻿using System;
using System.Collections.Generic;

#nullable disable

namespace CaprisMedica.APIW.Models
{
    public partial class TipoTrabajo
    {
        public TipoTrabajo()
        {
            Solicitudes = new HashSet<Solicitude>();
        }

        public int TipoTrabajoId { get; set; }
        public string TipoTrabajoNombre { get; set; }

        public virtual ICollection<Solicitude> Solicitudes { get; set; }
    }
}
