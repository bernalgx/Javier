// ==========================================
// Universidad Estatal a Distancia
// I Cuatrimestre 2025
// 45GAMES4U - Sistema de Inventario de Videojuegos
// Javier Rojas Cordero
// Proyecto 2
// ==========================================

using Capa_Acceso_Datos;
using Capa_Entidades;
using System;
using System.Collections.Generic;

namespace Capa_Log_Negocio
{
    public class LogCliente // Define la clase LogCliente
    {
        private ClienteEntidad[] clientes = new ClienteEntidad[20]; // Declara un arreglo de ClienteEntidad con capacidad para 20 elementos
        private int indice = 0; // Declara una variable para llevar el indice del arreglo

        public string RegistroCliente(int identificacion, string nombre, string primerApellido, string segundoApellido, DateTime fechaNacimiento, bool jugadorEnLinea) // Metodo para registrar un cliente
        {
            // Validacion de campos requeridos
            if (string.IsNullOrWhiteSpace(nombre) ||
                string.IsNullOrWhiteSpace(primerApellido) ||
                string.IsNullOrWhiteSpace(segundoApellido))
                return "Todos los campos son requeridos."; // Verifica que los campos nombre, primerApellido y segundoApellido no esten vacios

            // Validar que la identificacion sea unica
            for (int i = 0; i < indice; i++)
            {
                if (clientes[i].Identificacion == identificacion)
                    return "La identificacion ya existe."; // Verifica que la identificacion no exista en el arreglo
            }

            // Validar espacio en el arreglo
            if (indice >= clientes.Length)
                return "No se pueden agregar mas clientes."; // Verifica que haya espacio en el arreglo

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
            indice++; // Incrementa el indice

            return "Cliente registrado correctamente."; // Retorna un mensaje de exito
        }

        public List<ClienteEntidad> ObtenerClientesDesdeBD() // Metodo para obtener todos los clientes desde la base de datos
        {
            DatosCliente datos = new DatosCliente(); // Crea una instancia de DatosCliente
            return datos.ObtenerClientes(); // Llama al metodo ObtenerClientes de DatosCliente y retorna la lista de clientes
        }

        public string EliminarCliente(int identificacion) // Metodo para eliminar un cliente
        {
            try
            {
                DatosCliente datos = new DatosCliente(); // Crea una instancia de DatosCliente
                bool resultado = datos.Eliminar(identificacion); // Llama al metodo Eliminar de DatosCliente y almacena el resultado
                return resultado ? "Cliente eliminado correctamente." : "No se pudo eliminar el cliente."; // Retorna un mensaje segun el resultado
            }
            catch (Exception ex) // Captura cualquier excepcion que ocurra
            {
                return ex.Message; // Retorna el mensaje de la excepcion
            }
        }

        public string EditarCliente(ClienteEntidad cliente) // Metodo para editar un cliente
        {
            try
            {
                DatosCliente datos = new DatosCliente(); // Crea una instancia de DatosCliente
                bool resultado = datos.Actualizar(cliente); // Llama al metodo Actualizar de DatosCliente y almacena el resultado
                return resultado ? "Cliente actualizado correctamente." : "No se pudo actualizar el cliente."; // Retorna un mensaje segun el resultado
            }
            catch (Exception ex) // Captura cualquier excepcion que ocurra
            {
                return ex.Message; // Retorna el mensaje de la excepcion
            }
        }

        public bool ValidarExistenciaCliente(int identificacion) // Metodo para validar la existencia de un cliente
        {
            try
            {
                DatosCliente datos = new DatosCliente(); // Crea una instancia de DatosCliente
                return datos.ExisteCliente(identificacion); // Llama al metodo ExisteCliente de DatosCliente y retorna el resultado
            }
            catch (Exception) // Captura cualquier excepcion que ocurra
            {
                return false; // Retorna false en caso de excepcion
            }
        }
    }
}

//Como referencias se utilizaron los libros (Como programar en C#, Harvey M. Deitel), (Guia de Estudio, Programacion Avanzada, Carlos H. Hernandez Alvarado, como tambien las tutorias del curso)
