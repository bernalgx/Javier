using System;
using Microsoft.Data.SqlClient;
using Capa_Acceso_Datos;
using Capa_Entidades;

namespace Capa_Acceso_Datos
{
	public class DatosInventario
	{
		private readonly ConexionBD _conexion;

		public DatosInventario()
		{
			_conexion = new ConexionBD();
		}

		public List<InventarioConsultaEntidad> ObtenerInventario()
		{
			List<InventarioConsultaEntidad> lista = new List<InventarioConsultaEntidad>();

			try
			{
				using (var conn = _conexion.ObtenerConexion())
				{
					conn.Open();

					string sql = @"SELECT 
                            T.[Id] AS Id_Tienda, 
                            T.[Nombre] AS TiendaNombre, 
                            T.[Direccion] AS TiendaDireccion, 
                            V.[Id] AS Id_Videojuego, 
                            V.[Nombre] AS VideojuegoNombre, 
                            TV.[Nombre] AS TipoVideojuegoNombre, 
                            VT.[Existencias] 
                          FROM [VideojuegosXTienda] VT 
                          JOIN [Tienda] T ON VT.[Id_Tienda] = T.[Id] 
                          JOIN [Videojuego] V ON VT.[Id_Videojuego] = V.[Id] 
                          JOIN [TipoVideojuego] TV ON V.[Id_TipoVideojuego] = TV.[Id]";

					using (var cmd = new SqlCommand(sql, conn))
					{
						using (var dr = cmd.ExecuteReader())
						{
							while (dr.Read())
							{
								InventarioConsultaEntidad item = new InventarioConsultaEntidad
								{
									Id_Tienda = dr.GetInt32(0),
									TiendaNombre = dr.GetString(1),
									TiendaDireccion = dr.GetString(2),
									Id_VideoJuego = Convert.ToInt32(dr.GetDecimal(3)), // ← Convierte decimal a int

									VideojuegoNombre = dr.GetString(4),
									TipoVideojuegoNombre = dr.GetString(5),
									Existencias = dr.GetInt32(6)
								};
								lista.Add(item);
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				throw new Exception("Error al obtener inventario: " + ex.Message);
			}

			return lista;
		}



		public string Crear(VideojuegosXTiendaEntidad nuevoRegistro)
		{
			try
			{
				using (var conn = _conexion.ObtenerConexion())
				{
					conn.Open();
					string sql = @"INSERT INTO VideojuegosXTienda (Id_Tienda, Id_Videojuego, Existencias) VALUES (@Id_Tienda, @Id_Videojuego, @Existencias)";

					using (var cmd = new SqlCommand(sql, conn))
					{
						cmd.Parameters.AddWithValue("@Id_Tienda", nuevoRegistro.Tienda.Id);
						cmd.Parameters.AddWithValue("@Id_Videojuego", nuevoRegistro.Videojuego.Id);
						cmd.Parameters.AddWithValue("@Existencias", nuevoRegistro.Existencias);

						int filasAfectadas = cmd.ExecuteNonQuery();
						if (filasAfectadas > 0)
						{
							return "Registro creado correctamente.";
						}
						else
						{
							return "No se pudo crear el registro.";
						}
					}
				}
			}
			catch (Exception ex)
			{
				return "Error al crear el registro: " + ex.Message;
			}
		}

		public List<InventarioConsultaEntidad> ObtenerInventarioPorTienda(int Id_Tienda)
		{
			List<InventarioConsultaEntidad> lista = new List<InventarioConsultaEntidad>();

			try
			{
				using (var conn = _conexion.ObtenerConexion())
				{
					conn.Open();
					//sql
					string sql = @"SELECT T.Id, T.Nombre, T.Direccion, 
		                        V.Id, V.Nombre, TV.Nombre, VT.Existencias
		                        FROM VideojuegosXTienda VT
		                        JOIN Tienda T ON VT.Id_Tienda = T.Id
		                        JOIN Videojuego V ON VT.Id_Videojuego = V.Id
		                        JOIN TipoVideojuego TV ON V.Id_TipoVideojuego = TV.Id
		                        WHERE T.Id = @Id_Tienda AND VT.Existencias > 0";

					using (var cmd = new SqlCommand(sql, conn))
					{
						cmd.Parameters.AddWithValue("@Id_Tienda", Id_Tienda);
						using (var dr = cmd.ExecuteReader())
						{
							while (dr.Read())
							{
								InventarioConsultaEntidad item = new InventarioConsultaEntidad
								{
									Id_Tienda = dr.GetInt32(0),
									TiendaNombre = dr.GetString(1),
									TiendaDireccion = dr.GetString(2),
									Id_VideoJuego = dr.GetDecimal(3),  // ← Leer como decimal directamente
									VideojuegoNombre = dr.GetString(4),
									TipoVideojuegoNombre = dr.GetString(5),
									Existencias = dr.GetInt32(6)
								};
								lista.Add(item);
							}

						}
					}
				}
			}
			catch (Exception ex)
			{
				throw new Exception("Error obteniendo inventario por tienda: " + ex.Message);
			}
			return lista;
		}


	}
}
