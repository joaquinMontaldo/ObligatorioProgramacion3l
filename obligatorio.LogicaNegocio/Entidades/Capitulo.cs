using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorio.LogicaNegocio.Entidades
{
    public class Capitulo
    {
        public int Id { get; set; }

        public string Titulo { get; set; }

        public string Texto { get; set; }

        public Historia Historia { get; set; }
    }
}
