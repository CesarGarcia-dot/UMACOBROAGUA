namespace SistemaCobroAgua.Vistas
{
    partial class ServiciosForm
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
            this.lblCodigo = new MetroFramework.Controls.MetroLabel();
            this.lblPrecio = new MetroFramework.Controls.MetroLabel();
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
            this.txtCodigo = new MetroFramework.Controls.MetroTextBox();
            this.txtPrecio = new MetroFramework.Controls.MetroTextBox();
            this.txtNombreServicio = new MetroFramework.Controls.MetroTextBox();
            this.txtID = new MetroFramework.Controls.MetroTextBox();
            this.dataGridViewServicios = new System.Windows.Forms.DataGridView();
            this.lblPageNumber = new MetroFramework.Controls.MetroLabel();
            this.btnNext = new MetroFramework.Controls.MetroButton();
            this.btnPrevious = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServicios)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(81, 233);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(53, 19);
            this.lblCodigo.TabIndex = 49;
            this.lblCodigo.Text = "Codigo";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(88, 175);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(46, 19);
            this.lblPrecio.TabIndex = 48;
            this.lblPrecio.Text = "Precio";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(5, 130);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(129, 19);
            this.lblNombre.TabIndex = 47;
            this.lblNombre.Text = "Nombre De Servicio";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(63, 80);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(71, 19);
            this.lblID.TabIndex = 46;
            this.lblID.Text = "Servicio ID";
            // 
            // mtMenu
            // 
            this.mtMenu.ActiveControl = null;
            this.mtMenu.Location = new System.Drawing.Point(292, 578);
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
            this.mtCaja.Location = new System.Drawing.Point(173, 578);
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
            this.mtRefrescar.Location = new System.Drawing.Point(49, 578);
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
            this.mtBorrar.Location = new System.Drawing.Point(292, 469);
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
            this.mtEditar.Location = new System.Drawing.Point(173, 469);
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
            this.mtGuardar.Location = new System.Drawing.Point(49, 469);
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
            this.btnBuscar.Location = new System.Drawing.Point(939, 80);
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
            this.txtBarraBuscar.Location = new System.Drawing.Point(456, 80);
            this.txtBarraBuscar.MaxLength = 32767;
            this.txtBarraBuscar.Name = "txtBarraBuscar";
            this.txtBarraBuscar.PasswordChar = '\0';
            this.txtBarraBuscar.PromptText = "Buscar servicio...";
            this.txtBarraBuscar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBarraBuscar.SelectedText = "";
            this.txtBarraBuscar.SelectionLength = 0;
            this.txtBarraBuscar.SelectionStart = 0;
            this.txtBarraBuscar.ShortcutsEnabled = true;
            this.txtBarraBuscar.Size = new System.Drawing.Size(402, 23);
            this.txtBarraBuscar.TabIndex = 38;
            this.txtBarraBuscar.UseSelectable = true;
            this.txtBarraBuscar.WaterMark = "Buscar servicio...";
            this.txtBarraBuscar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBarraBuscar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtCodigo
            // 
            // 
            // 
            // 
            this.txtCodigo.CustomButton.Image = null;
            this.txtCodigo.CustomButton.Location = new System.Drawing.Point(186, 1);
            this.txtCodigo.CustomButton.Name = "";
            this.txtCodigo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCodigo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCodigo.CustomButton.TabIndex = 1;
            this.txtCodigo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCodigo.CustomButton.UseSelectable = true;
            this.txtCodigo.CustomButton.Visible = false;
            this.txtCodigo.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtCodigo.Lines = new string[0];
            this.txtCodigo.Location = new System.Drawing.Point(152, 230);
            this.txtCodigo.MaxLength = 32767;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.PasswordChar = '\0';
            this.txtCodigo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCodigo.SelectedText = "";
            this.txtCodigo.SelectionLength = 0;
            this.txtCodigo.SelectionStart = 0;
            this.txtCodigo.ShortcutsEnabled = true;
            this.txtCodigo.Size = new System.Drawing.Size(208, 23);
            this.txtCodigo.TabIndex = 34;
            this.txtCodigo.UseSelectable = true;
            this.txtCodigo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCodigo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPrecio
            // 
            // 
            // 
            // 
            this.txtPrecio.CustomButton.Image = null;
            this.txtPrecio.CustomButton.Location = new System.Drawing.Point(186, 1);
            this.txtPrecio.CustomButton.Name = "";
            this.txtPrecio.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPrecio.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPrecio.CustomButton.TabIndex = 1;
            this.txtPrecio.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPrecio.CustomButton.UseSelectable = true;
            this.txtPrecio.CustomButton.Visible = false;
            this.txtPrecio.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtPrecio.Lines = new string[0];
            this.txtPrecio.Location = new System.Drawing.Point(152, 180);
            this.txtPrecio.MaxLength = 32767;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.PasswordChar = '\0';
            this.txtPrecio.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrecio.SelectedText = "";
            this.txtPrecio.SelectionLength = 0;
            this.txtPrecio.SelectionStart = 0;
            this.txtPrecio.ShortcutsEnabled = true;
            this.txtPrecio.Size = new System.Drawing.Size(208, 23);
            this.txtPrecio.TabIndex = 33;
            this.txtPrecio.UseSelectable = true;
            this.txtPrecio.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPrecio.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtNombreServicio
            // 
            // 
            // 
            // 
            this.txtNombreServicio.CustomButton.Image = null;
            this.txtNombreServicio.CustomButton.Location = new System.Drawing.Point(186, 1);
            this.txtNombreServicio.CustomButton.Name = "";
            this.txtNombreServicio.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNombreServicio.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNombreServicio.CustomButton.TabIndex = 1;
            this.txtNombreServicio.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNombreServicio.CustomButton.UseSelectable = true;
            this.txtNombreServicio.CustomButton.Visible = false;
            this.txtNombreServicio.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtNombreServicio.Lines = new string[0];
            this.txtNombreServicio.Location = new System.Drawing.Point(152, 130);
            this.txtNombreServicio.MaxLength = 32767;
            this.txtNombreServicio.Name = "txtNombreServicio";
            this.txtNombreServicio.PasswordChar = '\0';
            this.txtNombreServicio.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNombreServicio.SelectedText = "";
            this.txtNombreServicio.SelectionLength = 0;
            this.txtNombreServicio.SelectionStart = 0;
            this.txtNombreServicio.ShortcutsEnabled = true;
            this.txtNombreServicio.Size = new System.Drawing.Size(208, 23);
            this.txtNombreServicio.TabIndex = 32;
            this.txtNombreServicio.UseSelectable = true;
            this.txtNombreServicio.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNombreServicio.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtID
            // 
            // 
            // 
            // 
            this.txtID.CustomButton.Image = null;
            this.txtID.CustomButton.Location = new System.Drawing.Point(186, 1);
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
            this.txtID.Location = new System.Drawing.Point(152, 80);
            this.txtID.MaxLength = 32767;
            this.txtID.Name = "txtID";
            this.txtID.PasswordChar = '\0';
            this.txtID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtID.SelectedText = "";
            this.txtID.SelectionLength = 0;
            this.txtID.SelectionStart = 0;
            this.txtID.ShortcutsEnabled = true;
            this.txtID.Size = new System.Drawing.Size(208, 23);
            this.txtID.TabIndex = 31;
            this.txtID.UseSelectable = true;
            this.txtID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dataGridViewServicios
            // 
            this.dataGridViewServicios.AllowUserToAddRows = false;
            this.dataGridViewServicios.AllowUserToDeleteRows = false;
            this.dataGridViewServicios.AllowUserToOrderColumns = true;
            this.dataGridViewServicios.AllowUserToResizeRows = false;
            this.dataGridViewServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewServicios.Location = new System.Drawing.Point(456, 134);
            this.dataGridViewServicios.MultiSelect = false;
            this.dataGridViewServicios.Name = "dataGridViewServicios";
            this.dataGridViewServicios.ReadOnly = true;
            this.dataGridViewServicios.ShowEditingIcon = false;
            this.dataGridViewServicios.Size = new System.Drawing.Size(568, 431);
            this.dataGridViewServicios.TabIndex = 27;
            this.dataGridViewServicios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewServicios_CellClick);
            this.dataGridViewServicios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewServicios_CellContentClick);
            // 
            // lblPageNumber
            // 
            this.lblPageNumber.AutoSize = true;
            this.lblPageNumber.Location = new System.Drawing.Point(715, 578);
            this.lblPageNumber.Name = "lblPageNumber";
            this.lblPageNumber.Size = new System.Drawing.Size(68, 19);
            this.lblPageNumber.TabIndex = 52;
            this.lblPageNumber.Text = "Cargando";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(968, 578);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(57, 19);
            this.btnNext.TabIndex = 51;
            this.btnNext.Text = ">";
            this.btnNext.UseSelectable = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(457, 578);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(56, 19);
            this.btnPrevious.TabIndex = 50;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseSelectable = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // ServiciosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 710);
            this.Controls.Add(this.lblPageNumber);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblPrecio);
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
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtNombreServicio);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.dataGridViewServicios);
            this.Name = "ServiciosForm";
            this.Resizable = false;
            this.Text = "Lista de Servicios de Agua";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.ServiciosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServicios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel lblCodigo;
        private MetroFramework.Controls.MetroLabel lblPrecio;
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
        private MetroFramework.Controls.MetroTextBox txtCodigo;
        private MetroFramework.Controls.MetroTextBox txtPrecio;
        private MetroFramework.Controls.MetroTextBox txtNombreServicio;
        private MetroFramework.Controls.MetroTextBox txtID;
        private System.Windows.Forms.DataGridView dataGridViewServicios;
        private MetroFramework.Controls.MetroLabel lblPageNumber;
        private MetroFramework.Controls.MetroButton btnNext;
        private MetroFramework.Controls.MetroButton btnPrevious;
    }
}