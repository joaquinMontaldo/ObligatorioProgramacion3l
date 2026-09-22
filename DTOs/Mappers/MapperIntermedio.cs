using DTOs.DataTransferObjects.DTOIntermedio;
using Obligatorio.LogicaNegocio.Entidades;

namespace DTOs.Mappers
{
    public class MapperIntermedio
    {
        public static DTOIntermedio ToDtoIntermedio(Intermedio intermedio)
        {
            DTOIntermedio dto = new DTOIntermedio();
            dto.Id = intermedio.Id;
            dto.Titulo = intermedio.Titulo;
            dto.Texto = intermedio.Texto;
            dto.HistoriaId = intermedio.Historia?.Id;
            dto.HistoriaTitulo = intermedio.Historia?.Titulo ?? string.Empty;
            dto.Opciones = MapperOpcion.ToListDtoOpcion(intermedio.Opciones);
            return dto;
        }

        public static List<DTOIntermedio> ToListDtoIntermedio(List<Intermedio> lista)
        {
            List<DTOIntermedio> retorno = new List<DTOIntermedio>();

            foreach (Intermedio intermedio in lista)
            {
                retorno.Add(ToDtoIntermedio(intermedio));
            }

            return retorno;
        }
    }
}
