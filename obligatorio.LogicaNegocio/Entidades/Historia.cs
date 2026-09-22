using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorio.LogicaNegocio.Entidades
{
    public class Historia
    {
        public int Id { get; set; }

        public string Titulo { get; set; }

        public string Sinopsis { get; set; }

        public TipoEstado Estado { get; set; }

        public List<Categoria> Categorias { get; set; }

        public Capitulo CapituloInicial { get; set; }

        public List<Capitulo> Capitulos { get; set; }

        public List<Lectura> Lecturas { get; set; }

        public List<Auditoria> Auditorias { get; set; }
    }
}
