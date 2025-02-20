//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Data.SqlClient;
//using Capa_Entidades;


//namespace Capa_Acceso_Datos // Espacio para organizar clases que tienen relacion con acceso a datos
//{
//    public static class DatosAdministrador
//    {
//        private static AdministradorEntidad[] administradores = new AdministradorEntidad[20];
//        private static int contador = 0;

//        public static bool Crear(AdministradorEntidad admin)
//        {
//            if (contador >= 20) return false;

//            foreach (var a in administradores)
//            {
//                if (a != null && a.Identificacion == admin.Identificacion)
//                    throw new Exception("La identificación ya existe.");
//            }

//            administradores[contador] = admin;
//            contador++;
//            return true;
//        }

 //       public static AdministradorEntidad[] ObtenerTodos() => administradores;

//        public static bool Actualizar(AdministradorEntidad admin)
//        {
//            for (int i = 0; i < contador; i++)
//            {
//                if (administradores[i] != null && administradores[i].Identificacion == admin.Identificacion)
//                {
//                    administradores[i] = admin;
//                    return true;
//                }
//            }
//            return false;
//        }

//        public static bool Eliminar(int id)
//        {
//            for (int i = 0; i < contador; i++)
//            {
//                if (administradores[i] != null && administradores[i].Identificacion == id)
//                {
//                    administradores[i] = null;
//                    return true;
//                }
//            }
//            return false;
//        }
//    }
//}
