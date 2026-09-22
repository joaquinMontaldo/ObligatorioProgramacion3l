using Obligatorio.LogicaNegocio.ValueObjects.VOUsuario;
using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorio.LogicaNegocio.Entidades
{
    public class Usuario
    {
        public int Id { get; set; }

        public string NombreUsuario { get; set; }

        public string NombreCompleto { get; set; }

        public string Email { get; set; }

        public UsuarioContrasenia Contrasenia { get; set; }

        public TipoRol Rol { get; set; }

        public Estilo Estilo { get; set; }

        public List<Lectura> Lecturas { get; set; } = new();

        public List<Auditoria> Auditorias { get; set; } = new();
    }
}
