
public class TiendaEntidad
{
	public int Id { get; set; }
	public string Nombre { get; set; }
	public string Direccion { get; set; }
	public string Telefono { get; set; }
	public bool Activa { get; set; }
	public decimal Id_Administrador { get; set; }

	// Propiedad adicional para mostrar el nombre completo del administrador
	public string NombreAdministrador { get; set; }
}
