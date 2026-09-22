using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorio.LogicaNegocio.Entidades
{
    public class Lectura
    {
        public int Id { get; set; }

        public DateTime FechaInicio { get; set; }

        public DateTime? FechaFinalizacion { get; set; }

        public Usuario Usuario { get; set; }

        public Historia Historia { get; set; }

        public Final? Final { get; set; }
    }
}
