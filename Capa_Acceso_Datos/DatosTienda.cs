//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Data.SqlClient;
//using Capa_Entidades;


//namespace Capa_Acceso_Datos // Espacio para organizar clases que tienen relacion con acceso a datos
//{
//    public static class DatosTienda
//    {
//        private static TiendaEntidad[] tiendas = new TiendaEntidad[5];
//        private static int contador = 0;

//        public static bool Crear(TiendaEntidad tienda)
//        {
//            if (contador >= 5) return false;

//            foreach (var t in tiendas)
//            {
//                if (t != null && t.Id == tienda.Id)
//                    throw new Exception("El ID ya existe.");
//            }

//            tiendas[contador] = tienda;
//            contador++;
//            return true;
//        }

//        public static TiendaEntidad[] ObtenerTodos() => tiendas;

//        public static bool Actualizar(TiendaEntidad tienda)
//        {
//            for (int i = 0; i < contador; i++)
//            {
//                if (tiendas[i] != null && tiendas[i].Id == tienda.Id)
//                {
//                    tiendas[i] = tienda;
//                    return true;
//                }
//            }
//            return false;
//        }

//        public static bool Eliminar(int id)
//        {
//            for (int i = 0; i < contador; i++)
//            {
//                if (tiendas[i] != null && tiendas[i].Id == id)
//                {
//                    tiendas[i] = null;
//                    return true;
//                }
//            }
//            return false;
//        }
//    }
//}
