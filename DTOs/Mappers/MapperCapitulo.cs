using DTOs.DataTransferObjects.DTOCapitulo;
using Obligatorio.LogicaNegocio.Entidades;

namespace DTOs.Mappers
{
    public class MapperCapitulo
    {
        public static DTOCapitulo ToDtoCapitulo(Capitulo capitulo)
        {
            DTOCapitulo dto = new DTOCapitulo();
            dto.Id = capitulo.Id;
            dto.Titulo = capitulo.Titulo;
            dto.Texto = capitulo.Texto;
            dto.HistoriaId = capitulo.Historia?.Id;
            dto.HistoriaTitulo = capitulo.Historia?.Titulo ?? string.Empty;
            dto.Tipo = capitulo.GetType().Name;
            return dto;
        }

        public static List<DTOCapitulo> ToListDtoCapitulo(List<Capitulo> lista)
        {
            List<DTOCapitulo> retorno = new List<DTOCapitulo>();

            foreach (Capitulo capitulo in lista)
            {
                retorno.Add(ToDtoCapitulo(capitulo));
            }

            return retorno;
        }
    }
}
