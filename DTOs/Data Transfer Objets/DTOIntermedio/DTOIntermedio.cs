using OpcionDto = DTOs.DataTransferObjects.DTOOpcion.DTOOpcion;

namespace DTOs.DataTransferObjects.DTOIntermedio
{
    public class DTOIntermedio
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public string Texto { get; set; } = string.Empty;
        public int? HistoriaId { get; set; }
        public string HistoriaTitulo { get; set; } = string.Empty;
        public List<OpcionDto> Opciones { get; set; } = new();
    }
}
