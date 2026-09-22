using DTOs.DataTransferObjects.DTOCategoria;
using Obligatorio.LogicaNegocio.Entidades;

namespace DTOs.Mappers
{
    public class MapperCategoria
    {
        public static DTOCategoria ToDtoCategoria(Categoria categoria)
        {
            DTOCategoria dto = new DTOCategoria();
            dto.Id = categoria.Id;
            dto.Nombre = categoria.Nombre;
            return dto;
        }

        public static List<DTOCategoria> ToListDtoCategoria(List<Categoria> lista)
        {
            List<DTOCategoria> retorno = new List<DTOCategoria>();

            foreach (Categoria categoria in lista)
            {
                retorno.Add(ToDtoCategoria(categoria));
            }

            return retorno;
        }
    }
}
