namespace DTOs.DataTransferObjects.DTOOpcion
{
    public class DTOOpcion
    {
        public int Id { get; set; }
        public string Texto { get; set; } = string.Empty;
        public int? CapituloOrigenId { get; set; }
        public string CapituloOrigenTitulo { get; set; } = string.Empty;
        public int? CapituloDestinoId { get; set; }
        public string CapituloDestinoTitulo { get; set; } = string.Empty;
        public string TipoCapituloDestino { get; set; } = string.Empty;
    }
}
