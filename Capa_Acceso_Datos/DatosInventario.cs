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

					string sql = @"SELECT T.[Id] AS TiendaId, T.[Nombre] AS TiendaNombre, T.[Direccion] AS TiendaDireccion, V.[Id] AS VideojuegoId, V.[Nombre] AS VideojuegoNombre, TV.[Nombre] AS TipoVideojuegoNombre, VT.[Existencias] FROM [VideojuegosXTienda] VT JOIN [Tienda] T ON VT.[TiendaId] = T.[Id] JOIN [Videojuego] V ON VT.[VideojuegoId] = V.[Id] JOIN [TipoVideojuego] TV ON V.[TipoVideojuegoId] = TV.[Id]";
					using (var cmd = new SqlCommand(sql, conn))
					{
						using (var dr = cmd.ExecuteReader())
						{
							while (dr.Read())
							{
								InventarioConsultaEntidad item = new InventarioConsultaEntidad
								{
									TiendaId = dr.GetInt32(0),
									TiendaNombre = dr.GetString(1),
									TiendaDireccion = dr.GetString(2),
									VideojuegoId = dr.GetInt32(3),
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
					string sql = @"INSERT INTO VideojuegosXTienda (TiendaId, VideojuegoId, Existencias)
                           VALUES (@TiendaId, @VideojuegoId, @Existencias)";

					using (var cmd = new SqlCommand(sql, conn))
					{
						cmd.Parameters.AddWithValue("@TiendaId", nuevoRegistro.Tienda.Id);
						cmd.Parameters.AddWithValue("@VideojuegoId", nuevoRegistro.Videojuego.Id);
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

		public List<InventarioConsultaEntidad> ObtenerInventarioPorTienda(int tiendaId)
		{
			List<InventarioConsultaEntidad> lista = new List<InventarioConsultaEntidad>();

			try
			{
				using (var conn = _conexion.ObtenerConexion())
				{
					conn.Open();
					string sql = @"SELECT T.Id, T.Nombre, T.Direccion, 
		                        V.Id, V.Nombre, TV.Nombre, VT.Existencias
		                        FROM VideojuegosXTienda VT
		                        JOIN Tienda T ON VT.TiendaId = T.Id
		                        JOIN Videojuego V ON VT.VideojuegoId = V.Id
		                        JOIN TipoVideojuego TV ON V.TipoVideojuegoId = TV.Id
		                        WHERE T.Id = @TiendaId AND VT.Existencias > 0";

					using (var cmd = new SqlCommand(sql, conn))
					{
						cmd.Parameters.AddWithValue("@TiendaId", tiendaId);
						using (var dr = cmd.ExecuteReader())
						{
							while (dr.Read())
							{
								lista.Add(new InventarioConsultaEntidad
								{
									TiendaId = dr.GetInt32(0),
									TiendaNombre = dr.GetString(1),
									TiendaDireccion = dr.GetString(2),
									VideojuegoId = dr.GetInt32(3),
									VideojuegoNombre = dr.GetString(4),
									TipoVideojuegoNombre = dr.GetString(5),
									Existencias = dr.GetInt32(6)
								});
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

		//public VideojuegosXTiendaEntidad ObtenerVideojuegoTienda(int tiendaId, int videojuegoId)
		//{
		//	try
		//	{
		//		using (var conn = _conexion.ObtenerConexion())
		//		{
		//			conn.Open();
		//			string sql = @"SELECT VT.TiendaId, VT.VideojuegoId, VT.Existencias,
		//                        T.Id, T.Nombre, T.Direccion, T.Activa,
		//                        V.Id, V.Nombre, V.Fisico
		//                        FROM VideojuegosXTienda VT
		//                        JOIN Tienda T ON VT.TiendaId = T.Id
		//                        JOIN Videojuego V ON VT.VideojuegoId = V.Id
		//                        WHERE VT.TiendaId = @TiendaId AND VT.VideojuegoId = @VideojuegoId";

		//			using (var cmd = new SqlCommand(sql, conn))
		//			{
		//				cmd.Parameters.AddWithValue("@TiendaId", tiendaId);
		//				cmd.Parameters.AddWithValue("@VideojuegoId", videojuegoId);

		//				using (var dr = cmd.ExecuteReader())
		//				{
		//					if (dr.Read())
		//					{
		//						return new VideojuegosXTiendaEntidad
		//						{
		//							Tienda = new TiendaEntidad
		//							{
		//								Id = dr.GetInt32(3),
		//								Nombre = dr.GetString(4),
		//								Direccion = dr.GetString(5),
		//								Activa = dr.GetBoolean(6)
		//							},
		//							Videojuego = new VideojuegoEntidad
		//							{
		//								Id = dr.GetInt32(7),
		//								Nombre = dr.GetString(8),
		//								Fisico = dr.GetBoolean(9)
		//							},
		//							Existencias = dr.GetInt32(2)
		//						};
		//					}
		//				}
		//			}
		//		}
		//	}
		//	catch (Exception ex)
		//	{
		//		throw new Exception("Error obteniendo videojuego por tienda: " + ex.Message);
		//	}
		//	return null;
		//}
	}
}
