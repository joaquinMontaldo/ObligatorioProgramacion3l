namespace DTOs.DataTransferObjects.DTOHistoria
{
    public class DTOHistoria
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public string Sinopsis { get; set; } = string.Empty;
        public string Estado { get; set; } = string.Empty;
        public List<string> Categorias { get; set; } = new();
        public int? CapituloInicialId { get; set; }
        public string CapituloInicialTitulo { get; set; } = string.Empty;
        public int CantidadCapitulos { get; set; }
    }
}
