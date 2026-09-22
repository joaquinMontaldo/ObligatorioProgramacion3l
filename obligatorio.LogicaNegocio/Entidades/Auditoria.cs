using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorio.LogicaNegocio.Entidades
{
    public class Auditoria
    {
        public int Id { get; set; }

        public Usuario UsuarioAdministrador { get; set; }

        public string Accion { get; set; }

        public DateTime Fecha { get; set; }

        public Historia Historia { get; set; }
    }
}
