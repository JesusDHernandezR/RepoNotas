namespace WebApiNotas.Models
{
    public class Note
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public required string Titulo { get; set; }
        public required string Categoria { get; set; }    
        public required string Descripcion { get; set;}
    }
}
