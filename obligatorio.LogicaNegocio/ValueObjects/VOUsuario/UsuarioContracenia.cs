using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace Obligatorio.LogicaNegocio.ValueObjects.VOUsuario
{
    [ComplexType]
    public record UsuarioContrasenia
    {
        public string Valor { get; init; }

        public UsuarioContrasenia()
        {
        }

        public UsuarioContrasenia(string valor)
        {
            if (string.IsNullOrEmpty(valor))
            {
                throw new DatoVacioException(
                    "La contraseña es obligatoria"
                );
            }

            Valor = valor;
        }
    }
}
