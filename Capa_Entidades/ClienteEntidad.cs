namespace Capa_Entidades // Espacio para organizar clases que se relacionan con entidades del sistema
{
    public static class DatosCliente
    {
        private static ClienteEntidad[] clientes = new ClienteEntidad[20];
        private static int contador = 0;

        public static bool Crear(ClienteEntidad cliente)
        {
            if (contador >= 20) return false;

            foreach (var c in clientes)
            {
                if (c != null && c.Identificacion == cliente.Identificacion)
                    throw new Exception("La identificación ya existe.");
            }

            clientes[contador] = cliente;
            contador++;
            return true;
        }

        public static ClienteEntidad[] ObtenerTodos() => clientes;

        public static bool Actualizar(ClienteEntidad cliente)
        {
            for (int i = 0; i < contador; i++)
            {
                if (clientes[i] != null && clientes[i].Identificacion == cliente.Identificacion)
                {
                    clientes[i] = cliente;
                    return true;
                }
            }
            return false;
        }

        public static bool Eliminar(int id)
        {
            for (int i = 0; i < contador; i++)
            {
                if (clientes[i] != null && clientes[i].Identificacion == id)
                {
                    clientes[i] = null;
                    return true;
                }
            }
            return false;
        }
    }
}
