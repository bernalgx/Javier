// ==========================================
// Universidad Estatal a Distancia
// I Cuatrimestre 2025
// 45GAMES4U - Sistema de Inventario de Videojuegos
// Javier Rojas Cordero
// Proyecto 2
// ==========================================

using Capa_Entidades;


namespace Capa_Log_Negocio
{
    public class LogInventario // Define la clase LogInventario
    {
        private VideojuegosXTiendaEntidad[] inventario = new VideojuegosXTiendaEntidad[100]; // Declara un arreglo de VideojuegosXTiendaEntidad con capacidad para 100 elementos
        private int indice = 0; // Declara una variable para llevar el indice del arreglo

        public string RegistroInventario(TiendaEntidad tienda, VideojuegoEntidad videojuego, int existencias) // Metodo para registrar un inventario
        {
            if (tienda == null || videojuego == null)
                return "Debe seleccionar una tienda y un videojuego."; // Verifica que la tienda y el videojuego no sean nulos

            if (existencias <= 0)
                return "Las existencias deben ser mayores a 0."; // Verifica que las existencias sean mayores a 0

            if (indice >= inventario.Length)
                return "No se pueden agregar mas registros."; // Verifica que haya espacio en el arreglo

            inventario[indice] = new VideojuegosXTiendaEntidad(tienda, videojuego, existencias); // Crea una nueva instancia de VideojuegosXTiendaEntidad y la agrega al arreglo
            indice++; // Incrementa el indice

            return "Inventario registrado correctamente."; // Retorna un mensaje de exito
        }

        public VideojuegosXTiendaEntidad[] ObtenerInventario() // Metodo para obtener el inventario
        {
            return inventario.Take(indice).ToArray(); // Retorna una copia del arreglo con los elementos registrados
        }
    }
}

//Como referencias se utilizaron los libros (Como programar en C#, Harvey M. Deitel), (Guia de Estudio, Programacion Avanzada, Carlos H. Hernandez Alvarado, como tambien las tutorias del curso)
