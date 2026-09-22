using DTOs.DataTransferObjects.DTOUsuario;
using Obligatorio.LogicaNegocio.Entidades;

namespace DTOs.Mappers
{
    public class MapperUsuario
    {
        public static DTOUsuario ToDtoUsuario(Usuario usuario)
        {
            DTOUsuario dto = new DTOUsuario();
            dto.Id = usuario.Id;
            dto.NombreUsuario = usuario.NombreUsuario;
            dto.NombreCompleto = usuario.NombreCompleto;
            dto.Email = usuario.Email;
            dto.Rol = usuario.Rol.ToString();
            dto.Estilo = usuario.Estilo.ToString();
            return dto;
        }

        public static List<DTOUsuario> ToListDtoUsuario(List<Usuario> lista)
        {
            List<DTOUsuario> retorno = new List<DTOUsuario>();

            foreach (Usuario usuario in lista)
            {
                retorno.Add(ToDtoUsuario(usuario));
            }

            return retorno;
        }
    }
}
