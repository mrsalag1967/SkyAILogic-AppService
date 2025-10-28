using Microsoft.AspNetCore.Mvc.RazorPages;
using SpartaneApp.Models; // ¡Importante!

namespace SpartaneApp.Pages
{
    public class TareasModel : PageModel
    {
        public List<Tarea> Tareas { get; set; } = new List<Tarea>(); // Inicialización para evitar warnings

        public void OnGet()
        {
            // Datos simulados de tu negocio Spartane
            Tareas = new List<Tarea>
            {
                new Tarea { Id = 1, Titulo = "Módulo de Clientes", Estado = "En Progreso", FechaLimite = DateTime.Parse("2026-01-15"), CSSClaseEstado = "bg-warning text-dark" },
                new Tarea { Id = 2, Titulo = "Pasarela de Pagos (Setup)", Estado = "Completado", FechaLimite = DateTime.Parse("2025-11-01"), CSSClaseEstado = "bg-success" },
                new Tarea { Id = 3, Titulo = "Diseño del Logotipo 'Spartane'", Estado = "Pendiente", FechaLimite = DateTime.Parse("2025-12-01"), CSSClaseEstado = "bg-danger" }
            };
        }
    }
}