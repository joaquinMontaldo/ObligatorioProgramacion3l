namespace Obligatorio.LogicaNegocio.CustomExceptions.Genericas
{
    public class ContraseniaInvalidaException : Exception
    {
        public ContraseniaInvalidaException(string mensaje) : base(mensaje)
        {
        }
    }
}
