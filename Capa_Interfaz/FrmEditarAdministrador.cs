using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Entidades;

namespace Capa_Interfaz
{
    public partial class FrmEditarAdministrador : Form
    {
        public AdministradorEntidad Administrador { get; private set; }
        public FrmEditarAdministrador(AdministradorEntidad admin)
        {
            InitializeComponent();
            Administrador = admin;
        }

        private void FrmEditarAdministrador_Load(object sender, EventArgs e)
        {
            txtIdentificacion.Text = Administrador.Identificacion.ToString();
            txtIdentificacion.ReadOnly = true;
            txtNombre.Text = Administrador.Nombre;
            txtPrimerApellido.Text = Administrador.PrimerApellido;
            txtSegundoApellido.Text = Administrador.SegundoApellido;
            dtpNacimiento.Value = Administrador.FechaNacimiento;
            dtpContratacion.Value = Administrador.FechaContratacion;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Administrador.Nombre = txtNombre.Text;
            Administrador.PrimerApellido = txtPrimerApellido.Text;
            Administrador.SegundoApellido = txtSegundoApellido.Text;
            Administrador.FechaNacimiento = dtpNacimiento.Value;
            Administrador.FechaContratacion = dtpContratacion.Value;

            DialogResult = DialogResult.OK;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
