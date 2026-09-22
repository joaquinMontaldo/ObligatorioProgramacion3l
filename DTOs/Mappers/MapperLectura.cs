using DTOs.DataTransferObjects.DTOLectura;
using Obligatorio.LogicaNegocio.Entidades;

namespace DTOs.Mappers
{
    public class MapperLectura
    {
        public static DTOLectura ToDtoLectura(Lectura lectura)
        {
            DTOLectura dto = new DTOLectura();
            dto.Id = lectura.Id;
            dto.FechaInicio = lectura.FechaInicio;
            dto.FechaFinalizacion = lectura.FechaFinalizacion;
            dto.UsuarioId = lectura.Usuario?.Id;
            dto.NombreUsuario = lectura.Usuario?.NombreUsuario ?? string.Empty;
            dto.HistoriaId = lectura.Historia?.Id;
            dto.HistoriaTitulo = lectura.Historia?.Titulo ?? string.Empty;
            dto.FinalId = lectura.Final?.Id;
            dto.FinalTitulo = lectura.Final?.Titulo ?? string.Empty;
            dto.EstaFinalizada = lectura.FechaFinalizacion.HasValue && lectura.Final != null;
            return dto;
        }

        public static List<DTOLectura> ToListDtoLectura(List<Lectura> lista)
        {
            List<DTOLectura> retorno = new List<DTOLectura>();

            foreach (Lectura lectura in lista)
            {
                retorno.Add(ToDtoLectura(lectura));
            }

            return retorno;
        }
    }
}
