namespace DTOs.DataTransferObjects.DTOUsuario
{
    public class DTOUsuario
    {
        public int Id { get; set; }
        public string NombreUsuario { get; set; } = string.Empty;
        public string NombreCompleto { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Rol { get; set; } = string.Empty;
        public string Estilo { get; set; } = string.Empty;
    }
}
