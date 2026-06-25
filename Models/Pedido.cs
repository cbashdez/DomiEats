namespace DomiEats.Models;

public class Pedido
{
    public int Id { get; set; }
    public DateTime Fecha { get; set; }
    public EstadoPedido Estado { get; set; }
    public decimal Total { get; set; }
    public required string DireccionEntrega { get; set; }

    // Cliente (quién lo pidió)
    public int ClienteId { get; set; }
    public Usuario? Cliente { get; set; }

    // Repartidor (quién lo lleva; vacío hasta que alguien lo tome)
    public int? RepartidorId { get; set; }
    public Usuario? Repartidor { get; set; }

    // Comercio (de dónde sale)
    public int ComercioId { get; set; }
    public Comercio? Comercio { get; set; }

    // Productos del pedido
    public List<DetallePedido> Detalles { get; set; } = new();
}