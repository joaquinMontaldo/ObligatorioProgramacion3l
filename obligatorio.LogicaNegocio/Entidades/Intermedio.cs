using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorio.LogicaNegocio.Entidades
{
    public class Intermedio : Capitulo
    {
        public List<Opcion> Opciones { get; set; } = new();
    }
}
