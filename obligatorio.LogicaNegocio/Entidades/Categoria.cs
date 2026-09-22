using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorio.LogicaNegocio.Entidades
{
    public class Categoria
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public List<Historia> Historias { get; set; } = new();
    }
}
