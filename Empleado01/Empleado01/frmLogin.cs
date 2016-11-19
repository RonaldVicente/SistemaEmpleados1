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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            label3.Hide();
            pbrConectar.Hide();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "admin" && txtPassword.Text == "12345")
            {
                timer1.Start();
                label3.Show();
                pbrConectar.Show();
            }
            else
            {
                MessageBox.Show("Acceso denegado...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                txtUsuario.Clear();
                txtPassword.Clear();
                txtUsuario.Focus();
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            pbrConectar.Increment(500);
            if (pbrConectar.Value == pbrConectar.Maximum)
            {
                timer1.Stop();
                this.Visible = false;
                frmEmpleado f = new frmEmpleado();
                f.ShowDialog();
                this.Close();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
