namespace DTOs.DataTransferObjects.DTOFinal
{
    public class DTOFinal
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public string Texto { get; set; } = string.Empty;
        public int? HistoriaId { get; set; }
        public string HistoriaTitulo { get; set; } = string.Empty;
        public int CantVecesLectoresLlegaronAFinal { get; set; }
    }
}
