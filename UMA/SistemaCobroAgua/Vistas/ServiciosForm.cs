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
    public partial class ServiciosForm : MetroFramework.Forms.MetroForm
    {
        //variables para la paginacion 
        int pageNumber = 1;
        IPagedList<Servicio> list;
        //clases
        Servicio _servicio = new Servicio();
        ServicioDAL _servicioDAL = new ServicioDAL();

        //inicia el formulario
        public ServiciosForm()
        {
            InitializeComponent();
        }
        //boton de menu
        private void mtMenu_Click(object sender, EventArgs e)
        {
            using (MenuPrincipalForm formMenu = new MenuPrincipalForm())
            {
                this.Hide();
                formMenu.ShowDialog();
            }
        }
        //boton para ir a caja
        private void mtCaja_Click(object sender, EventArgs e)
        {
            using (CajaForm formCaja = new CajaForm())
            {
                this.Hide();
                formCaja.ShowDialog();
            }
        }
        //paginacion asincrona metodo
        public async Task<IPagedList<Servicio>> GetPagedListAsync(int pageNumber = 1, int pageSize = 15)
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
            dataGridViewServicios.DataSource = list.ToList();
            lblPageNumber.Text = string.Format("Pagina {0}/{1}", pageNumber, list.PageCount);
        }
        //metodo para limpiar textos de textbox
        private void LimpiarCajasDeTextos()
        {
            txtID.Text = "";
            txtNombreServicio.Text = "";
            txtPrecio.Text = "";
            txtCodigo.Text = "";
        }
        //evento de data grid
        private void dataGridViewServicios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewServicios.Rows[e.RowIndex];
                txtID.Text = row.Cells["ServicioID"].Value.ToString();
                txtNombreServicio.Text = row.Cells["NombreDeServicio"].Value.ToString();
                txtPrecio.Text = row.Cells["Precio"].Value.ToString();
                txtCodigo.Text = row.Cells["COD"].Value.ToString();
            }
        }
        //boton de actualizar o refrescar metodo
        private void mtRefrescar_Click(object sender, EventArgs e)
        {
            CargaDatos();
            LimpiarCajasDeTextos();
        }
        //boton de guardar
        private void mtGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (
                    !String.IsNullOrEmpty(txtNombreServicio.Text.Trim()) &&
                    !String.IsNullOrEmpty(txtPrecio.Text.Trim()) &&
                    !String.IsNullOrEmpty(txtCodigo.Text.Trim())
                    )
                {
                    if (String.IsNullOrEmpty(txtID.Text))
                    {
                        _servicio.NombreDeServicio = txtNombreServicio.Text;
                        _servicio.Precio = double.Parse(txtPrecio.Text.Trim());
                        _servicio.COD = int.Parse(txtCodigo.Text.Trim());
                        _servicioDAL.CrearServicio(_servicio);
                        CargaDatos();
                        LimpiarCajasDeTextos();
                        MetroFramework.MetroMessageBox.Show(this, "Registro de dato exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Por favor usar el boton Refrescar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Completar todos los campos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void mtEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (
                    !String.IsNullOrEmpty(txtNombreServicio.Text.Trim()) &&
                    !String.IsNullOrEmpty(txtPrecio.Text.Trim()) &&
                    !String.IsNullOrEmpty(txtCodigo.Text.Trim()) &&
                    !String.IsNullOrEmpty(txtID.Text.Trim())
                    )
                {
                    if (!String.IsNullOrEmpty(txtID.Text))
                    {
                        _servicio = _servicioDAL.ObtenerServicio(Convert.ToInt32(txtID.Text));
                        if (_servicio.ServicioID == Convert.ToInt32(txtID.Text))
                        {
                            _servicio.NombreDeServicio = txtNombreServicio.Text;
                            _servicio.Precio = double.Parse(txtPrecio.Text.Trim());
                            _servicio.COD = int.Parse(txtCodigo.Text.Trim());
                            _servicioDAL.EditarServicio(_servicio);
                            CargaDatos();
                            LimpiarCajasDeTextos();
                            MetroFramework.MetroMessageBox.Show(this, "Edicion de dato exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MetroFramework.MetroMessageBox.Show(this, "Por favor seleccionar un usuario con identificador", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Por favor usar el boton Refrescar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Completar todos los campos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dataGridViewServicios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewServicios.Rows[e.RowIndex];
                txtID.Text = row.Cells["ServicioID"].Value.ToString();
                txtNombreServicio.Text = row.Cells["NombreDeServicio"].Value.ToString();
                txtPrecio.Text = row.Cells["Precio"].Value.ToString();
                txtCodigo.Text = row.Cells["COD"].Value.ToString();
            }
        }


        private void mtBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                //validacion de campos
                if (
                    !String.IsNullOrEmpty(txtNombreServicio.Text.Trim()) &&
                    !String.IsNullOrEmpty(txtPrecio.Text.Trim()) &&
                    !String.IsNullOrEmpty(txtCodigo.Text.Trim()) &&
                    !String.IsNullOrEmpty(txtID.Text.Trim())
                    )
                {
                    //validacion de campo ID
                    if (!String.IsNullOrEmpty(txtID.Text))
                    {
                        _servicio = _servicioDAL.ObtenerServicio(Convert.ToInt32(txtID.Text));
                        if (_servicio.ServicioID == Convert.ToInt32(txtID.Text))
                        {
                            _servicioDAL.EliminarServicio(_servicio.ServicioID);
                            CargaDatos();
                            LimpiarCajasDeTextos();
                            MetroFramework.MetroMessageBox.Show(this, "Eliminacion de dato exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MetroFramework.MetroMessageBox.Show(this, "Por favor seleccionar un usuario con identificador", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Por favor usar el boton Refrescar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Completar todos los campos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                dataGridViewServicios.DataSource = list.Where(
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
                dataGridViewServicios.DataSource = list.ToList();
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
                dataGridViewServicios.DataSource = list.ToList();
                lblPageNumber.Text = string.Format("Pagina {0}/{1}", pageNumber, list.PageCount);
            }
        }
        //metodo de formulario de carga
        private void ServiciosForm_Load(object sender, EventArgs e)
        {
            //carga lista
            CargaDatos();
        }
    }
}
