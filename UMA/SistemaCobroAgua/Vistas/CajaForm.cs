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
    public partial class CajaForm : MetroFramework.Forms.MetroForm
    {
        AgregarServicioForm _buscadorServicioForm = new AgregarServicioForm();
        //clases
        CabezeraFactura _cabezeraFactura = new CabezeraFactura();
        SubCabezeraFactura _subCabezeraFactura = new SubCabezeraFactura();
        DetalleFactura _detalleFactura = new DetalleFactura();
        PieFactura _pieFactura = new PieFactura();
        Factura _factura = new Factura();
        CabezeraFacturaDAL _cabezeraFacturaDAL = new CabezeraFacturaDAL();
        SubCabezeraFacturaDAL _subCabezeraFacturaDAL = new SubCabezeraFacturaDAL();
        DetalleFacturaDAL _detalleFacturaDAL = new DetalleFacturaDAL();
        PieFacturaDAL _pieFacturaDAL = new PieFacturaDAL();
        FacturaDAL _facturaDAL = new FacturaDAL();
        //lista vacia
        List<DetalleFactura> _listaVacia = new List<DetalleFactura>();
        public CajaForm()
        {
            InitializeComponent();
        }

        private void mtMenu_Click(object sender, EventArgs e)
        {
            using (MenuPrincipalForm formMenu = new MenuPrincipalForm())
            {
                this.Hide();
                formMenu.ShowDialog();
            }
        }

        //metodo de carga de table
        private async void CargaDatos(int id)
        {
            dataGridViewDetalleFactura.DataSource = _detalleFacturaDAL.ObtenerDetalleFactura(id).ToList();
        }
        private void CajaForm_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCabezeraFacturaID.Text))
            {
                CargaDatos(int.Parse(txtCabezeraFacturaID.Text));
            }
            else
            {
                dataGridViewDetalleFactura.DataSource = _listaVacia;
            }
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            using (BuscadorClienteForm _formClienteBuscador = new BuscadorClienteForm())
            {
                this.Hide();
                _formClienteBuscador.ShowDialog();
            }
        }

        //metodo para limpiar textos de textbox
        private void LimpiarCajasDeTextos()
        {
            txtCabezeraFacturaID.Text = "";
            txtClienteID.Text = "";
            txtSubCabezeraID.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtNRC.Text = "";
            txtNIT.Text = "";
            txtGiro.Text = "";
            txtNumeroDeCuenta.Text = "";
            txtNumeroDeFactura.Text = "";
            txtRegion.Text = "";
            txtRuta.Text = "";
            txtGrupo.Text = "";
            mtDateDiasFacturados.Value = DateTime.Now;
            mtDateFaturadoDesde.Value = DateTime.Now;
            mtDateFaturadoHasta.Value = DateTime.Now;
            mtDateFechaEmision.Value = DateTime.Now;
            mtDateMesFaturado.Value = DateTime.Now;
            mdtUltimoDiasDePago.Value = DateTime.Now;
            txtSubTotal.Text = "";
            txtTotal.Text = "";
        }

        private void btnDiasFacturados_Click(object sender, EventArgs e)
        {
            try
            {
                if (
                    !String.IsNullOrEmpty(txtNombre.Text.Trim()) &&
                    !String.IsNullOrEmpty(txtApellido.Text.Trim()) &&
                    !String.IsNullOrEmpty(txtClienteID.Text.Trim()) &&
                    !String.IsNullOrEmpty(txtNumeroDeFactura.Text.Trim()) &&
                    !String.IsNullOrEmpty(txtNIT.Text.Trim()) &&
                    !String.IsNullOrEmpty(txtNumeroDeCuenta.Text.Trim()) &&
                    !String.IsNullOrEmpty(txtGiro.Text.Trim()) &&
                    !String.IsNullOrEmpty(txtNRC.Text.Trim())
                    )
                {
                    _cabezeraFactura.ClienteID = int.Parse(txtClienteID.Text.ToString());
                    _cabezeraFactura.NumeroDeFactura = txtNumeroDeFactura.Text;
                    _cabezeraFactura.NumeroDeCuenta = txtNumeroDeCuenta.Text;
                    _cabezeraFactura.Fecha = DateTime.Now;
                    _cabezeraFactura.NIT = txtNIT.Text;
                    _cabezeraFactura.NRC = txtNRC.Text;
                    _cabezeraFactura.Giro = txtGiro.Text;
                    _cabezeraFacturaDAL.CrearCabezeraFactura(_cabezeraFactura);
                    DeshabilitarCajasTextosCabezera();
                    var resultNumeroFactura = _cabezeraFacturaDAL.BuscarCabezeraNumeroFactura(_cabezeraFactura);
                    if (!string.IsNullOrEmpty(resultNumeroFactura.NumeroDeFactura))
                    {
                        txtCabezeraFacturaID.Text = resultNumeroFactura.CabezeraFacturaID.ToString();
                        if (
                    !String.IsNullOrEmpty(txtRegion.Text.Trim()) &&
                    !String.IsNullOrEmpty(txtGrupo.Text.Trim()) &&
                    !String.IsNullOrEmpty(txtRuta.Text.Trim())
                    )
                        {
                            _subCabezeraFactura.CabezeraFacturaID = resultNumeroFactura.CabezeraFacturaID;
                            _subCabezeraFactura.FacturadoDesde = mtDateFaturadoDesde.Value;
                            _subCabezeraFactura.FacturadoHasta = mtDateFaturadoHasta.Value;
                            _subCabezeraFactura.DiasFacturados = mtDateDiasFacturados.Value;
                            _subCabezeraFactura.MesFacturado = mtDateDiasFacturados.Value;
                            _subCabezeraFactura.FechaEmision = mtDateFechaEmision.Value;
                            _subCabezeraFactura.Region = txtRegion.Text;
                            _subCabezeraFactura.Grupo = txtGrupo.Text;
                            _subCabezeraFactura.Ruta = txtRuta.Text;
                            _subCabezeraFacturaDAL.CrearSubCabezeraFactura(_subCabezeraFactura);
                            var resultNumeroCabezeraID = _subCabezeraFacturaDAL.EncontrarCabezera(_subCabezeraFactura);
                            txtSubCabezeraID.Text = resultNumeroCabezeraID.SubCabezeraFacturaID.ToString();
                            DeshabilitarCajasTextosSubCabezera();
                        }
                        else
                        {
                            MetroFramework.MetroMessageBox.Show(this, "Completar todos los campos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Completar todos los campos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        //deshabilitacion
        private void DeshabilitarCajasTextosCabezera()
        {
            txtNRC.Enabled = false;
            txtNIT.Enabled = false;
            txtGiro.Enabled = false;
            txtNumeroDeCuenta.Enabled = false;
            txtNumeroDeFactura.Enabled = false;
        }
        private void DeshabilitarCajasTextosSubCabezera()
        {
            mtDateDiasFacturados.Enabled = false;
            mtDateFaturadoDesde.Enabled = false;
            mtDateFaturadoHasta.Enabled = false;
            mtDateFechaEmision.Enabled = false;
            mtDateMesFaturado.Enabled = false;
            txtRegion.Enabled = false;
            txtRuta.Enabled = false;
            txtGrupo.Enabled = false;
        }

        private void btnAgregarServicio_Click(object sender, EventArgs e)
        {
                _buscadorServicioForm.ShowDialog();
                this.Hide();        
        }
    }
}
