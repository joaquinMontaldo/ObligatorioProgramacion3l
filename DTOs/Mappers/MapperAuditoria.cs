using DTOs.DataTransferObjects.DTOAuditoria;
using Obligatorio.LogicaNegocio.Entidades;

namespace DTOs.Mappers
{
    public class MapperAuditoria
    {
        public static DTOAuditoria ToDtoAuditoria(Auditoria auditoria)
        {
            DTOAuditoria dto = new DTOAuditoria();
            dto.Id = auditoria.Id;
            dto.UsuarioAdministradorId = auditoria.UsuarioAdministrador?.Id;
            dto.UsuarioAdministradorNombre = auditoria.UsuarioAdministrador?.NombreUsuario ?? string.Empty;
            dto.Accion = auditoria.Accion;
            dto.Fecha = auditoria.Fecha;
            dto.HistoriaId = auditoria.Historia?.Id;
            dto.HistoriaTitulo = auditoria.Historia?.Titulo ?? string.Empty;
            return dto;
        }

        public static List<DTOAuditoria> ToListDtoAuditoria(List<Auditoria> lista)
        {
            List<DTOAuditoria> retorno = new List<DTOAuditoria>();

            foreach (Auditoria auditoria in lista)
            {
                retorno.Add(ToDtoAuditoria(auditoria));
            }

            return retorno;
        }
    }
}
