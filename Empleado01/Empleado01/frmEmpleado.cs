using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empleado01
{
    public partial class frmEmpleado : Form
    {
        public frmEmpleado()
        {
            InitializeComponent();
        }
        // instanciar objeto de la clase Empleado
        Empleado obj = new Empleado();

        private void frmEmpleado_Load(object sender, EventArgs e)
        {
            lblFecha.Text = obj.Fecha;
        }

        private void tmrHora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = obj.Hora;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // asignar valores a las propiedades
            obj.Nombre = txtNombre.Text;
            obj.Sueldo = double.Parse(txtSueldo.Text);
            txtCodigo.Text = obj.Codigo;
            MessageBox.Show("Datos Registrados", "exito", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            // mostrar resultados
            txtBonificacion.Text = obj.Bonificacion.ToString();
            txtDescuento.Text = obj.Descuento.ToString();
            txtNeto.Text = obj.Neto.ToString();
            lblMensaje.Text = obj.Mensaje;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //limpia controles
            foreach (Control x in this.groupBox1.Controls)
            {
                if (x is TextBox || x is ComboBox) x.Text = "";
            }
            foreach (Control x in this.groupBox2.Controls)
            {
                if (x is TextBox) x.Text = "";
            }
            lblMensaje.Text = "";
            txtNombre.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" Desea Salir de la aplicacion ", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
