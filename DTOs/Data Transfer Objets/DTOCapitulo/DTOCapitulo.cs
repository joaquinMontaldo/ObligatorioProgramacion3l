namespace DTOs.DataTransferObjects.DTOCapitulo
{
    public class DTOCapitulo
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public string Texto { get; set; } = string.Empty;
        public int? HistoriaId { get; set; }
        public string HistoriaTitulo { get; set; } = string.Empty;
        public string Tipo { get; set; } = string.Empty;
    }
}
