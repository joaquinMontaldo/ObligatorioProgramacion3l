using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorio.LogicaNegocio.Entidades
{
    public class Opcion
    {
        public int Id { get; set; }

        public string Texto { get; set; }

        public Intermedio CapituloOrigen { get; set; }

        public Capitulo CapituloDestino { get; set; }
    }
}
