using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//librerias
using SistemaCobroAgua.DAL;
using SistemaCobroAgua.Modelos;
using PagedList;

namespace SistemaCobroAgua.Vistas
{
    public partial class BuscadorClienteForm : MetroFramework.Forms.MetroForm
    {
        public BuscadorClienteForm()
        {
            InitializeComponent();
        }
        //variables para la paginacion 
        int pageNumber = 1;
        IPagedList<Cliente> list;
        //clases
        Cliente _cliente = new Cliente();
        ClienteDAL _clienteDAL = new ClienteDAL();

        //paginacion asincrona metodo
        public async Task<IPagedList<Cliente>> GetPagedListAsync(int pageNumber = 1, int pageSize = 20)
        {
            return await Task.Factory.StartNew(() =>
            {
                return _clienteDAL.ObtenerClientes().OrderByDescending(u => u.ClienteID).ToPagedList(pageNumber, pageSize);
            });
        }
        //metodo de carga de table
        private async void CargaDatos()
        {
            list = await GetPagedListAsync();
            btnPrevious.Enabled = list.HasPreviousPage;
            btnNext.Enabled = list.HasNextPage;
            dataGridViewClientesBuscador.DataSource = list.ToList();
            lblPageNumber.Text = string.Format("Pagina {0}/{1}", pageNumber, list.PageCount);
        }
        //evento de data grid
        private void dataGridViewClientesBuscador_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewClientesBuscador.Rows[e.RowIndex];
                txtID.Text = row.Cells["ClienteID"].Value.ToString();
                txtNombre.Text = row.Cells["Nombre"].Value.ToString();
                txtApellido.Text = row.Cells["Apellido"].Value.ToString();
            }
        }
        private void dataGridViewClientesBuscador_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewClientesBuscador.Rows[e.RowIndex];
                txtID.Text = row.Cells["ClienteID"].Value.ToString();
                txtNombre.Text = row.Cells["Nombre"].Value.ToString();
                txtApellido.Text = row.Cells["Apellido"].Value.ToString();
            }
        }

        //boton de buscar
        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBarraBuscar.Text.ToString().Trim()))
            {
                list = await GetPagedListAsync();
                btnPrevious.Enabled = list.HasPreviousPage;
                btnNext.Enabled = list.HasNextPage;
                dataGridViewClientesBuscador.DataSource = list.Where(
                s => s.Nombre.ToUpper().Contains(txtBarraBuscar.Text.ToString().ToUpper()) ||
                s.Apellido.ToUpper().Contains(txtBarraBuscar.Text.ToString().ToUpper()) ||
                s.Nombre.ToLower().Contains(txtBarraBuscar.Text.ToString().ToLower()) ||
                s.Apellido.ToLower().Contains(txtBarraBuscar.Text.ToString().ToLower()) ||
                s.DUI.ToUpper().Contains(txtBarraBuscar.Text.ToString().ToUpper()) ||
                 s.DUI.ToLower().Contains(txtBarraBuscar.Text.ToString().ToLower())
                ).ToList();
                lblPageNumber.Text = string.Format("Pagina {0}/{1}", pageNumber, list.PageCount);
            }
            else
            {
                CargaDatos();
            }

        }
        //boton de anterior paginacion
        private async void btnPrevious_Click(object sender, EventArgs e)
        {
            if (list.HasPreviousPage)
            {
                list = await GetPagedListAsync(--pageNumber);
                btnPrevious.Enabled = list.HasPreviousPage;
                btnNext.Enabled = list.HasNextPage;
                dataGridViewClientesBuscador.DataSource = list.ToList();
                lblPageNumber.Text = string.Format("Pagina {0}/{1}", pageNumber, list.PageCount);
            }
        }

        //boton de siguiente paginacion
        private async void btnNext_Click(object sender, EventArgs e)
        {
            if (list.HasNextPage)
            {
                list = await GetPagedListAsync(++pageNumber);
                btnPrevious.Enabled = list.HasPreviousPage;
                btnNext.Enabled = list.HasNextPage;
                dataGridViewClientesBuscador.DataSource = list.ToList();
                lblPageNumber.Text = string.Format("Pagina {0}/{1}", pageNumber, list.PageCount);
            }
        }
        //metodo de formulario de carga
        private void BuscadorClienteForm_Load(object sender, EventArgs e)
        {
            //carga lista
            CargaDatos();
        }

        private void btnEnviarClienteCaja_Click(object sender, EventArgs e)
        {
            using (CajaForm _cajaForm = new CajaForm())
            {
                _cajaForm.txtNombre.Text = txtNombre.Text.ToString();
                _cajaForm.txtApellido.Text = txtApellido.Text.ToString();
                _cajaForm.txtClienteID.Text = txtID.Text.ToString();
                _cajaForm.ShowDialog();
                this.Hide();
            }

        }
    }
}
