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
    public partial class TarifasResidencialesForm : MetroFramework.Forms.MetroForm
    {
        //variables para la paginacion 
        int pageNumber = 1;
        IPagedList<TarifaResidencial> list;
        //clases
        TarifaResidencial _tarifaResidencial = new TarifaResidencial();
        TarifaResidencialDAL _tarifaResidencialDAL = new TarifaResidencialDAL();

        //inicia el formulario
        public TarifasResidencialesForm()
        {
            InitializeComponent();
        }
        //boton para ir al menu
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
        public async Task<IPagedList<TarifaResidencial>> GetPagedListAsync(int pageNumber = 1, int pageSize = 15)
        {
            return await Task.Factory.StartNew(() =>
            {
                return _tarifaResidencialDAL.ObtenerTarifaResidenciales().OrderByDescending(u => u.TarifaResidencialID).ToPagedList(pageNumber, pageSize);
            });
        }
        //metodo de carga de table
        private async void CargaDatos()
        {
            list = await GetPagedListAsync();
            btnPrevious.Enabled = list.HasPreviousPage;
            btnNext.Enabled = list.HasNextPage;
            dataGridViewTarifasResidenciales.DataSource = list.ToList();
            lblPageNumber.Text = string.Format("Pagina {0}/{1}", pageNumber, list.PageCount);
        }
        //metodo para limpiar textos de textbox
        private void LimpiarCajasDeTextos()
        {
            txtID.Text = "";
            txtRangoConsumoM3.Text = "";
            txtTarifaAcueductoM3.Text = "";
            txtTarifaAlcantarillado.Text = "";
        }
        //evento de data grid
        private void dataGridViewTarifasResidenciales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewTarifasResidenciales.Rows[e.RowIndex];
                txtID.Text = row.Cells["TarifaResidencialID"].Value.ToString();
                txtRangoConsumoM3.Text = row.Cells["RangosDeConsumoEnMetrosCubicos"].Value.ToString();
                txtTarifaAcueductoM3.Text = row.Cells["TarifaAcueductoPrecioPorM3"].Value.ToString();
                txtTarifaAlcantarillado.Text = row.Cells["TarifasAlcantarillado"].Value.ToString();
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
                    !String.IsNullOrEmpty(txtRangoConsumoM3.Text.Trim()) &&
                    !String.IsNullOrEmpty(txtTarifaAcueductoM3.Text.Trim()) &&
                    !String.IsNullOrEmpty(txtTarifaAlcantarillado.Text.Trim())
                    )
                {
                    if (String.IsNullOrEmpty(txtID.Text))
                    {
                        _tarifaResidencial.RangosDeConsumoEnMetrosCubicos = txtRangoConsumoM3.Text;
                        _tarifaResidencial.TarifaAcueductoPrecioPorM3 = double.Parse(txtTarifaAcueductoM3.Text.Trim());
                        _tarifaResidencial.TarifasAlcantarillado = double.Parse(txtTarifaAlcantarillado.Text.Trim());
                        _tarifaResidencialDAL.CrearTarifaResidencial(_tarifaResidencial);
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
                   !String.IsNullOrEmpty(txtRangoConsumoM3.Text.Trim()) &&
                    !String.IsNullOrEmpty(txtTarifaAcueductoM3.Text.Trim()) &&
                    !String.IsNullOrEmpty(txtTarifaAlcantarillado.Text.Trim()) &&
                    !String.IsNullOrEmpty(txtID.Text.Trim())
                    )
                {
                    if (!String.IsNullOrEmpty(txtID.Text))
                    {
                        _tarifaResidencial = _tarifaResidencialDAL.ObtenerTarifaResidencial(Convert.ToInt32(txtID.Text));
                        if (_tarifaResidencial.TarifaResidencialID == Convert.ToInt32(txtID.Text))
                        {
                            _tarifaResidencial.RangosDeConsumoEnMetrosCubicos = txtRangoConsumoM3.Text;
                            _tarifaResidencial.TarifaAcueductoPrecioPorM3 = double.Parse(txtTarifaAcueductoM3.Text.Trim());
                            _tarifaResidencial.TarifasAlcantarillado = double.Parse(txtTarifaAlcantarillado.Text.Trim());
                            _tarifaResidencialDAL.EditarTarifaResidencial(_tarifaResidencial);
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

        private void dataGridViewTarifasResidenciales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewTarifasResidenciales.Rows[e.RowIndex];
                txtID.Text = row.Cells["TarifaResidencialID"].Value.ToString();
                txtRangoConsumoM3.Text = row.Cells["RangosDeConsumoEnMetrosCubicos"].Value.ToString();
                txtTarifaAcueductoM3.Text = row.Cells["TarifaAcueductoPrecioPorM3"].Value.ToString();
                txtTarifaAlcantarillado.Text = row.Cells["TarifasAlcantarillado"].Value.ToString();
            }
        }


        private void mtBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                //validacion de campos
                if (
                    !String.IsNullOrEmpty(txtRangoConsumoM3.Text.Trim()) &&
                    !String.IsNullOrEmpty(txtTarifaAcueductoM3.Text.Trim()) &&
                    !String.IsNullOrEmpty(txtTarifaAlcantarillado.Text.Trim()) &&
                    !String.IsNullOrEmpty(txtID.Text.Trim())
                    )
                {
                    //validacion de campo ID
                    if (!String.IsNullOrEmpty(txtID.Text))
                    {
                        _tarifaResidencial = _tarifaResidencialDAL.ObtenerTarifaResidencial(Convert.ToInt32(txtID.Text));
                        if (_tarifaResidencial.TarifaResidencialID == Convert.ToInt32(txtID.Text))
                        {
                            _tarifaResidencialDAL.EliminarTarifaResidencial(_tarifaResidencial.TarifaResidencialID);
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
                dataGridViewTarifasResidenciales.DataSource = list.Where(
                s => s.RangosDeConsumoEnMetrosCubicos.ToUpper().Contains(txtBarraBuscar.Text.ToUpper()) ||
                s.RangosDeConsumoEnMetrosCubicos.ToLower().Contains(txtBarraBuscar.Text.ToLower())
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
                dataGridViewTarifasResidenciales.DataSource = list.ToList();
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
                dataGridViewTarifasResidenciales.DataSource = list.ToList();
                lblPageNumber.Text = string.Format("Pagina {0}/{1}", pageNumber, list.PageCount);
            }
        }
        //metodo de formulario de carga
        private void TarifaResidencialesForm_Load(object sender, EventArgs e)
        {
            //carga lista
            CargaDatos();
        }
    }
}
