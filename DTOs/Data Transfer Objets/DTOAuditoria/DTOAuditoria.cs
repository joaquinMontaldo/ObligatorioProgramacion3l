namespace DTOs.DataTransferObjects.DTOAuditoria
{
    public class DTOAuditoria
    {
        public int Id { get; set; }
        public int? UsuarioAdministradorId { get; set; }
        public string UsuarioAdministradorNombre { get; set; } = string.Empty;
        public string Accion { get; set; } = string.Empty;
        public DateTime Fecha { get; set; }
        public int? HistoriaId { get; set; }
        public string HistoriaTitulo { get; set; } = string.Empty;
    }
}
