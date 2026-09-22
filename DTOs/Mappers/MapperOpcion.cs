using DTOs.DataTransferObjects.DTOOpcion;
using Obligatorio.LogicaNegocio.Entidades;

namespace DTOs.Mappers
{
    public class MapperOpcion
    {
        public static DTOOpcion ToDtoOpcion(Opcion opcion)
        {
            DTOOpcion dto = new DTOOpcion();
            dto.Id = opcion.Id;
            dto.Texto = opcion.Texto;
            dto.CapituloOrigenId = opcion.CapituloOrigen?.Id;
            dto.CapituloOrigenTitulo = opcion.CapituloOrigen?.Titulo ?? string.Empty;
            dto.CapituloDestinoId = opcion.CapituloDestino?.Id;
            dto.CapituloDestinoTitulo = opcion.CapituloDestino?.Titulo ?? string.Empty;
            dto.TipoCapituloDestino = opcion.CapituloDestino?.GetType().Name ?? string.Empty;
            return dto;
        }

        public static List<DTOOpcion> ToListDtoOpcion(List<Opcion> lista)
        {
            List<DTOOpcion> retorno = new List<DTOOpcion>();

            foreach (Opcion opcion in lista)
            {
                retorno.Add(ToDtoOpcion(opcion));
            }

            return retorno;
        }
    }
}
