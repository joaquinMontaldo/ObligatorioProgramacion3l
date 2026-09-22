using DTOs.DataTransferObjects.DTOHistoria;
using Obligatorio.LogicaNegocio.Entidades;

namespace DTOs.Mappers
{
    public class MapperHistoria
    {
        public static DTOHistoria ToDtoHistoria(Historia historia)
        {
            DTOHistoria dto = new DTOHistoria();
            dto.Id = historia.Id;
            dto.Titulo = historia.Titulo;
            dto.Sinopsis = historia.Sinopsis;
            dto.Estado = historia.Estado.ToString();
            dto.CapituloInicialId = historia.CapituloInicial?.Id;
            dto.CapituloInicialTitulo = historia.CapituloInicial?.Titulo ?? string.Empty;
            dto.CantidadCapitulos = historia.Capitulos.Count;

            foreach (Categoria categoria in historia.Categorias)
            {
                dto.Categorias.Add(categoria.Nombre);
            }

            return dto;
        }

        public static List<DTOHistoria> ToListDtoHistoria(List<Historia> lista)
        {
            List<DTOHistoria> retorno = new List<DTOHistoria>();

            foreach (Historia historia in lista)
            {
                retorno.Add(ToDtoHistoria(historia));
            }

            return retorno;
        }
    }
}
