namespace DomiEats.Models;

public class Comercio
{
    public int Id { get; set; }
    public required string Nombre { get; set; }
    public required string Direccion { get; set; }
    public required string Telefono { get; set; }
    public string? Logo { get; set; }
    public bool Abierto { get; set; }
    public List<Categoria> Categorias { get; set; } = new();

}
