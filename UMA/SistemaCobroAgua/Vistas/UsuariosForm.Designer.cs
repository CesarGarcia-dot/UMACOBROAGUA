namespace SistemaCobroAgua.Vistas
{
    partial class UsuariosForm
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
            this.lblDUI = new MetroFramework.Controls.MetroLabel();
            this.lblMunicipio = new MetroFramework.Controls.MetroLabel();
            this.lblDepartamento = new MetroFramework.Controls.MetroLabel();
            this.lblDireccion = new MetroFramework.Controls.MetroLabel();
            this.lblApellido = new MetroFramework.Controls.MetroLabel();
            this.lblNombre = new MetroFramework.Controls.MetroLabel();
            this.lblID = new MetroFramework.Controls.MetroLabel();
            this.mtMenu = new MetroFramework.Controls.MetroTile();
            this.mtCaja = new MetroFramework.Controls.MetroTile();
            this.mtRefrescar = new MetroFramework.Controls.MetroTile();
            this.mtBorrar = new MetroFramework.Controls.MetroTile();
            this.mtEditar = new MetroFramework.Controls.MetroTile();
            this.mtGuardar = new MetroFramework.Controls.MetroTile();
            this.btnBuscar = new MetroFramework.Controls.MetroButton();
            this.txtBarraBuscar = new MetroFramework.Controls.MetroTextBox();
            this.txtDUI = new MetroFramework.Controls.MetroTextBox();
            this.txtMunicipio = new MetroFramework.Controls.MetroTextBox();
            this.txtDepartamento = new MetroFramework.Controls.MetroTextBox();
            this.txtDireccion = new MetroFramework.Controls.MetroTextBox();
            this.txtApellido = new MetroFramework.Controls.MetroTextBox();
            this.txtNombre = new MetroFramework.Controls.MetroTextBox();
            this.txtID = new MetroFramework.Controls.MetroTextBox();
            this.lblPageNumber = new MetroFramework.Controls.MetroLabel();
            this.btnNext = new MetroFramework.Controls.MetroButton();
            this.btnPrevious = new MetroFramework.Controls.MetroButton();
            this.dataGridViewUsuarios = new System.Windows.Forms.DataGridView();
            this.txtEmail = new MetroFramework.Controls.MetroTextBox();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.lblEmail = new MetroFramework.Controls.MetroLabel();
            this.lblPassword = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDUI
            // 
            this.lblDUI.AutoSize = true;
            this.lblDUI.Location = new System.Drawing.Point(130, 363);
            this.lblDUI.Name = "lblDUI";
            this.lblDUI.Size = new System.Drawing.Size(30, 19);
            this.lblDUI.TabIndex = 52;
            this.lblDUI.Text = "DUI";
            // 
            // lblMunicipio
            // 
            this.lblMunicipio.AutoSize = true;
            this.lblMunicipio.Location = new System.Drawing.Point(94, 317);
            this.lblMunicipio.Name = "lblMunicipio";
            this.lblMunicipio.Size = new System.Drawing.Size(66, 19);
            this.lblMunicipio.TabIndex = 51;
            this.lblMunicipio.Text = "Municipio";
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Location = new System.Drawing.Point(65, 271);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(95, 19);
            this.lblDepartamento.TabIndex = 50;
            this.lblDepartamento.Text = "Departamento";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(97, 225);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(63, 19);
            this.lblDireccion.TabIndex = 49;
            this.lblDireccion.Text = "Direccion";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(102, 179);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(58, 19);
            this.lblApellido.TabIndex = 48;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(101, 133);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(59, 19);
            this.lblNombre.TabIndex = 47;
            this.lblNombre.Text = "Nombre";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(91, 87);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(69, 19);
            this.lblID.TabIndex = 46;
            this.lblID.Text = "Usuario ID";
            // 
            // mtMenu
            // 
            this.mtMenu.ActiveControl = null;
            this.mtMenu.Location = new System.Drawing.Point(304, 621);
            this.mtMenu.Name = "mtMenu";
            this.mtMenu.Size = new System.Drawing.Size(96, 86);
            this.mtMenu.TabIndex = 45;
            this.mtMenu.Text = "Menu";
            this.mtMenu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtMenu.TileImage = global::SistemaCobroAgua.Properties.Resources.menu;
            this.mtMenu.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtMenu.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtMenu.UseSelectable = true;
            this.mtMenu.UseTileImage = true;
            this.mtMenu.Click += new System.EventHandler(this.mtMenu_Click);
            // 
            // mtCaja
            // 
            this.mtCaja.ActiveControl = null;
            this.mtCaja.Location = new System.Drawing.Point(185, 621);
            this.mtCaja.Name = "mtCaja";
            this.mtCaja.Size = new System.Drawing.Size(96, 86);
            this.mtCaja.TabIndex = 44;
            this.mtCaja.Text = "Caja";
            this.mtCaja.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtCaja.TileImage = global::SistemaCobroAgua.Properties.Resources.cash_register;
            this.mtCaja.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtCaja.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtCaja.UseSelectable = true;
            this.mtCaja.UseTileImage = true;
            this.mtCaja.Click += new System.EventHandler(this.mtCaja_Click);
            // 
            // mtRefrescar
            // 
            this.mtRefrescar.ActiveControl = null;
            this.mtRefrescar.Location = new System.Drawing.Point(61, 621);
            this.mtRefrescar.Name = "mtRefrescar";
            this.mtRefrescar.Size = new System.Drawing.Size(96, 86);
            this.mtRefrescar.TabIndex = 43;
            this.mtRefrescar.Text = "Refrescar";
            this.mtRefrescar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtRefrescar.TileImage = global::SistemaCobroAgua.Properties.Resources.refresh;
            this.mtRefrescar.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtRefrescar.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtRefrescar.UseSelectable = true;
            this.mtRefrescar.UseTileImage = true;
            this.mtRefrescar.Click += new System.EventHandler(this.mtRefrescar_Click);
            // 
            // mtBorrar
            // 
            this.mtBorrar.ActiveControl = null;
            this.mtBorrar.Location = new System.Drawing.Point(304, 512);
            this.mtBorrar.Name = "mtBorrar";
            this.mtBorrar.Size = new System.Drawing.Size(96, 86);
            this.mtBorrar.TabIndex = 42;
            this.mtBorrar.Text = "Borrar";
            this.mtBorrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtBorrar.TileImage = global::SistemaCobroAgua.Properties.Resources.trash;
            this.mtBorrar.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtBorrar.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtBorrar.UseSelectable = true;
            this.mtBorrar.UseTileImage = true;
            this.mtBorrar.Click += new System.EventHandler(this.mtBorrar_Click);
            // 
            // mtEditar
            // 
            this.mtEditar.ActiveControl = null;
            this.mtEditar.Location = new System.Drawing.Point(185, 512);
            this.mtEditar.Name = "mtEditar";
            this.mtEditar.Size = new System.Drawing.Size(96, 86);
            this.mtEditar.TabIndex = 41;
            this.mtEditar.Text = "Editar";
            this.mtEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtEditar.TileImage = global::SistemaCobroAgua.Properties.Resources.pencil;
            this.mtEditar.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtEditar.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtEditar.UseSelectable = true;
            this.mtEditar.UseTileImage = true;
            this.mtEditar.Click += new System.EventHandler(this.mtEditar_Click);
            // 
            // mtGuardar
            // 
            this.mtGuardar.ActiveControl = null;
            this.mtGuardar.Location = new System.Drawing.Point(61, 512);
            this.mtGuardar.Name = "mtGuardar";
            this.mtGuardar.Size = new System.Drawing.Size(96, 86);
            this.mtGuardar.TabIndex = 40;
            this.mtGuardar.Text = "Guardar";
            this.mtGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtGuardar.TileImage = global::SistemaCobroAgua.Properties.Resources.floppy_disk;
            this.mtGuardar.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtGuardar.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtGuardar.UseSelectable = true;
            this.mtGuardar.UseTileImage = true;
            this.mtGuardar.Click += new System.EventHandler(this.mtGuardar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(972, 64);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(85, 23);
            this.btnBuscar.TabIndex = 39;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseSelectable = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBarraBuscar
            // 
            // 
            // 
            // 
            this.txtBarraBuscar.CustomButton.Image = null;
            this.txtBarraBuscar.CustomButton.Location = new System.Drawing.Point(380, 1);
            this.txtBarraBuscar.CustomButton.Name = "";
            this.txtBarraBuscar.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBarraBuscar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBarraBuscar.CustomButton.TabIndex = 1;
            this.txtBarraBuscar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBarraBuscar.CustomButton.UseSelectable = true;
            this.txtBarraBuscar.CustomButton.Visible = false;
            this.txtBarraBuscar.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtBarraBuscar.Lines = new string[0];
            this.txtBarraBuscar.Location = new System.Drawing.Point(489, 64);
            this.txtBarraBuscar.MaxLength = 32767;
            this.txtBarraBuscar.Name = "txtBarraBuscar";
            this.txtBarraBuscar.PasswordChar = '\0';
            this.txtBarraBuscar.PromptText = "Buscar usuario...";
            this.txtBarraBuscar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBarraBuscar.SelectedText = "";
            this.txtBarraBuscar.SelectionLength = 0;
            this.txtBarraBuscar.SelectionStart = 0;
            this.txtBarraBuscar.ShortcutsEnabled = true;
            this.txtBarraBuscar.Size = new System.Drawing.Size(402, 23);
            this.txtBarraBuscar.TabIndex = 38;
            this.txtBarraBuscar.UseSelectable = true;
            this.txtBarraBuscar.WaterMark = "Buscar usuario...";
            this.txtBarraBuscar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBarraBuscar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtDUI
            // 
            // 
            // 
            // 
            this.txtDUI.CustomButton.Image = null;
            this.txtDUI.CustomButton.Location = new System.Drawing.Point(203, 1);
            this.txtDUI.CustomButton.Name = "";
            this.txtDUI.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDUI.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDUI.CustomButton.TabIndex = 1;
            this.txtDUI.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDUI.CustomButton.UseSelectable = true;
            this.txtDUI.CustomButton.Visible = false;
            this.txtDUI.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtDUI.Lines = new string[0];
            this.txtDUI.Location = new System.Drawing.Point(185, 363);
            this.txtDUI.MaxLength = 32767;
            this.txtDUI.Name = "txtDUI";
            this.txtDUI.PasswordChar = '\0';
            this.txtDUI.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDUI.SelectedText = "";
            this.txtDUI.SelectionLength = 0;
            this.txtDUI.SelectionStart = 0;
            this.txtDUI.ShortcutsEnabled = true;
            this.txtDUI.Size = new System.Drawing.Size(225, 23);
            this.txtDUI.TabIndex = 37;
            this.txtDUI.UseSelectable = true;
            this.txtDUI.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDUI.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtMunicipio
            // 
            // 
            // 
            // 
            this.txtMunicipio.CustomButton.Image = null;
            this.txtMunicipio.CustomButton.Location = new System.Drawing.Point(203, 1);
            this.txtMunicipio.CustomButton.Name = "";
            this.txtMunicipio.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMunicipio.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMunicipio.CustomButton.TabIndex = 1;
            this.txtMunicipio.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMunicipio.CustomButton.UseSelectable = true;
            this.txtMunicipio.CustomButton.Visible = false;
            this.txtMunicipio.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtMunicipio.Lines = new string[0];
            this.txtMunicipio.Location = new System.Drawing.Point(185, 317);
            this.txtMunicipio.MaxLength = 32767;
            this.txtMunicipio.Name = "txtMunicipio";
            this.txtMunicipio.PasswordChar = '\0';
            this.txtMunicipio.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMunicipio.SelectedText = "";
            this.txtMunicipio.SelectionLength = 0;
            this.txtMunicipio.SelectionStart = 0;
            this.txtMunicipio.ShortcutsEnabled = true;
            this.txtMunicipio.Size = new System.Drawing.Size(225, 23);
            this.txtMunicipio.TabIndex = 36;
            this.txtMunicipio.UseSelectable = true;
            this.txtMunicipio.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMunicipio.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtDepartamento
            // 
            // 
            // 
            // 
            this.txtDepartamento.CustomButton.Image = null;
            this.txtDepartamento.CustomButton.Location = new System.Drawing.Point(203, 1);
            this.txtDepartamento.CustomButton.Name = "";
            this.txtDepartamento.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDepartamento.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDepartamento.CustomButton.TabIndex = 1;
            this.txtDepartamento.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDepartamento.CustomButton.UseSelectable = true;
            this.txtDepartamento.CustomButton.Visible = false;
            this.txtDepartamento.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtDepartamento.Lines = new string[0];
            this.txtDepartamento.Location = new System.Drawing.Point(185, 271);
            this.txtDepartamento.MaxLength = 32767;
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.PasswordChar = '\0';
            this.txtDepartamento.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDepartamento.SelectedText = "";
            this.txtDepartamento.SelectionLength = 0;
            this.txtDepartamento.SelectionStart = 0;
            this.txtDepartamento.ShortcutsEnabled = true;
            this.txtDepartamento.Size = new System.Drawing.Size(225, 23);
            this.txtDepartamento.TabIndex = 35;
            this.txtDepartamento.UseSelectable = true;
            this.txtDepartamento.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDepartamento.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtDireccion
            // 
            // 
            // 
            // 
            this.txtDireccion.CustomButton.Image = null;
            this.txtDireccion.CustomButton.Location = new System.Drawing.Point(203, 1);
            this.txtDireccion.CustomButton.Name = "";
            this.txtDireccion.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDireccion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDireccion.CustomButton.TabIndex = 1;
            this.txtDireccion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDireccion.CustomButton.UseSelectable = true;
            this.txtDireccion.CustomButton.Visible = false;
            this.txtDireccion.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtDireccion.Lines = new string[0];
            this.txtDireccion.Location = new System.Drawing.Point(185, 225);
            this.txtDireccion.MaxLength = 32767;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.PasswordChar = '\0';
            this.txtDireccion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDireccion.SelectedText = "";
            this.txtDireccion.SelectionLength = 0;
            this.txtDireccion.SelectionStart = 0;
            this.txtDireccion.ShortcutsEnabled = true;
            this.txtDireccion.Size = new System.Drawing.Size(225, 23);
            this.txtDireccion.TabIndex = 34;
            this.txtDireccion.UseSelectable = true;
            this.txtDireccion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDireccion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtApellido
            // 
            // 
            // 
            // 
            this.txtApellido.CustomButton.Image = null;
            this.txtApellido.CustomButton.Location = new System.Drawing.Point(203, 1);
            this.txtApellido.CustomButton.Name = "";
            this.txtApellido.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtApellido.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtApellido.CustomButton.TabIndex = 1;
            this.txtApellido.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtApellido.CustomButton.UseSelectable = true;
            this.txtApellido.CustomButton.Visible = false;
            this.txtApellido.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtApellido.Lines = new string[0];
            this.txtApellido.Location = new System.Drawing.Point(185, 179);
            this.txtApellido.MaxLength = 32767;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.PasswordChar = '\0';
            this.txtApellido.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtApellido.SelectedText = "";
            this.txtApellido.SelectionLength = 0;
            this.txtApellido.SelectionStart = 0;
            this.txtApellido.ShortcutsEnabled = true;
            this.txtApellido.Size = new System.Drawing.Size(225, 23);
            this.txtApellido.TabIndex = 33;
            this.txtApellido.UseSelectable = true;
            this.txtApellido.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtApellido.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtNombre
            // 
            // 
            // 
            // 
            this.txtNombre.CustomButton.Image = null;
            this.txtNombre.CustomButton.Location = new System.Drawing.Point(203, 1);
            this.txtNombre.CustomButton.Name = "";
            this.txtNombre.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNombre.CustomButton.TabIndex = 1;
            this.txtNombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNombre.CustomButton.UseSelectable = true;
            this.txtNombre.CustomButton.Visible = false;
            this.txtNombre.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtNombre.Lines = new string[0];
            this.txtNombre.Location = new System.Drawing.Point(185, 133);
            this.txtNombre.MaxLength = 32767;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNombre.SelectedText = "";
            this.txtNombre.SelectionLength = 0;
            this.txtNombre.SelectionStart = 0;
            this.txtNombre.ShortcutsEnabled = true;
            this.txtNombre.Size = new System.Drawing.Size(225, 23);
            this.txtNombre.TabIndex = 32;
            this.txtNombre.UseSelectable = true;
            this.txtNombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtID
            // 
            // 
            // 
            // 
            this.txtID.CustomButton.Image = null;
            this.txtID.CustomButton.Location = new System.Drawing.Point(203, 1);
            this.txtID.CustomButton.Name = "";
            this.txtID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtID.CustomButton.TabIndex = 1;
            this.txtID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtID.CustomButton.UseSelectable = true;
            this.txtID.CustomButton.Visible = false;
            this.txtID.Enabled = false;
            this.txtID.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtID.Lines = new string[0];
            this.txtID.Location = new System.Drawing.Point(185, 87);
            this.txtID.MaxLength = 32767;
            this.txtID.Name = "txtID";
            this.txtID.PasswordChar = '\0';
            this.txtID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtID.SelectedText = "";
            this.txtID.SelectionLength = 0;
            this.txtID.SelectionStart = 0;
            this.txtID.ShortcutsEnabled = true;
            this.txtID.Size = new System.Drawing.Size(225, 23);
            this.txtID.TabIndex = 31;
            this.txtID.UseSelectable = true;
            this.txtID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblPageNumber
            // 
            this.lblPageNumber.AutoSize = true;
            this.lblPageNumber.Location = new System.Drawing.Point(747, 565);
            this.lblPageNumber.Name = "lblPageNumber";
            this.lblPageNumber.Size = new System.Drawing.Size(68, 19);
            this.lblPageNumber.TabIndex = 30;
            this.lblPageNumber.Text = "Cargando";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(1000, 565);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(57, 19);
            this.btnNext.TabIndex = 29;
            this.btnNext.Text = ">";
            this.btnNext.UseSelectable = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(489, 565);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(56, 19);
            this.btnPrevious.TabIndex = 28;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseSelectable = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // dataGridViewUsuarios
            // 
            this.dataGridViewUsuarios.AllowUserToAddRows = false;
            this.dataGridViewUsuarios.AllowUserToDeleteRows = false;
            this.dataGridViewUsuarios.AllowUserToOrderColumns = true;
            this.dataGridViewUsuarios.AllowUserToResizeRows = false;
            this.dataGridViewUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsuarios.Location = new System.Drawing.Point(489, 118);
            this.dataGridViewUsuarios.MultiSelect = false;
            this.dataGridViewUsuarios.Name = "dataGridViewUsuarios";
            this.dataGridViewUsuarios.ReadOnly = true;
            this.dataGridViewUsuarios.ShowEditingIcon = false;
            this.dataGridViewUsuarios.Size = new System.Drawing.Size(568, 431);
            this.dataGridViewUsuarios.TabIndex = 27;
            this.dataGridViewUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUsuarios_CellClick);
            this.dataGridViewUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUsuarios_CellContentClick);
            // 
            // txtEmail
            // 
            // 
            // 
            // 
            this.txtEmail.CustomButton.Image = null;
            this.txtEmail.CustomButton.Location = new System.Drawing.Point(203, 1);
            this.txtEmail.CustomButton.Name = "";
            this.txtEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmail.CustomButton.TabIndex = 1;
            this.txtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmail.CustomButton.UseSelectable = true;
            this.txtEmail.CustomButton.Visible = false;
            this.txtEmail.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtEmail.Lines = new string[0];
            this.txtEmail.Location = new System.Drawing.Point(185, 409);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.Size = new System.Drawing.Size(225, 23);
            this.txtEmail.TabIndex = 53;
            this.txtEmail.UseSelectable = true;
            this.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPassword
            // 
            // 
            // 
            // 
            this.txtPassword.CustomButton.Image = null;
            this.txtPassword.CustomButton.Location = new System.Drawing.Point(203, 1);
            this.txtPassword.CustomButton.Name = "";
            this.txtPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPassword.CustomButton.TabIndex = 1;
            this.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPassword.CustomButton.UseSelectable = true;
            this.txtPassword.CustomButton.Visible = false;
            this.txtPassword.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtPassword.Lines = new string[0];
            this.txtPassword.Location = new System.Drawing.Point(185, 455);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(225, 23);
            this.txtPassword.TabIndex = 54;
            this.txtPassword.UseSelectable = true;
            this.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEmail.Location = new System.Drawing.Point(119, 409);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 19);
            this.lblEmail.TabIndex = 55;
            this.lblEmail.Text = "Email";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(119, 455);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(41, 19);
            this.lblPassword.TabIndex = 56;
            this.lblPassword.Text = "Clave";
            // 
            // UsuariosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 733);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblDUI);
            this.Controls.Add(this.lblMunicipio);
            this.Controls.Add(this.lblDepartamento);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.mtMenu);
            this.Controls.Add(this.mtCaja);
            this.Controls.Add(this.mtRefrescar);
            this.Controls.Add(this.mtBorrar);
            this.Controls.Add(this.mtEditar);
            this.Controls.Add(this.mtGuardar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBarraBuscar);
            this.Controls.Add(this.txtDUI);
            this.Controls.Add(this.txtMunicipio);
            this.Controls.Add(this.txtDepartamento);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblPageNumber);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.dataGridViewUsuarios);
            this.Name = "UsuariosForm";
            this.Resizable = false;
            this.Text = "Lista de Usuarios";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.UsuariosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblDUI;
        private MetroFramework.Controls.MetroLabel lblMunicipio;
        private MetroFramework.Controls.MetroLabel lblDepartamento;
        private MetroFramework.Controls.MetroLabel lblDireccion;
        private MetroFramework.Controls.MetroLabel lblApellido;
        private MetroFramework.Controls.MetroLabel lblNombre;
        private MetroFramework.Controls.MetroLabel lblID;
        private MetroFramework.Controls.MetroTile mtMenu;
        private MetroFramework.Controls.MetroTile mtCaja;
        private MetroFramework.Controls.MetroTile mtRefrescar;
        private MetroFramework.Controls.MetroTile mtBorrar;
        private MetroFramework.Controls.MetroTile mtEditar;
        private MetroFramework.Controls.MetroTile mtGuardar;
        private MetroFramework.Controls.MetroButton btnBuscar;
        private MetroFramework.Controls.MetroTextBox txtBarraBuscar;
        private MetroFramework.Controls.MetroTextBox txtDUI;
        private MetroFramework.Controls.MetroTextBox txtMunicipio;
        private MetroFramework.Controls.MetroTextBox txtDepartamento;
        private MetroFramework.Controls.MetroTextBox txtDireccion;
        private MetroFramework.Controls.MetroTextBox txtApellido;
        private MetroFramework.Controls.MetroTextBox txtNombre;
        private MetroFramework.Controls.MetroTextBox txtID;
        private MetroFramework.Controls.MetroLabel lblPageNumber;
        private MetroFramework.Controls.MetroButton btnNext;
        private MetroFramework.Controls.MetroButton btnPrevious;
        private System.Windows.Forms.DataGridView dataGridViewUsuarios;
        private MetroFramework.Controls.MetroTextBox txtEmail;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private MetroFramework.Controls.MetroLabel lblEmail;
        private MetroFramework.Controls.MetroLabel lblPassword;
    }
}