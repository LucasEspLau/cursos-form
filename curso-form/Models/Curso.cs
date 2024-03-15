namespace curso_form.Models
{
    public class Curso
    {
        public string Nombre { get; set; }
        public string Categoria { get; set; }
        public int Creditos { get; set; }
        public string Remoto { get; set; }
        public bool Material { get; set; }
        public bool Videos { get; set; }
        public DateTime HoraInicio { get; set; }
        public DateTime HoraFin { get; set; } 
    }
}