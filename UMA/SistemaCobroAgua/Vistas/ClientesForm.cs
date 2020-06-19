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
    public partial class ClientesForm : MetroFramework.Forms.MetroForm
    {
        //variables para la paginacion 
        int pageNumber = 1;
        IPagedList<Cliente> list;
        //clases
        Cliente _cliente = new Cliente();
        ClienteDAL _clienteDAL = new ClienteDAL();

        //inicia el formulario
        public ClientesForm()
        {
            InitializeComponent();
        }
        //paginacion asincrona metodo
        public async Task<IPagedList<Cliente>> GetPagedListAsync(int pageNumber = 1, int pageSize = 20)
        {
            return await Task.Factory.StartNew(() =>
            {
                return _clienteDAL.ObtenerClientes().OrderByDescending(u => u.ClienteID).ToPagedList(pageNumber, pageSize);
            });
        }

        //boton menu
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
        //metodo de carga de table
        private async void CargaDatos()
        {
            list = await GetPagedListAsync();
            btnPrevious.Enabled = list.HasPreviousPage;
            btnNext.Enabled = list.HasNextPage;
            dataGridViewClientes.DataSource = list.ToList();
            lblPageNumber.Text = string.Format("Pagina {0}/{1}", pageNumber, list.PageCount);
        }
        //metodo para limpiar textos de textbox
        private void LimpiarCajasDeTextos()
        {
            txtID.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDireccion.Text = "";
            txtDepartamento.Text = "";
            txtMunicipio.Text = "";
            txtDUI.Text = "";
        }
        //evento de data grid
        private void dataGridViewClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewClientes.Rows[e.RowIndex];
                txtID.Text = row.Cells["ClienteID"].Value.ToString();
                txtNombre.Text = row.Cells["Nombre"].Value.ToString();
                txtApellido.Text = row.Cells["Apellido"].Value.ToString();
                txtDireccion.Text = row.Cells["Direccion"].Value.ToString();
                txtDepartamento.Text = row.Cells["Departamento"].Value.ToString();
                txtMunicipio.Text = row.Cells["Municipio"].Value.ToString();
                txtDUI.Text = row.Cells["DUI"].Value.ToString();
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
                    !String.IsNullOrEmpty(txtNombre.Text.Trim()) &&
                    !String.IsNullOrEmpty(txtApellido.Text.Trim()) &&
                    !String.IsNullOrEmpty(txtDireccion.Text.Trim()) &&
                    !String.IsNullOrEmpty(txtDepartamento.Text.Trim()) &&
                    !String.IsNullOrEmpty(txtMunicipio.Text.Trim()) &&
                    !String.IsNullOrEmpty(txtDUI.Text.Trim())
                    )
                {
                    if (String.IsNullOrEmpty(txtID.Text))
                    {
                        _cliente.Nombre = txtNombre.Text;
                        _cliente.Apellido = txtApellido.Text;
                        _cliente.Direccion = txtDireccion.Text;
                        _cliente.Departamento = txtDepartamento.Text;
                        _cliente.Municipio = txtMunicipio.Text;
                        _cliente.DUI = txtDUI.Text;                     
                        _clienteDAL.CrearCliente(_cliente);
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
                    !String.IsNullOrEmpty(txtNombre.Text.Trim()) &&
                    !String.IsNullOrEmpty(txtApellido.Text.Trim()) &&
                    !String.IsNullOrEmpty(txtDireccion.Text.Trim()) &&
                    !String.IsNullOrEmpty(txtDepartamento.Text.Trim()) &&
                    !String.IsNullOrEmpty(txtMunicipio.Text.Trim()) &&
                    !String.IsNullOrEmpty(txtDUI.Text.Trim()) &&                    
                    !String.IsNullOrEmpty(txtID.Text.Trim())
                    )
                {
                    if (!String.IsNullOrEmpty(txtID.Text))
                    {
                        _cliente = _clienteDAL.ObtenerCliente(Convert.ToInt32(txtID.Text));
                        if (_cliente.ClienteID == Convert.ToInt32(txtID.Text))
                        {
                            _cliente.Nombre = txtNombre.Text;
                            _cliente.Apellido = txtApellido.Text;
                            _cliente.Direccion = txtDireccion.Text;
                            _cliente.Departamento = txtDepartamento.Text;
                            _cliente.Municipio = txtMunicipio.Text;
                            _cliente.DUI = txtDUI.Text;
                            _clienteDAL.EditarCliente(_cliente);
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

        private void dataGridViewClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewClientes.Rows[e.RowIndex];
                txtID.Text = row.Cells["ClienteID"].Value.ToString();
                txtNombre.Text = row.Cells["Nombre"].Value.ToString();
                txtApellido.Text = row.Cells["Apellido"].Value.ToString();
                txtDireccion.Text = row.Cells["Direccion"].Value.ToString();
                txtDepartamento.Text = row.Cells["Departamento"].Value.ToString();
                txtMunicipio.Text = row.Cells["Municipio"].Value.ToString();
                txtDUI.Text = row.Cells["DUI"].Value.ToString();
            }
        }


        private void mtBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                //validacion de campos
                if (
                    !String.IsNullOrEmpty(txtNombre.Text.Trim()) &&
                    !String.IsNullOrEmpty(txtApellido.Text.Trim()) &&
                    !String.IsNullOrEmpty(txtDireccion.Text.Trim()) &&
                    !String.IsNullOrEmpty(txtDepartamento.Text.Trim()) &&
                    !String.IsNullOrEmpty(txtMunicipio.Text.Trim()) &&
                    !String.IsNullOrEmpty(txtDUI.Text.Trim()) &&
                    !String.IsNullOrEmpty(txtID.Text.Trim())
                    )
                {
                    //validacion de campo ID
                    if (!String.IsNullOrEmpty(txtID.Text))
                    {
                        _cliente = _clienteDAL.ObtenerCliente(Convert.ToInt32(txtID.Text));
                        if (_cliente.ClienteID == Convert.ToInt32(txtID.Text))
                        {
                            _clienteDAL.EliminarCliente(_cliente.ClienteID);
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
                dataGridViewClientes.DataSource = list.Where(
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
                dataGridViewClientes.DataSource = list.ToList();
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
                dataGridViewClientes.DataSource = list.ToList();
                lblPageNumber.Text = string.Format("Pagina {0}/{1}", pageNumber, list.PageCount);
            }
        }
        //metodo de formulario de carga
        private void ClientesForm_Load(object sender, EventArgs e)
        {
            //carga lista
            CargaDatos();
        }

    }
}
