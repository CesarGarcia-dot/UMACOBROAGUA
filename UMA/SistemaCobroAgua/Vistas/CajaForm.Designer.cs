namespace SistemaCobroAgua.Vistas
{
    partial class CajaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewDetalleFactura = new System.Windows.Forms.DataGridView();
            this.txtNumeroDeCuenta = new MetroFramework.Controls.MetroTextBox();
            this.txtGiro = new MetroFramework.Controls.MetroTextBox();
            this.txtNumeroDeFactura = new MetroFramework.Controls.MetroTextBox();
            this.txtClienteID = new MetroFramework.Controls.MetroTextBox();
            this.txtNRC = new MetroFramework.Controls.MetroTextBox();
            this.txtCabezeraFacturaID = new MetroFramework.Controls.MetroTextBox();
            this.txtRuta = new MetroFramework.Controls.MetroTextBox();
            this.txtGrupo = new MetroFramework.Controls.MetroTextBox();
            this.txtRegion = new MetroFramework.Controls.MetroTextBox();
            this.txtNIT = new MetroFramework.Controls.MetroTextBox();
            this.txtSubTotal = new MetroFramework.Controls.MetroTextBox();
            this.btnAgregarCliente = new MetroFramework.Controls.MetroButton();
            this.btnDiasFacturados = new MetroFramework.Controls.MetroButton();
            this.txtTotal = new MetroFramework.Controls.MetroTextBox();
            this.mdtUltimoDiasDePago = new MetroFramework.Controls.MetroDateTime();
            this.lblDiasDePago = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.txtSubCabezeraID = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel18 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel19 = new MetroFramework.Controls.MetroLabel();
            this.txtNombre = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel20 = new MetroFramework.Controls.MetroLabel();
            this.txtApellido = new MetroFramework.Controls.MetroTextBox();
            this.mtDateMesFaturado = new MetroFramework.Controls.MetroDateTime();
            this.mtDateFaturadoDesde = new MetroFramework.Controls.MetroDateTime();
            this.mtDateFaturadoHasta = new MetroFramework.Controls.MetroDateTime();
            this.mtDateDiasFacturados = new MetroFramework.Controls.MetroDateTime();
            this.mtDateFechaEmision = new MetroFramework.Controls.MetroDateTime();
            this.btnGenerarFactura = new MetroFramework.Controls.MetroTile();
            this.mtGuardar = new MetroFramework.Controls.MetroTile();
            this.mtMenu = new MetroFramework.Controls.MetroTile();
            this.btnMenosServicio = new MetroFramework.Controls.MetroTile();
            this.btnAgregarServicio = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetalleFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDetalleFactura
            // 
            this.dataGridViewDetalleFactura.AllowUserToAddRows = false;
            this.dataGridViewDetalleFactura.AllowUserToDeleteRows = false;
            this.dataGridViewDetalleFactura.AllowUserToOrderColumns = true;
            this.dataGridViewDetalleFactura.AllowUserToResizeRows = false;
            this.dataGridViewDetalleFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDetalleFactura.Location = new System.Drawing.Point(40, 305);
            this.dataGridViewDetalleFactura.MultiSelect = false;
            this.dataGridViewDetalleFactura.Name = "dataGridViewDetalleFactura";
            this.dataGridViewDetalleFactura.ReadOnly = true;
            this.dataGridViewDetalleFactura.Size = new System.Drawing.Size(568, 265);
            this.dataGridViewDetalleFactura.TabIndex = 1;
            // 
            // txtNumeroDeCuenta
            // 
            // 
            // 
            // 
            this.txtNumeroDeCuenta.CustomButton.Image = null;
            this.txtNumeroDeCuenta.CustomButton.Location = new System.Drawing.Point(165, 1);
            this.txtNumeroDeCuenta.CustomButton.Name = "";
            this.txtNumeroDeCuenta.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtNumeroDeCuenta.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNumeroDeCuenta.CustomButton.TabIndex = 1;
            this.txtNumeroDeCuenta.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNumeroDeCuenta.CustomButton.UseSelectable = true;
            this.txtNumeroDeCuenta.CustomButton.Visible = false;
            this.txtNumeroDeCuenta.Lines = new string[0];
            this.txtNumeroDeCuenta.Location = new System.Drawing.Point(248, 154);
            this.txtNumeroDeCuenta.MaxLength = 32767;
            this.txtNumeroDeCuenta.Name = "txtNumeroDeCuenta";
            this.txtNumeroDeCuenta.PasswordChar = '\0';
            this.txtNumeroDeCuenta.PromptText = "Numero De Cuenta";
            this.txtNumeroDeCuenta.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNumeroDeCuenta.SelectedText = "";
            this.txtNumeroDeCuenta.SelectionLength = 0;
            this.txtNumeroDeCuenta.SelectionStart = 0;
            this.txtNumeroDeCuenta.ShortcutsEnabled = true;
            this.txtNumeroDeCuenta.Size = new System.Drawing.Size(193, 29);
            this.txtNumeroDeCuenta.TabIndex = 19;
            this.txtNumeroDeCuenta.UseSelectable = true;
            this.txtNumeroDeCuenta.WaterMark = "Numero De Cuenta";
            this.txtNumeroDeCuenta.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNumeroDeCuenta.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtGiro
            // 
            // 
            // 
            // 
            this.txtGiro.CustomButton.Image = null;
            this.txtGiro.CustomButton.Location = new System.Drawing.Point(165, 1);
            this.txtGiro.CustomButton.Name = "";
            this.txtGiro.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtGiro.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtGiro.CustomButton.TabIndex = 1;
            this.txtGiro.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtGiro.CustomButton.UseSelectable = true;
            this.txtGiro.CustomButton.Visible = false;
            this.txtGiro.Lines = new string[0];
            this.txtGiro.Location = new System.Drawing.Point(40, 154);
            this.txtGiro.MaxLength = 32767;
            this.txtGiro.Name = "txtGiro";
            this.txtGiro.PasswordChar = '\0';
            this.txtGiro.PromptText = "Giro";
            this.txtGiro.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtGiro.SelectedText = "";
            this.txtGiro.SelectionLength = 0;
            this.txtGiro.SelectionStart = 0;
            this.txtGiro.ShortcutsEnabled = true;
            this.txtGiro.Size = new System.Drawing.Size(193, 29);
            this.txtGiro.TabIndex = 20;
            this.txtGiro.UseSelectable = true;
            this.txtGiro.WaterMark = "Giro";
            this.txtGiro.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtGiro.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtNumeroDeFactura
            // 
            // 
            // 
            // 
            this.txtNumeroDeFactura.CustomButton.Image = null;
            this.txtNumeroDeFactura.CustomButton.Location = new System.Drawing.Point(165, 1);
            this.txtNumeroDeFactura.CustomButton.Name = "";
            this.txtNumeroDeFactura.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtNumeroDeFactura.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNumeroDeFactura.CustomButton.TabIndex = 1;
            this.txtNumeroDeFactura.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNumeroDeFactura.CustomButton.UseSelectable = true;
            this.txtNumeroDeFactura.CustomButton.Visible = false;
            this.txtNumeroDeFactura.Lines = new string[0];
            this.txtNumeroDeFactura.Location = new System.Drawing.Point(461, 154);
            this.txtNumeroDeFactura.MaxLength = 32767;
            this.txtNumeroDeFactura.Name = "txtNumeroDeFactura";
            this.txtNumeroDeFactura.PasswordChar = '\0';
            this.txtNumeroDeFactura.PromptText = "Numero De Factura";
            this.txtNumeroDeFactura.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNumeroDeFactura.SelectedText = "";
            this.txtNumeroDeFactura.SelectionLength = 0;
            this.txtNumeroDeFactura.SelectionStart = 0;
            this.txtNumeroDeFactura.ShortcutsEnabled = true;
            this.txtNumeroDeFactura.Size = new System.Drawing.Size(193, 29);
            this.txtNumeroDeFactura.TabIndex = 21;
            this.txtNumeroDeFactura.UseSelectable = true;
            this.txtNumeroDeFactura.WaterMark = "Numero De Factura";
            this.txtNumeroDeFactura.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNumeroDeFactura.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtClienteID
            // 
            // 
            // 
            // 
            this.txtClienteID.CustomButton.Image = null;
            this.txtClienteID.CustomButton.Location = new System.Drawing.Point(166, 1);
            this.txtClienteID.CustomButton.Name = "";
            this.txtClienteID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtClienteID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtClienteID.CustomButton.TabIndex = 1;
            this.txtClienteID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtClienteID.CustomButton.UseSelectable = true;
            this.txtClienteID.CustomButton.Visible = false;
            this.txtClienteID.Enabled = false;
            this.txtClienteID.Lines = new string[0];
            this.txtClienteID.Location = new System.Drawing.Point(380, 657);
            this.txtClienteID.MaxLength = 32767;
            this.txtClienteID.Name = "txtClienteID";
            this.txtClienteID.PasswordChar = '\0';
            this.txtClienteID.PromptText = "ClienteID";
            this.txtClienteID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtClienteID.SelectedText = "";
            this.txtClienteID.SelectionLength = 0;
            this.txtClienteID.SelectionStart = 0;
            this.txtClienteID.ShortcutsEnabled = true;
            this.txtClienteID.Size = new System.Drawing.Size(188, 23);
            this.txtClienteID.TabIndex = 22;
            this.txtClienteID.TabStop = false;
            this.txtClienteID.UseSelectable = true;
            this.txtClienteID.Visible = false;
            this.txtClienteID.WaterMark = "ClienteID";
            this.txtClienteID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtClienteID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtNRC
            // 
            // 
            // 
            // 
            this.txtNRC.CustomButton.Image = null;
            this.txtNRC.CustomButton.Location = new System.Drawing.Point(165, 1);
            this.txtNRC.CustomButton.Name = "";
            this.txtNRC.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtNRC.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNRC.CustomButton.TabIndex = 1;
            this.txtNRC.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNRC.CustomButton.UseSelectable = true;
            this.txtNRC.CustomButton.Visible = false;
            this.txtNRC.Lines = new string[0];
            this.txtNRC.Location = new System.Drawing.Point(461, 102);
            this.txtNRC.MaxLength = 32767;
            this.txtNRC.Name = "txtNRC";
            this.txtNRC.PasswordChar = '\0';
            this.txtNRC.PromptText = "NRC";
            this.txtNRC.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNRC.SelectedText = "";
            this.txtNRC.SelectionLength = 0;
            this.txtNRC.SelectionStart = 0;
            this.txtNRC.ShortcutsEnabled = true;
            this.txtNRC.Size = new System.Drawing.Size(193, 29);
            this.txtNRC.TabIndex = 23;
            this.txtNRC.UseSelectable = true;
            this.txtNRC.WaterMark = "NRC";
            this.txtNRC.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNRC.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtCabezeraFacturaID
            // 
            // 
            // 
            // 
            this.txtCabezeraFacturaID.CustomButton.Image = null;
            this.txtCabezeraFacturaID.CustomButton.Location = new System.Drawing.Point(166, 1);
            this.txtCabezeraFacturaID.CustomButton.Name = "";
            this.txtCabezeraFacturaID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCabezeraFacturaID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCabezeraFacturaID.CustomButton.TabIndex = 1;
            this.txtCabezeraFacturaID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCabezeraFacturaID.CustomButton.UseSelectable = true;
            this.txtCabezeraFacturaID.CustomButton.Visible = false;
            this.txtCabezeraFacturaID.Enabled = false;
            this.txtCabezeraFacturaID.Lines = new string[0];
            this.txtCabezeraFacturaID.Location = new System.Drawing.Point(380, 599);
            this.txtCabezeraFacturaID.MaxLength = 32767;
            this.txtCabezeraFacturaID.Name = "txtCabezeraFacturaID";
            this.txtCabezeraFacturaID.PasswordChar = '\0';
            this.txtCabezeraFacturaID.PromptText = "CabezeraFacturaID";
            this.txtCabezeraFacturaID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCabezeraFacturaID.SelectedText = "";
            this.txtCabezeraFacturaID.SelectionLength = 0;
            this.txtCabezeraFacturaID.SelectionStart = 0;
            this.txtCabezeraFacturaID.ShortcutsEnabled = true;
            this.txtCabezeraFacturaID.Size = new System.Drawing.Size(188, 23);
            this.txtCabezeraFacturaID.TabIndex = 24;
            this.txtCabezeraFacturaID.UseSelectable = true;
            this.txtCabezeraFacturaID.Visible = false;
            this.txtCabezeraFacturaID.WaterMark = "CabezeraFacturaID";
            this.txtCabezeraFacturaID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCabezeraFacturaID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtRuta
            // 
            // 
            // 
            // 
            this.txtRuta.CustomButton.Image = null;
            this.txtRuta.CustomButton.Location = new System.Drawing.Point(165, 1);
            this.txtRuta.CustomButton.Name = "";
            this.txtRuta.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtRuta.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRuta.CustomButton.TabIndex = 1;
            this.txtRuta.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRuta.CustomButton.UseSelectable = true;
            this.txtRuta.CustomButton.Visible = false;
            this.txtRuta.Lines = new string[0];
            this.txtRuta.Location = new System.Drawing.Point(461, 261);
            this.txtRuta.MaxLength = 32767;
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.PasswordChar = '\0';
            this.txtRuta.PromptText = "Ruta";
            this.txtRuta.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRuta.SelectedText = "";
            this.txtRuta.SelectionLength = 0;
            this.txtRuta.SelectionStart = 0;
            this.txtRuta.ShortcutsEnabled = true;
            this.txtRuta.Size = new System.Drawing.Size(193, 29);
            this.txtRuta.TabIndex = 30;
            this.txtRuta.UseSelectable = true;
            this.txtRuta.WaterMark = "Ruta";
            this.txtRuta.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRuta.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtGrupo
            // 
            // 
            // 
            // 
            this.txtGrupo.CustomButton.Image = null;
            this.txtGrupo.CustomButton.Location = new System.Drawing.Point(165, 1);
            this.txtGrupo.CustomButton.Name = "";
            this.txtGrupo.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtGrupo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtGrupo.CustomButton.TabIndex = 1;
            this.txtGrupo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtGrupo.CustomButton.UseSelectable = true;
            this.txtGrupo.CustomButton.Visible = false;
            this.txtGrupo.Lines = new string[0];
            this.txtGrupo.Location = new System.Drawing.Point(248, 261);
            this.txtGrupo.MaxLength = 32767;
            this.txtGrupo.Name = "txtGrupo";
            this.txtGrupo.PasswordChar = '\0';
            this.txtGrupo.PromptText = "Grupo";
            this.txtGrupo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtGrupo.SelectedText = "";
            this.txtGrupo.SelectionLength = 0;
            this.txtGrupo.SelectionStart = 0;
            this.txtGrupo.ShortcutsEnabled = true;
            this.txtGrupo.Size = new System.Drawing.Size(193, 29);
            this.txtGrupo.TabIndex = 28;
            this.txtGrupo.UseSelectable = true;
            this.txtGrupo.WaterMark = "Grupo";
            this.txtGrupo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtGrupo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtRegion
            // 
            // 
            // 
            // 
            this.txtRegion.CustomButton.Image = null;
            this.txtRegion.CustomButton.Location = new System.Drawing.Point(165, 1);
            this.txtRegion.CustomButton.Name = "";
            this.txtRegion.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtRegion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRegion.CustomButton.TabIndex = 1;
            this.txtRegion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRegion.CustomButton.UseSelectable = true;
            this.txtRegion.CustomButton.Visible = false;
            this.txtRegion.Lines = new string[0];
            this.txtRegion.Location = new System.Drawing.Point(40, 261);
            this.txtRegion.MaxLength = 32767;
            this.txtRegion.Name = "txtRegion";
            this.txtRegion.PasswordChar = '\0';
            this.txtRegion.PromptText = "Region";
            this.txtRegion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRegion.SelectedText = "";
            this.txtRegion.SelectionLength = 0;
            this.txtRegion.SelectionStart = 0;
            this.txtRegion.ShortcutsEnabled = true;
            this.txtRegion.Size = new System.Drawing.Size(193, 29);
            this.txtRegion.TabIndex = 26;
            this.txtRegion.UseSelectable = true;
            this.txtRegion.WaterMark = "Region";
            this.txtRegion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRegion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtNIT
            // 
            // 
            // 
            // 
            this.txtNIT.CustomButton.Image = null;
            this.txtNIT.CustomButton.Location = new System.Drawing.Point(165, 1);
            this.txtNIT.CustomButton.Name = "";
            this.txtNIT.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtNIT.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNIT.CustomButton.TabIndex = 1;
            this.txtNIT.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNIT.CustomButton.UseSelectable = true;
            this.txtNIT.CustomButton.Visible = false;
            this.txtNIT.Lines = new string[0];
            this.txtNIT.Location = new System.Drawing.Point(667, 102);
            this.txtNIT.MaxLength = 32767;
            this.txtNIT.Name = "txtNIT";
            this.txtNIT.PasswordChar = '\0';
            this.txtNIT.PromptText = "NIT";
            this.txtNIT.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNIT.SelectedText = "";
            this.txtNIT.SelectionLength = 0;
            this.txtNIT.SelectionStart = 0;
            this.txtNIT.ShortcutsEnabled = true;
            this.txtNIT.Size = new System.Drawing.Size(193, 29);
            this.txtNIT.TabIndex = 33;
            this.txtNIT.UseSelectable = true;
            this.txtNIT.WaterMark = "NIT";
            this.txtNIT.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNIT.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtSubTotal
            // 
            // 
            // 
            // 
            this.txtSubTotal.CustomButton.Image = null;
            this.txtSubTotal.CustomButton.Location = new System.Drawing.Point(111, 1);
            this.txtSubTotal.CustomButton.Name = "";
            this.txtSubTotal.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.txtSubTotal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSubTotal.CustomButton.TabIndex = 1;
            this.txtSubTotal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSubTotal.CustomButton.UseSelectable = true;
            this.txtSubTotal.CustomButton.Visible = false;
            this.txtSubTotal.Enabled = false;
            this.txtSubTotal.Lines = new string[0];
            this.txtSubTotal.Location = new System.Drawing.Point(742, 305);
            this.txtSubTotal.MaxLength = 32767;
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.PasswordChar = '\0';
            this.txtSubTotal.PromptText = "Sub-Total";
            this.txtSubTotal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSubTotal.SelectedText = "";
            this.txtSubTotal.SelectionLength = 0;
            this.txtSubTotal.SelectionStart = 0;
            this.txtSubTotal.ShortcutsEnabled = true;
            this.txtSubTotal.Size = new System.Drawing.Size(129, 19);
            this.txtSubTotal.TabIndex = 34;
            this.txtSubTotal.UseSelectable = true;
            this.txtSubTotal.WaterMark = "Sub-Total";
            this.txtSubTotal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSubTotal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.Location = new System.Drawing.Point(930, 108);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(146, 23);
            this.btnAgregarCliente.TabIndex = 35;
            this.btnAgregarCliente.Text = "Agregar Cliente";
            this.btnAgregarCliente.UseSelectable = true;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // btnDiasFacturados
            // 
            this.btnDiasFacturados.Location = new System.Drawing.Point(930, 154);
            this.btnDiasFacturados.Name = "btnDiasFacturados";
            this.btnDiasFacturados.Size = new System.Drawing.Size(146, 23);
            this.btnDiasFacturados.TabIndex = 36;
            this.btnDiasFacturados.Text = "Agregar Dias Facturados";
            this.btnDiasFacturados.UseSelectable = true;
            this.btnDiasFacturados.Click += new System.EventHandler(this.btnDiasFacturados_Click);
            // 
            // txtTotal
            // 
            // 
            // 
            // 
            this.txtTotal.CustomButton.Image = null;
            this.txtTotal.CustomButton.Location = new System.Drawing.Point(111, 1);
            this.txtTotal.CustomButton.Name = "";
            this.txtTotal.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.txtTotal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTotal.CustomButton.TabIndex = 1;
            this.txtTotal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTotal.CustomButton.UseSelectable = true;
            this.txtTotal.CustomButton.Visible = false;
            this.txtTotal.Enabled = false;
            this.txtTotal.Lines = new string[0];
            this.txtTotal.Location = new System.Drawing.Point(742, 354);
            this.txtTotal.MaxLength = 32767;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.PasswordChar = '\0';
            this.txtTotal.PromptText = "Total";
            this.txtTotal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTotal.SelectedText = "";
            this.txtTotal.SelectionLength = 0;
            this.txtTotal.SelectionStart = 0;
            this.txtTotal.ShortcutsEnabled = true;
            this.txtTotal.Size = new System.Drawing.Size(129, 19);
            this.txtTotal.TabIndex = 37;
            this.txtTotal.UseSelectable = true;
            this.txtTotal.WaterMark = "Total";
            this.txtTotal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTotal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mdtUltimoDiasDePago
            // 
            this.mdtUltimoDiasDePago.Location = new System.Drawing.Point(742, 405);
            this.mdtUltimoDiasDePago.MinimumSize = new System.Drawing.Size(0, 29);
            this.mdtUltimoDiasDePago.Name = "mdtUltimoDiasDePago";
            this.mdtUltimoDiasDePago.Size = new System.Drawing.Size(193, 29);
            this.mdtUltimoDiasDePago.TabIndex = 40;
            // 
            // lblDiasDePago
            // 
            this.lblDiasDePago.AutoSize = true;
            this.lblDiasDePago.Location = new System.Drawing.Point(742, 380);
            this.lblDiasDePago.Name = "lblDiasDePago";
            this.lblDiasDePago.Size = new System.Drawing.Size(129, 19);
            this.lblDiasDePago.TabIndex = 41;
            this.lblDiasDePago.Text = "Ultimos dia de pago";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(248, 134);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(122, 19);
            this.metroLabel1.TabIndex = 42;
            this.metroLabel1.Text = "Numero de Cuenta";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(461, 132);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(123, 19);
            this.metroLabel2.TabIndex = 43;
            this.metroLabel2.Text = "Numero de Factura";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(461, 80);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(36, 19);
            this.metroLabel3.TabIndex = 44;
            this.metroLabel3.Text = "NRC";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(667, 80);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(29, 19);
            this.metroLabel4.TabIndex = 45;
            this.metroLabel4.Text = "NIT";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(40, 132);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(34, 19);
            this.metroLabel5.TabIndex = 46;
            this.metroLabel5.Text = "Giro";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(667, 132);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(95, 19);
            this.metroLabel8.TabIndex = 49;
            this.metroLabel8.Text = "Mes Facturado";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(40, 186);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(107, 19);
            this.metroLabel9.TabIndex = 50;
            this.metroLabel9.Text = "Facturado Desde";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(248, 186);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(103, 19);
            this.metroLabel10.TabIndex = 51;
            this.metroLabel10.Text = "Facturado Hasta";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(461, 186);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(100, 19);
            this.metroLabel11.TabIndex = 52;
            this.metroLabel11.Text = "Dias Facturados";
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(667, 186);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(92, 19);
            this.metroLabel12.TabIndex = 53;
            this.metroLabel12.Text = "Fecha Emision";
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(40, 239);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(50, 19);
            this.metroLabel13.TabIndex = 54;
            this.metroLabel13.Text = "Region";
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.Location = new System.Drawing.Point(248, 239);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(46, 19);
            this.metroLabel14.TabIndex = 55;
            this.metroLabel14.Text = "Grupo";
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.Location = new System.Drawing.Point(461, 239);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(35, 19);
            this.metroLabel15.TabIndex = 56;
            this.metroLabel15.Text = "Ruta";
            // 
            // txtSubCabezeraID
            // 
            // 
            // 
            // 
            this.txtSubCabezeraID.CustomButton.Image = null;
            this.txtSubCabezeraID.CustomButton.Location = new System.Drawing.Point(166, 1);
            this.txtSubCabezeraID.CustomButton.Name = "";
            this.txtSubCabezeraID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSubCabezeraID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSubCabezeraID.CustomButton.TabIndex = 1;
            this.txtSubCabezeraID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSubCabezeraID.CustomButton.UseSelectable = true;
            this.txtSubCabezeraID.CustomButton.Visible = false;
            this.txtSubCabezeraID.Enabled = false;
            this.txtSubCabezeraID.Lines = new string[0];
            this.txtSubCabezeraID.Location = new System.Drawing.Point(380, 628);
            this.txtSubCabezeraID.MaxLength = 32767;
            this.txtSubCabezeraID.Name = "txtSubCabezeraID";
            this.txtSubCabezeraID.PasswordChar = '\0';
            this.txtSubCabezeraID.PromptText = "SubCabezera ID";
            this.txtSubCabezeraID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSubCabezeraID.SelectedText = "";
            this.txtSubCabezeraID.SelectionLength = 0;
            this.txtSubCabezeraID.SelectionStart = 0;
            this.txtSubCabezeraID.ShortcutsEnabled = true;
            this.txtSubCabezeraID.Size = new System.Drawing.Size(188, 23);
            this.txtSubCabezeraID.TabIndex = 57;
            this.txtSubCabezeraID.UseSelectable = true;
            this.txtSubCabezeraID.Visible = false;
            this.txtSubCabezeraID.WaterMark = "SubCabezera ID";
            this.txtSubCabezeraID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSubCabezeraID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.Location = new System.Drawing.Point(742, 283);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(62, 19);
            this.metroLabel16.TabIndex = 58;
            this.metroLabel16.Text = "Sub Total";
            // 
            // metroLabel17
            // 
            this.metroLabel17.AutoSize = true;
            this.metroLabel17.Location = new System.Drawing.Point(742, 332);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(36, 19);
            this.metroLabel17.TabIndex = 59;
            this.metroLabel17.Text = "Total";
            // 
            // metroLabel18
            // 
            this.metroLabel18.AutoSize = true;
            this.metroLabel18.Location = new System.Drawing.Point(815, 470);
            this.metroLabel18.Name = "metroLabel18";
            this.metroLabel18.Size = new System.Drawing.Size(245, 57);
            this.metroLabel18.TabIndex = 63;
            this.metroLabel18.Text = "Si quiere generar una factura asegurese\r\nde haber guardado o salvado sus datos \r\n" +
    "en el boton \"Guardar\"";
            // 
            // metroLabel19
            // 
            this.metroLabel19.AutoSize = true;
            this.metroLabel19.Location = new System.Drawing.Point(40, 80);
            this.metroLabel19.Name = "metroLabel19";
            this.metroLabel19.Size = new System.Drawing.Size(59, 19);
            this.metroLabel19.TabIndex = 65;
            this.metroLabel19.Text = "Nombre";
            // 
            // txtNombre
            // 
            // 
            // 
            // 
            this.txtNombre.CustomButton.Image = null;
            this.txtNombre.CustomButton.Location = new System.Drawing.Point(165, 1);
            this.txtNombre.CustomButton.Name = "";
            this.txtNombre.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtNombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNombre.CustomButton.TabIndex = 1;
            this.txtNombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNombre.CustomButton.UseSelectable = true;
            this.txtNombre.CustomButton.Visible = false;
            this.txtNombre.Enabled = false;
            this.txtNombre.Lines = new string[0];
            this.txtNombre.Location = new System.Drawing.Point(40, 102);
            this.txtNombre.MaxLength = 32767;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.PromptText = "Nombre";
            this.txtNombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNombre.SelectedText = "";
            this.txtNombre.SelectionLength = 0;
            this.txtNombre.SelectionStart = 0;
            this.txtNombre.ShortcutsEnabled = true;
            this.txtNombre.Size = new System.Drawing.Size(193, 29);
            this.txtNombre.TabIndex = 64;
            this.txtNombre.UseSelectable = true;
            this.txtNombre.WaterMark = "Nombre";
            this.txtNombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel20
            // 
            this.metroLabel20.AutoSize = true;
            this.metroLabel20.Location = new System.Drawing.Point(248, 80);
            this.metroLabel20.Name = "metroLabel20";
            this.metroLabel20.Size = new System.Drawing.Size(58, 19);
            this.metroLabel20.TabIndex = 67;
            this.metroLabel20.Text = "Apellido";
            // 
            // txtApellido
            // 
            // 
            // 
            // 
            this.txtApellido.CustomButton.Image = null;
            this.txtApellido.CustomButton.Location = new System.Drawing.Point(165, 1);
            this.txtApellido.CustomButton.Name = "";
            this.txtApellido.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtApellido.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtApellido.CustomButton.TabIndex = 1;
            this.txtApellido.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtApellido.CustomButton.UseSelectable = true;
            this.txtApellido.CustomButton.Visible = false;
            this.txtApellido.Enabled = false;
            this.txtApellido.Lines = new string[0];
            this.txtApellido.Location = new System.Drawing.Point(248, 102);
            this.txtApellido.MaxLength = 32767;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.PasswordChar = '\0';
            this.txtApellido.PromptText = "Apellido";
            this.txtApellido.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtApellido.SelectedText = "";
            this.txtApellido.SelectionLength = 0;
            this.txtApellido.SelectionStart = 0;
            this.txtApellido.ShortcutsEnabled = true;
            this.txtApellido.Size = new System.Drawing.Size(193, 29);
            this.txtApellido.TabIndex = 66;
            this.txtApellido.UseSelectable = true;
            this.txtApellido.WaterMark = "Apellido";
            this.txtApellido.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtApellido.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtDateMesFaturado
            // 
            this.mtDateMesFaturado.CustomFormat = "";
            this.mtDateMesFaturado.Location = new System.Drawing.Point(667, 154);
            this.mtDateMesFaturado.MinimumSize = new System.Drawing.Size(0, 29);
            this.mtDateMesFaturado.Name = "mtDateMesFaturado";
            this.mtDateMesFaturado.Size = new System.Drawing.Size(193, 29);
            this.mtDateMesFaturado.TabIndex = 68;
            // 
            // mtDateFaturadoDesde
            // 
            this.mtDateFaturadoDesde.CustomFormat = "";
            this.mtDateFaturadoDesde.Location = new System.Drawing.Point(40, 208);
            this.mtDateFaturadoDesde.MinimumSize = new System.Drawing.Size(0, 29);
            this.mtDateFaturadoDesde.Name = "mtDateFaturadoDesde";
            this.mtDateFaturadoDesde.Size = new System.Drawing.Size(193, 29);
            this.mtDateFaturadoDesde.TabIndex = 69;
            // 
            // mtDateFaturadoHasta
            // 
            this.mtDateFaturadoHasta.CustomFormat = "";
            this.mtDateFaturadoHasta.Location = new System.Drawing.Point(248, 208);
            this.mtDateFaturadoHasta.MinimumSize = new System.Drawing.Size(0, 29);
            this.mtDateFaturadoHasta.Name = "mtDateFaturadoHasta";
            this.mtDateFaturadoHasta.Size = new System.Drawing.Size(193, 29);
            this.mtDateFaturadoHasta.TabIndex = 70;
            // 
            // mtDateDiasFacturados
            // 
            this.mtDateDiasFacturados.CustomFormat = "";
            this.mtDateDiasFacturados.Location = new System.Drawing.Point(461, 208);
            this.mtDateDiasFacturados.MinimumSize = new System.Drawing.Size(0, 29);
            this.mtDateDiasFacturados.Name = "mtDateDiasFacturados";
            this.mtDateDiasFacturados.Size = new System.Drawing.Size(193, 29);
            this.mtDateDiasFacturados.TabIndex = 71;
            // 
            // mtDateFechaEmision
            // 
            this.mtDateFechaEmision.CustomFormat = "";
            this.mtDateFechaEmision.Location = new System.Drawing.Point(667, 208);
            this.mtDateFechaEmision.MinimumSize = new System.Drawing.Size(0, 29);
            this.mtDateFechaEmision.Name = "mtDateFechaEmision";
            this.mtDateFechaEmision.Size = new System.Drawing.Size(193, 29);
            this.mtDateFechaEmision.TabIndex = 72;
            // 
            // btnGenerarFactura
            // 
            this.btnGenerarFactura.ActiveControl = null;
            this.btnGenerarFactura.Location = new System.Drawing.Point(868, 548);
            this.btnGenerarFactura.Name = "btnGenerarFactura";
            this.btnGenerarFactura.Size = new System.Drawing.Size(137, 86);
            this.btnGenerarFactura.TabIndex = 62;
            this.btnGenerarFactura.Text = "Generar Factura";
            this.btnGenerarFactura.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGenerarFactura.TileImage = global::SistemaCobroAgua.Properties.Resources.google_docs;
            this.btnGenerarFactura.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGenerarFactura.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnGenerarFactura.UseSelectable = true;
            this.btnGenerarFactura.UseTileImage = true;
            // 
            // mtGuardar
            // 
            this.mtGuardar.ActiveControl = null;
            this.mtGuardar.Location = new System.Drawing.Point(615, 548);
            this.mtGuardar.Name = "mtGuardar";
            this.mtGuardar.Size = new System.Drawing.Size(96, 86);
            this.mtGuardar.TabIndex = 61;
            this.mtGuardar.Text = "Guardar";
            this.mtGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtGuardar.TileImage = global::SistemaCobroAgua.Properties.Resources.floppy_disk;
            this.mtGuardar.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtGuardar.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtGuardar.UseSelectable = true;
            this.mtGuardar.UseTileImage = true;
            // 
            // mtMenu
            // 
            this.mtMenu.ActiveControl = null;
            this.mtMenu.Location = new System.Drawing.Point(40, 609);
            this.mtMenu.Name = "mtMenu";
            this.mtMenu.Size = new System.Drawing.Size(96, 86);
            this.mtMenu.TabIndex = 60;
            this.mtMenu.Text = "Menu";
            this.mtMenu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtMenu.TileImage = global::SistemaCobroAgua.Properties.Resources.menu;
            this.mtMenu.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtMenu.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtMenu.UseSelectable = true;
            this.mtMenu.UseTileImage = true;
            this.mtMenu.Click += new System.EventHandler(this.mtMenu_Click);
            // 
            // btnMenosServicio
            // 
            this.btnMenosServicio.ActiveControl = null;
            this.btnMenosServicio.Location = new System.Drawing.Point(614, 423);
            this.btnMenosServicio.Name = "btnMenosServicio";
            this.btnMenosServicio.Size = new System.Drawing.Size(96, 84);
            this.btnMenosServicio.TabIndex = 18;
            this.btnMenosServicio.Text = "Borrar";
            this.btnMenosServicio.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMenosServicio.TileImage = global::SistemaCobroAgua.Properties.Resources.minus;
            this.btnMenosServicio.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMenosServicio.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnMenosServicio.UseSelectable = true;
            this.btnMenosServicio.UseTileImage = true;
            // 
            // btnAgregarServicio
            // 
            this.btnAgregarServicio.ActiveControl = null;
            this.btnAgregarServicio.Location = new System.Drawing.Point(614, 305);
            this.btnAgregarServicio.Name = "btnAgregarServicio";
            this.btnAgregarServicio.Size = new System.Drawing.Size(96, 84);
            this.btnAgregarServicio.TabIndex = 17;
            this.btnAgregarServicio.Text = "Agregar";
            this.btnAgregarServicio.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgregarServicio.TileImage = global::SistemaCobroAgua.Properties.Resources.add;
            this.btnAgregarServicio.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAgregarServicio.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnAgregarServicio.UseSelectable = true;
            this.btnAgregarServicio.UseTileImage = true;
            this.btnAgregarServicio.Click += new System.EventHandler(this.btnAgregarServicio_Click);
            // 
            // CajaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 703);
            this.Controls.Add(this.mtDateFechaEmision);
            this.Controls.Add(this.mtDateDiasFacturados);
            this.Controls.Add(this.mtDateFaturadoHasta);
            this.Controls.Add(this.mtDateFaturadoDesde);
            this.Controls.Add(this.mtDateMesFaturado);
            this.Controls.Add(this.metroLabel20);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.metroLabel19);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.metroLabel18);
            this.Controls.Add(this.btnGenerarFactura);
            this.Controls.Add(this.mtGuardar);
            this.Controls.Add(this.mtMenu);
            this.Controls.Add(this.metroLabel17);
            this.Controls.Add(this.metroLabel16);
            this.Controls.Add(this.txtSubCabezeraID);
            this.Controls.Add(this.metroLabel15);
            this.Controls.Add(this.metroLabel14);
            this.Controls.Add(this.metroLabel13);
            this.Controls.Add(this.metroLabel12);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.lblDiasDePago);
            this.Controls.Add(this.mdtUltimoDiasDePago);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.btnDiasFacturados);
            this.Controls.Add(this.btnAgregarCliente);
            this.Controls.Add(this.txtSubTotal);
            this.Controls.Add(this.txtNIT);
            this.Controls.Add(this.txtRuta);
            this.Controls.Add(this.txtGrupo);
            this.Controls.Add(this.txtRegion);
            this.Controls.Add(this.txtCabezeraFacturaID);
            this.Controls.Add(this.txtNRC);
            this.Controls.Add(this.txtClienteID);
            this.Controls.Add(this.txtNumeroDeFactura);
            this.Controls.Add(this.txtGiro);
            this.Controls.Add(this.txtNumeroDeCuenta);
            this.Controls.Add(this.btnMenosServicio);
            this.Controls.Add(this.btnAgregarServicio);
            this.Controls.Add(this.dataGridViewDetalleFactura);
            this.Name = "CajaForm";
            this.Resizable = false;
            this.Text = "Caja";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.CajaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetalleFactura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDetalleFactura;
        private MetroFramework.Controls.MetroTile btnAgregarServicio;
        private MetroFramework.Controls.MetroTile btnMenosServicio;
        private MetroFramework.Controls.MetroTextBox txtNumeroDeCuenta;
        private MetroFramework.Controls.MetroTextBox txtGiro;
        private MetroFramework.Controls.MetroTextBox txtNumeroDeFactura;
        private MetroFramework.Controls.MetroTextBox txtNRC;
        private MetroFramework.Controls.MetroTextBox txtRuta;
        private MetroFramework.Controls.MetroTextBox txtGrupo;
        private MetroFramework.Controls.MetroTextBox txtRegion;
        private MetroFramework.Controls.MetroTextBox txtNIT;
        private MetroFramework.Controls.MetroTextBox txtSubTotal;
        private MetroFramework.Controls.MetroButton btnAgregarCliente;
        private MetroFramework.Controls.MetroButton btnDiasFacturados;
        private MetroFramework.Controls.MetroTextBox txtTotal;
        private MetroFramework.Controls.MetroDateTime mdtUltimoDiasDePago;
        private MetroFramework.Controls.MetroLabel lblDiasDePago;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroLabel metroLabel17;
        private MetroFramework.Controls.MetroTile mtMenu;
        private MetroFramework.Controls.MetroTile mtGuardar;
        private MetroFramework.Controls.MetroTile btnGenerarFactura;
        private MetroFramework.Controls.MetroLabel metroLabel18;
        private MetroFramework.Controls.MetroLabel metroLabel19;
        private MetroFramework.Controls.MetroLabel metroLabel20;
        private MetroFramework.Controls.MetroDateTime mtDateMesFaturado;
        private MetroFramework.Controls.MetroDateTime mtDateFaturadoDesde;
        private MetroFramework.Controls.MetroDateTime mtDateFaturadoHasta;
        private MetroFramework.Controls.MetroDateTime mtDateDiasFacturados;
        private MetroFramework.Controls.MetroDateTime mtDateFechaEmision;
        public MetroFramework.Controls.MetroTextBox txtClienteID;
        public MetroFramework.Controls.MetroTextBox txtCabezeraFacturaID;
        public MetroFramework.Controls.MetroTextBox txtSubCabezeraID;
        public MetroFramework.Controls.MetroTextBox txtNombre;
        public MetroFramework.Controls.MetroTextBox txtApellido;
    }
}