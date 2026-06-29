namespace DomiEats.Models;

public class Usuario
{
    public int Id { get; set; }
    public required string Nombre { get; set; }
    public required string Correo { get; set; }
    public required string Contrasena { get; set; }
    public required string Telefono { get; set; }
    public RolUsuario Rol { get; set; }
}