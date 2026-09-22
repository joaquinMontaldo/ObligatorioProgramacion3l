namespace DTOs.DataTransferObjects.DTOLectura
{
    public class DTOLectura
    {
        public int Id { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime? FechaFinalizacion { get; set; }
        public int? UsuarioId { get; set; }
        public string NombreUsuario { get; set; } = string.Empty;
        public int? HistoriaId { get; set; }
        public string HistoriaTitulo { get; set; } = string.Empty;
        public int? FinalId { get; set; }
        public string FinalTitulo { get; set; } = string.Empty;
        public bool EstaFinalizada { get; set; }
    }
}
