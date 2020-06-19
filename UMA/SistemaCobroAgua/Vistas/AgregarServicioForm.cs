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
    public partial class AgregarServicioForm : MetroFramework.Forms.MetroForm
    {
        public AgregarServicioForm()
        {
            InitializeComponent();
        }

        //variables para la paginacion 
        int pageNumber = 1;
        IPagedList<Servicio> list;
        //clases
        Servicio _servicio = new Servicio();
        ServicioDAL _servicioDAL = new ServicioDAL();

        //paginacion asincrona metodo
        public async Task<IPagedList<Servicio>> GetPagedListAsync(int pageNumber = 1, int pageSize = 20)
        {
            return await Task.Factory.StartNew(() =>
            {
                return _servicioDAL.ObtenerServicios().OrderByDescending(u => u.ServicioID).ToPagedList(pageNumber, pageSize);
            });
        }
        //metodo de carga de table
        private async void CargaDatos()
        {
            list = await GetPagedListAsync();
            btnPrevious.Enabled = list.HasPreviousPage;
            btnNext.Enabled = list.HasNextPage;
            dataGridViewServiciosBuscador.DataSource = list.ToList();
            lblPageNumber.Text = string.Format("Pagina {0}/{1}", pageNumber, list.PageCount);
        }
        //evento de data grid
        private void dataGridViewServiciosBuscador_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewServiciosBuscador.Rows[e.RowIndex];
                txtID.Text = row.Cells["ServicioID"].Value.ToString();
                txtNombre.Text = row.Cells["NombreDeServicio"].Value.ToString();
                txtPrecio.Text = row.Cells["Precio"].Value.ToString();
            }
        }
        private void dataGridViewServiciosBuscador_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewServiciosBuscador.Rows[e.RowIndex];
                txtID.Text = row.Cells["ServicioID"].Value.ToString();
                txtNombre.Text = row.Cells["NombreDeServicio"].Value.ToString();
                txtPrecio.Text = row.Cells["Precio"].Value.ToString();

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
                dataGridViewServiciosBuscador.DataSource = list.Where(
                s => s.NombreDeServicio.ToUpper().Contains(txtBarraBuscar.Text.ToUpper()) ||
                s.NombreDeServicio.ToLower().Contains(txtBarraBuscar.Text.ToLower())
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
                dataGridViewServiciosBuscador.DataSource = list.ToList();
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
                dataGridViewServiciosBuscador.DataSource = list.ToList();
                lblPageNumber.Text = string.Format("Pagina {0}/{1}", pageNumber, list.PageCount);
            }
        }
        

        private void btnEnviarServicioCaja_Click(object sender, EventArgs e)
        {
            using (CajaForm _cajaForm = new CajaForm())
            {
                _cajaForm.ShowDialog();
                this.Hide();
            }

        }

        private void AgregarServicioForm_Load(object sender, EventArgs e)
        {
            //carga lista
            CargaDatos();
        }
    }
}
