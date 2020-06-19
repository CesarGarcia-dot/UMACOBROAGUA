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
    public partial class UsuariosForm : MetroFramework.Forms.MetroForm
    {
        //variables para la paginacion 
        int pageNumber = 1;
        IPagedList<Usuario> list;
        //clases
        Usuario _usuario = new Usuario();
        UsuarioDAL _usuarioDAL = new UsuarioDAL();

        //inicia el formulario
        public UsuariosForm()
        {
            InitializeComponent();
        }

        //paginacion asincrona metodo
        public async Task<IPagedList<Usuario>> GetPagedListAsync(int pageNumber = 1, int pageSize = 10)
        {
            return await Task.Factory.StartNew(() =>
            {
                return _usuarioDAL.ObtenerUsuarios().OrderByDescending(u => u.UsuarioID).ToPagedList(pageNumber, pageSize);
            });
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
        //boton de menu metodo
        private void mtMenu_Click(object sender, EventArgs e)
        {
            using (MenuPrincipalForm formMenu = new MenuPrincipalForm())
            {
                this.Hide();
                formMenu.ShowDialog();
            }
        }
        //metodo de carga de table
        private async void CargaDatos()
        {
            list = await GetPagedListAsync();
            btnPrevious.Enabled = list.HasPreviousPage;
            btnNext.Enabled = list.HasNextPage;
            dataGridViewUsuarios.DataSource = list.ToList();
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
            txtEmail.Text = "";
            txtPassword.Text = "";
        }
        //evento de data grid
        private void dataGridViewUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewUsuarios.Rows[e.RowIndex];
                txtID.Text = row.Cells["UsuarioID"].Value.ToString();
                txtNombre.Text = row.Cells["Nombre"].Value.ToString();
                txtApellido.Text = row.Cells["Apellido"].Value.ToString();
                txtDireccion.Text = row.Cells["Direccion"].Value.ToString();
                txtDepartamento.Text = row.Cells["Departamento"].Value.ToString();
                txtMunicipio.Text = row.Cells["Municipio"].Value.ToString();
                txtDUI.Text = row.Cells["DUI"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtPassword.Text = row.Cells["Password"].Value.ToString();
            }
        }
        //boton de actualizar o refrescar metodo
        private void mtRefrescar_Click(object sender, EventArgs e)
        {
            CargaDatos();
            LimpiarCajasDeTextos();
        }

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
                    !String.IsNullOrEmpty(txtDUI.Text.Trim()) &&
                    !String.IsNullOrEmpty(txtEmail.Text.Trim()) &&
                    !String.IsNullOrEmpty(txtPassword.Text.Trim())
                    )
                {
                    if (String.IsNullOrEmpty(txtID.Text))
                    {
                        _usuario.Nombre = txtNombre.Text;
                        _usuario.Apellido = txtApellido.Text;
                        _usuario.Direccion = txtDireccion.Text;
                        _usuario.Departamento = txtDepartamento.Text;
                        _usuario.Municipio = txtMunicipio.Text;
                        _usuario.DUI = txtDUI.Text;
                        _usuario.Email = txtEmail.Text;
                        _usuario.Password = txtPassword.Text;
                        _usuarioDAL.CrearUsuario(_usuario);
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
                    !String.IsNullOrEmpty(txtEmail.Text.Trim()) &&
                    !String.IsNullOrEmpty(txtPassword.Text.Trim()) &&
                    !String.IsNullOrEmpty(txtID.Text.Trim())
                    )
                {
                    if (!String.IsNullOrEmpty(txtID.Text))
                    {
                        _usuario = _usuarioDAL.ObtenerUsuario(Convert.ToInt32(txtID.Text));
                        if (_usuario.UsuarioID == Convert.ToInt32(txtID.Text))
                        {
                            _usuario.Nombre = txtNombre.Text;
                            _usuario.Apellido = txtApellido.Text;
                            _usuario.Direccion = txtDireccion.Text;
                            _usuario.Departamento = txtDepartamento.Text;
                            _usuario.Municipio = txtMunicipio.Text;
                            _usuario.DUI = txtDUI.Text;
                            _usuario.Email = txtEmail.Text;
                            _usuario.Password = txtPassword.Text;
                            _usuarioDAL.EditarUsuario(_usuario);
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

        private void dataGridViewUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewUsuarios.Rows[e.RowIndex];
                txtID.Text = row.Cells["UsuarioID"].Value.ToString();
                txtNombre.Text = row.Cells["Nombre"].Value.ToString();
                txtApellido.Text = row.Cells["Apellido"].Value.ToString();
                txtDireccion.Text = row.Cells["Direccion"].Value.ToString();
                txtDepartamento.Text = row.Cells["Departamento"].Value.ToString();
                txtMunicipio.Text = row.Cells["Municipio"].Value.ToString();
                txtDUI.Text = row.Cells["DUI"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtPassword.Text = row.Cells["Password"].Value.ToString();
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
                    !String.IsNullOrEmpty(txtEmail.Text.Trim()) &&
                    !String.IsNullOrEmpty(txtPassword.Text.Trim()) &&
                    !String.IsNullOrEmpty(txtID.Text.Trim())
                    )
                {
                    //validacion de campo ID
                    if (!String.IsNullOrEmpty(txtID.Text))
                    {
                        _usuario = _usuarioDAL.ObtenerUsuario(Convert.ToInt32(txtID.Text));
                        if (_usuario.UsuarioID == Convert.ToInt32(txtID.Text))
                        {
                            _usuarioDAL.EliminarUsuario(_usuario.UsuarioID);
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
                dataGridViewUsuarios.DataSource = list.Where(
                s => s.Nombre.ToUpper().Contains(txtBarraBuscar.Text.ToString().ToUpper()) ||
                s.Apellido.ToUpper().Contains(txtBarraBuscar.Text.ToString().ToUpper()) ||
                s.Nombre.ToLower().Contains(txtBarraBuscar.Text.ToString().ToLower()) ||
                s.Apellido.ToLower().Contains(txtBarraBuscar.Text.ToString().ToLower()) ||
                s.DUI.ToUpper().Contains(txtBarraBuscar.Text.ToString().ToUpper()) ||
                 s.DUI.ToLower().Contains(txtBarraBuscar.Text.ToString().ToLower()) ||
                 s.Email.ToUpper().Contains(txtBarraBuscar.Text.ToString().ToUpper()) ||
                 s.Email.ToLower().Contains(txtBarraBuscar.Text.ToString().ToLower())
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
                dataGridViewUsuarios.DataSource = list.ToList();
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
                dataGridViewUsuarios.DataSource = list.ToList();
                lblPageNumber.Text = string.Format("Pagina {0}/{1}", pageNumber, list.PageCount);
            }
        }
        //metodo de formulario de carga
        private void UsuariosForm_Load(object sender, EventArgs e)
        {
            //carga lista
            CargaDatos();
        }
    }
}
