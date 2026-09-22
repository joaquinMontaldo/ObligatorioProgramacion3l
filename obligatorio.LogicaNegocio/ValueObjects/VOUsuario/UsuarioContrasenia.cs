using Obligatorio.LogicaNegocio.CustomExceptions.Genericas;
using System.ComponentModel.DataAnnotations.Schema;

namespace Obligatorio.LogicaNegocio.ValueObjects.VOUsuario
{
    [ComplexType]
    public record UsuarioContrasenia
    {
        public string Valor { get; private init; } = string.Empty;

        private UsuarioContrasenia()
        {
        }

        public UsuarioContrasenia(string valor)
        {
            if (string.IsNullOrWhiteSpace(valor))
            {
                throw new DatoVacioException("La contraseña es obligatoria");
            }

            if (valor.Length < 8)
                throw new ContraseniaInvalidaException("La contraseña debe tener al menos 8 caracteres.");

            if (!valor.Any(char.IsUpper))
                throw new ContraseniaInvalidaException("La contraseña debe contener una mayúscula.");

            if (!valor.Any(char.IsLower))
                throw new ContraseniaInvalidaException("La contraseña debe contener una minúscula.");

            if (!valor.Any(char.IsDigit))
                throw new ContraseniaInvalidaException("La contraseña debe contener un número.");

            if (!valor.Any(caracter => !char.IsLetterOrDigit(caracter)))
                throw new ContraseniaInvalidaException("La contraseña debe contener un carácter especial.");

            Valor = valor;
        }
    }
}
