namespace DomiEats.Models;

public class Categoria
{
    public int Id { get; set; }
    public required string Nombre { get; set; }
    public List<Producto> Productos { get; set; } = new();
    public int ComercioId { get; set; }
    public Comercio? Comercio { get; set; }

}
