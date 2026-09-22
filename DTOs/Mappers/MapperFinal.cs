using DTOs.DataTransferObjects.DTOFinal;
using Obligatorio.LogicaNegocio.Entidades;

namespace DTOs.Mappers
{
    public class MapperFinal
    {
        public static DTOFinal ToDtoFinal(Final capituloFinal)
        {
            DTOFinal dto = new DTOFinal();
            dto.Id = capituloFinal.Id;
            dto.Titulo = capituloFinal.Titulo;
            dto.Texto = capituloFinal.Texto;
            dto.HistoriaId = capituloFinal.Historia?.Id;
            dto.HistoriaTitulo = capituloFinal.Historia?.Titulo ?? string.Empty;
            dto.CantVecesLectoresLlegaronAFinal = capituloFinal.CantVecesLectoresLlegaronAFinal;
            return dto;
        }

        public static List<DTOFinal> ToListDtoFinal(List<Final> lista)
        {
            List<DTOFinal> retorno = new List<DTOFinal>();

            foreach (Final capituloFinal in lista)
            {
                retorno.Add(ToDtoFinal(capituloFinal));
            }

            return retorno;
        }
    }
}
