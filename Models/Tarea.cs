namespace SpartaneApp.Models
{
    public class Tarea
    {
        public int Id { get; set; }
        public string? Titulo { get; set; }
        public string? Estado { get; set; }
        public DateTime FechaLimite { get; set; }
        public string? CSSClaseEstado { get; set; }
    }
}