using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaCobroAgua.Vistas
{
    public partial class MenuPrincipalForm : MetroFramework.Forms.MetroForm
    {
        public MenuPrincipalForm()
        {
            InitializeComponent();
        }

        private void mtUsuarios_Click(object sender, EventArgs e)
        {
            using (UsuariosForm formUsuarios = new UsuariosForm())
            {
                this.Hide();
                formUsuarios.ShowDialog();
            }
        }

        private void mtClientes_Click(object sender, EventArgs e)
        {
            using (ClientesForm formClientes = new ClientesForm())
            {
                this.Hide();
                formClientes.ShowDialog();
            }
        }

        private void mtServicios_Click(object sender, EventArgs e)
        {
            using (ServiciosForm formServicios = new ServiciosForm())
            {
                this.Hide();
                formServicios.ShowDialog();
            }
        }

        private void mtTarifasResidenciales_Click(object sender, EventArgs e)
        {
            using (TarifasResidencialesForm formTarifasResidenciales = new TarifasResidencialesForm())
            {
                this.Hide();
                formTarifasResidenciales.ShowDialog();
            }
        }

        private void mtTarifasComerciales_Click(object sender, EventArgs e)
        {
            using (TarifasEstablecimientosForm formTarifasComerciales = new TarifasEstablecimientosForm())
            {
                this.Hide();
                formTarifasComerciales.ShowDialog();
            }
        }

        private void mtCaja_Click(object sender, EventArgs e)
        {
            using (CajaForm formCaja = new CajaForm())
            {
                this.Hide();
                formCaja.ShowDialog();
            }
        }

        private void mtCerrarSession_Click(object sender, EventArgs e)
        {
            using (AuthLoginForm formAuthLogin = new AuthLoginForm())
            {
                this.Hide();
                formAuthLogin.ShowDialog();
            }
        }
    }
}
