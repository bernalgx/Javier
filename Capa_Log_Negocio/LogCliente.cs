//TODO NUEVO/////////////////

using Capa_Acceso_Datos;
using Capa_Entidades;
using System;
using System.Collections.Generic;

namespace Capa_Log_Negocio
{
    public class LogCliente
    {
        private ClienteEntidad[] clientes = new ClienteEntidad[20];
        private int indice = 0;

        public string RegistroCliente(int identificacion, string nombre, string primerApellido,
                                    string segundoApellido, DateTime fechaNacimiento, bool jugadorEnLinea)
        {
            // Validación de campos requeridos
            if (string.IsNullOrWhiteSpace(nombre) ||
                string.IsNullOrWhiteSpace(primerApellido) ||
                string.IsNullOrWhiteSpace(segundoApellido))
                return "Todos los campos son requeridos.";

            // Validar que la identificación sea única
            for (int i = 0; i < indice; i++)
            {
                if (clientes[i].Identificacion == identificacion)
                    return "La identificación ya existe.";
            }

            // Validar espacio en el arreglo
            if (indice >= clientes.Length)
                return "No se pueden agregar más clientes.";

            // Registrar el cliente
            clientes[indice] = new ClienteEntidad
            {
                Identificacion = identificacion,
                Nombre = nombre,
                PrimerApellido = primerApellido,
                SegundoApellido = segundoApellido,
                FechaNacimiento = fechaNacimiento,
                JugadorEnLinea = jugadorEnLinea
            };
            indice++;

            return "Cliente registrado correctamente.";
        }

        public List<ClienteEntidad> ObtenerClientesDesdeBD()
        {
            DatosCliente datos = new DatosCliente();
            return datos.ObtenerClientes();
        }

        public string EliminarCliente(int identificacion)
        {
            try
            {
                DatosCliente datos = new DatosCliente();
                bool resultado = datos.Eliminar(identificacion);
                return resultado ? "Cliente eliminado correctamente." : "No se pudo eliminar el cliente.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string EditarCliente(ClienteEntidad cliente)
        {
            try
            {
                DatosCliente datos = new DatosCliente();
                bool resultado = datos.Actualizar(cliente);
                return resultado ? "Cliente actualizado correctamente." : "No se pudo actualizar el cliente.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public bool ValidarExistenciaCliente(int identificacion)
        {
            try
            {
                DatosCliente datos = new DatosCliente();
                return datos.ExisteCliente(identificacion);
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
