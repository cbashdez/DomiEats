namespace DomiEats.Models;

public class Producto
{
    public int Id { get; set; }
    public required string Nombre { get; set; }
    public string? Descripcion { get; set; }
    public decimal Precio { get; set; }
    public bool Disponible { get; set; }
    public int CategoriaId { get; set; }
    public Categoria? Categoria { get; set; }

}
