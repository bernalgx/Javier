//﻿using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace Capa_Interfaz
//{
    // Formulario para consultar el inventario
//    public partial class FrmConsultaInventario : Form
//    {
//        private VideojuegosXTiendaEntidad[] inventario;

//        public FrmConsultaInventario(VideojuegosXTiendaEntidad[] inventario)
//        {
//            InitializeComponent();
//            this.inventario = inventario;
//        }

        // Evento para cargar los datos en el DataGridView
 //       private void btnCargarDatos_Click(object sender, EventArgs e)
 //       {
 //           try
 //           {
 //               dgvInventario.DataSource = inventario.Where(i => i != null).Select(i => new 
 //               {
  //                  TiendaID = i.Tienda.Id,
  //                  TiendaNombre = i.Tienda.Nombre,
  //                  TiendaDireccion = i.Tienda.Direccion,
  //                  VideojuegoID = i.Videojuego.Id,
  //                  VideojuegoNombre = i.Videojuego.Nombre,
 //                   TipoVideojuego = i.Videojuego.TipoVideojuego.Nombre,
 //                   Existencias = i.Existencias
  //              }).ToList();
  //          }
  //          catch (Exception ex)
  //          {
  //              MessageBox.Show("Error al cargar los datos: " + ex.Message);
  //          }
  //      }
  //  }
//}
