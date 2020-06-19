namespace SistemaCobroAgua.Vistas
{
    partial class TarifasResidencialesForm
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
            this.lblTarifaAlcantarillado = new MetroFramework.Controls.MetroLabel();
            this.lblTarifaAcueducto = new MetroFramework.Controls.MetroLabel();
            this.lblRangoConsumeM3 = new MetroFramework.Controls.MetroLabel();
            this.lblID = new MetroFramework.Controls.MetroLabel();
            this.mtMenu = new MetroFramework.Controls.MetroTile();
            this.mtCaja = new MetroFramework.Controls.MetroTile();
            this.mtRefrescar = new MetroFramework.Controls.MetroTile();
            this.mtBorrar = new MetroFramework.Controls.MetroTile();
            this.mtEditar = new MetroFramework.Controls.MetroTile();
            this.mtGuardar = new MetroFramework.Controls.MetroTile();
            this.btnBuscar = new MetroFramework.Controls.MetroButton();
            this.txtBarraBuscar = new MetroFramework.Controls.MetroTextBox();
            this.txtTarifaAlcantarillado = new MetroFramework.Controls.MetroTextBox();
            this.txtTarifaAcueductoM3 = new MetroFramework.Controls.MetroTextBox();
            this.txtRangoConsumoM3 = new MetroFramework.Controls.MetroTextBox();
            this.txtID = new MetroFramework.Controls.MetroTextBox();
            this.dataGridViewTarifasResidenciales = new System.Windows.Forms.DataGridView();
            this.lblPageNumber = new MetroFramework.Controls.MetroLabel();
            this.btnNext = new MetroFramework.Controls.MetroButton();
            this.btnPrevious = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTarifasResidenciales)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTarifaAlcantarillado
            // 
            this.lblTarifaAlcantarillado.AutoSize = true;
            this.lblTarifaAlcantarillado.Location = new System.Drawing.Point(92, 305);
            this.lblTarifaAlcantarillado.Name = "lblTarifaAlcantarillado";
            this.lblTarifaAlcantarillado.Size = new System.Drawing.Size(124, 19);
            this.lblTarifaAlcantarillado.TabIndex = 69;
            this.lblTarifaAlcantarillado.Text = "Tarifa Alcantarillado";
            // 
            // lblTarifaAcueducto
            // 
            this.lblTarifaAcueducto.AutoSize = true;
            this.lblTarifaAcueducto.Location = new System.Drawing.Point(13, 256);
            this.lblTarifaAcueducto.Name = "lblTarifaAcueducto";
            this.lblTarifaAcueducto.Size = new System.Drawing.Size(203, 19);
            this.lblTarifaAcueducto.TabIndex = 68;
            this.lblTarifaAcueducto.Text = "Tarifa Acueducto (Precio) por M3";
            // 
            // lblRangoConsumeM3
            // 
            this.lblRangoConsumeM3.AutoSize = true;
            this.lblRangoConsumeM3.Location = new System.Drawing.Point(67, 202);
            this.lblRangoConsumeM3.Name = "lblRangoConsumeM3";
            this.lblRangoConsumeM3.Size = new System.Drawing.Size(149, 19);
            this.lblRangoConsumeM3.TabIndex = 67;
            this.lblRangoConsumeM3.Text = "Rango de Consumo M3";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(195, 152);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 19);
            this.lblID.TabIndex = 66;
            this.lblID.Text = "ID";
            // 
            // mtMenu
            // 
            this.mtMenu.ActiveControl = null;
            this.mtMenu.Location = new System.Drawing.Point(306, 569);
            this.mtMenu.Name = "mtMenu";
            this.mtMenu.Size = new System.Drawing.Size(96, 86);
            this.mtMenu.TabIndex = 65;
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
            this.mtCaja.Location = new System.Drawing.Point(187, 569);
            this.mtCaja.Name = "mtCaja";
            this.mtCaja.Size = new System.Drawing.Size(96, 86);
            this.mtCaja.TabIndex = 64;
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
            this.mtRefrescar.Location = new System.Drawing.Point(63, 569);
            this.mtRefrescar.Name = "mtRefrescar";
            this.mtRefrescar.Size = new System.Drawing.Size(96, 86);
            this.mtRefrescar.TabIndex = 63;
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
            this.mtBorrar.Location = new System.Drawing.Point(306, 460);
            this.mtBorrar.Name = "mtBorrar";
            this.mtBorrar.Size = new System.Drawing.Size(96, 86);
            this.mtBorrar.TabIndex = 62;
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
            this.mtEditar.Location = new System.Drawing.Point(187, 460);
            this.mtEditar.Name = "mtEditar";
            this.mtEditar.Size = new System.Drawing.Size(96, 86);
            this.mtEditar.TabIndex = 61;
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
            this.mtGuardar.Location = new System.Drawing.Point(63, 460);
            this.mtGuardar.Name = "mtGuardar";
            this.mtGuardar.Size = new System.Drawing.Size(96, 86);
            this.mtGuardar.TabIndex = 60;
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
            this.btnBuscar.Location = new System.Drawing.Point(953, 71);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(85, 23);
            this.btnBuscar.TabIndex = 59;
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
            this.txtBarraBuscar.Location = new System.Drawing.Point(470, 71);
            this.txtBarraBuscar.MaxLength = 32767;
            this.txtBarraBuscar.Name = "txtBarraBuscar";
            this.txtBarraBuscar.PasswordChar = '\0';
            this.txtBarraBuscar.PromptText = "Buscar rango de consumo...";
            this.txtBarraBuscar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBarraBuscar.SelectedText = "";
            this.txtBarraBuscar.SelectionLength = 0;
            this.txtBarraBuscar.SelectionStart = 0;
            this.txtBarraBuscar.ShortcutsEnabled = true;
            this.txtBarraBuscar.Size = new System.Drawing.Size(402, 23);
            this.txtBarraBuscar.TabIndex = 58;
            this.txtBarraBuscar.UseSelectable = true;
            this.txtBarraBuscar.WaterMark = "Buscar rango de consumo...";
            this.txtBarraBuscar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBarraBuscar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtTarifaAlcantarillado
            // 
            // 
            // 
            // 
            this.txtTarifaAlcantarillado.CustomButton.Image = null;
            this.txtTarifaAlcantarillado.CustomButton.Location = new System.Drawing.Point(152, 1);
            this.txtTarifaAlcantarillado.CustomButton.Name = "";
            this.txtTarifaAlcantarillado.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.txtTarifaAlcantarillado.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTarifaAlcantarillado.CustomButton.TabIndex = 1;
            this.txtTarifaAlcantarillado.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTarifaAlcantarillado.CustomButton.UseSelectable = true;
            this.txtTarifaAlcantarillado.CustomButton.Visible = false;
            this.txtTarifaAlcantarillado.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtTarifaAlcantarillado.Lines = new string[0];
            this.txtTarifaAlcantarillado.Location = new System.Drawing.Point(232, 301);
            this.txtTarifaAlcantarillado.MaxLength = 32767;
            this.txtTarifaAlcantarillado.Name = "txtTarifaAlcantarillado";
            this.txtTarifaAlcantarillado.PasswordChar = '\0';
            this.txtTarifaAlcantarillado.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTarifaAlcantarillado.SelectedText = "";
            this.txtTarifaAlcantarillado.SelectionLength = 0;
            this.txtTarifaAlcantarillado.SelectionStart = 0;
            this.txtTarifaAlcantarillado.ShortcutsEnabled = true;
            this.txtTarifaAlcantarillado.Size = new System.Drawing.Size(170, 19);
            this.txtTarifaAlcantarillado.TabIndex = 57;
            this.txtTarifaAlcantarillado.UseSelectable = true;
            this.txtTarifaAlcantarillado.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTarifaAlcantarillado.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtTarifaAcueductoM3
            // 
            // 
            // 
            // 
            this.txtTarifaAcueductoM3.CustomButton.Image = null;
            this.txtTarifaAcueductoM3.CustomButton.Location = new System.Drawing.Point(152, 1);
            this.txtTarifaAcueductoM3.CustomButton.Name = "";
            this.txtTarifaAcueductoM3.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.txtTarifaAcueductoM3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTarifaAcueductoM3.CustomButton.TabIndex = 1;
            this.txtTarifaAcueductoM3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTarifaAcueductoM3.CustomButton.UseSelectable = true;
            this.txtTarifaAcueductoM3.CustomButton.Visible = false;
            this.txtTarifaAcueductoM3.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtTarifaAcueductoM3.Lines = new string[0];
            this.txtTarifaAcueductoM3.Location = new System.Drawing.Point(232, 256);
            this.txtTarifaAcueductoM3.MaxLength = 32767;
            this.txtTarifaAcueductoM3.Name = "txtTarifaAcueductoM3";
            this.txtTarifaAcueductoM3.PasswordChar = '\0';
            this.txtTarifaAcueductoM3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTarifaAcueductoM3.SelectedText = "";
            this.txtTarifaAcueductoM3.SelectionLength = 0;
            this.txtTarifaAcueductoM3.SelectionStart = 0;
            this.txtTarifaAcueductoM3.ShortcutsEnabled = true;
            this.txtTarifaAcueductoM3.Size = new System.Drawing.Size(170, 19);
            this.txtTarifaAcueductoM3.TabIndex = 56;
            this.txtTarifaAcueductoM3.UseSelectable = true;
            this.txtTarifaAcueductoM3.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTarifaAcueductoM3.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtRangoConsumoM3
            // 
            // 
            // 
            // 
            this.txtRangoConsumoM3.CustomButton.Image = null;
            this.txtRangoConsumoM3.CustomButton.Location = new System.Drawing.Point(152, 1);
            this.txtRangoConsumoM3.CustomButton.Name = "";
            this.txtRangoConsumoM3.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.txtRangoConsumoM3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRangoConsumoM3.CustomButton.TabIndex = 1;
            this.txtRangoConsumoM3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRangoConsumoM3.CustomButton.UseSelectable = true;
            this.txtRangoConsumoM3.CustomButton.Visible = false;
            this.txtRangoConsumoM3.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtRangoConsumoM3.Lines = new string[0];
            this.txtRangoConsumoM3.Location = new System.Drawing.Point(232, 202);
            this.txtRangoConsumoM3.MaxLength = 32767;
            this.txtRangoConsumoM3.Name = "txtRangoConsumoM3";
            this.txtRangoConsumoM3.PasswordChar = '\0';
            this.txtRangoConsumoM3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRangoConsumoM3.SelectedText = "";
            this.txtRangoConsumoM3.SelectionLength = 0;
            this.txtRangoConsumoM3.SelectionStart = 0;
            this.txtRangoConsumoM3.ShortcutsEnabled = true;
            this.txtRangoConsumoM3.Size = new System.Drawing.Size(170, 19);
            this.txtRangoConsumoM3.TabIndex = 55;
            this.txtRangoConsumoM3.UseSelectable = true;
            this.txtRangoConsumoM3.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRangoConsumoM3.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtID
            // 
            // 
            // 
            // 
            this.txtID.CustomButton.Image = null;
            this.txtID.CustomButton.Location = new System.Drawing.Point(152, 1);
            this.txtID.CustomButton.Name = "";
            this.txtID.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.txtID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtID.CustomButton.TabIndex = 1;
            this.txtID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtID.CustomButton.UseSelectable = true;
            this.txtID.CustomButton.Visible = false;
            this.txtID.Enabled = false;
            this.txtID.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtID.Lines = new string[0];
            this.txtID.Location = new System.Drawing.Point(232, 152);
            this.txtID.MaxLength = 32767;
            this.txtID.Name = "txtID";
            this.txtID.PasswordChar = '\0';
            this.txtID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtID.SelectedText = "";
            this.txtID.SelectionLength = 0;
            this.txtID.SelectionStart = 0;
            this.txtID.ShortcutsEnabled = true;
            this.txtID.Size = new System.Drawing.Size(170, 19);
            this.txtID.TabIndex = 54;
            this.txtID.UseSelectable = true;
            this.txtID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dataGridViewTarifasResidenciales
            // 
            this.dataGridViewTarifasResidenciales.AllowUserToAddRows = false;
            this.dataGridViewTarifasResidenciales.AllowUserToDeleteRows = false;
            this.dataGridViewTarifasResidenciales.AllowUserToOrderColumns = true;
            this.dataGridViewTarifasResidenciales.AllowUserToResizeRows = false;
            this.dataGridViewTarifasResidenciales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTarifasResidenciales.Location = new System.Drawing.Point(470, 125);
            this.dataGridViewTarifasResidenciales.MultiSelect = false;
            this.dataGridViewTarifasResidenciales.Name = "dataGridViewTarifasResidenciales";
            this.dataGridViewTarifasResidenciales.ReadOnly = true;
            this.dataGridViewTarifasResidenciales.ShowEditingIcon = false;
            this.dataGridViewTarifasResidenciales.Size = new System.Drawing.Size(568, 431);
            this.dataGridViewTarifasResidenciales.TabIndex = 50;
            this.dataGridViewTarifasResidenciales.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTarifasResidenciales_CellClick);
            this.dataGridViewTarifasResidenciales.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTarifasResidenciales_CellContentClick);
            // 
            // lblPageNumber
            // 
            this.lblPageNumber.AutoSize = true;
            this.lblPageNumber.Location = new System.Drawing.Point(729, 569);
            this.lblPageNumber.Name = "lblPageNumber";
            this.lblPageNumber.Size = new System.Drawing.Size(68, 19);
            this.lblPageNumber.TabIndex = 72;
            this.lblPageNumber.Text = "Cargando";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(982, 569);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(57, 19);
            this.btnNext.TabIndex = 71;
            this.btnNext.Text = ">";
            this.btnNext.UseSelectable = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(471, 569);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(56, 19);
            this.btnPrevious.TabIndex = 70;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseSelectable = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // TarifasResidencialesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 677);
            this.Controls.Add(this.lblPageNumber);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.lblTarifaAlcantarillado);
            this.Controls.Add(this.lblTarifaAcueducto);
            this.Controls.Add(this.lblRangoConsumeM3);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.mtMenu);
            this.Controls.Add(this.mtCaja);
            this.Controls.Add(this.mtRefrescar);
            this.Controls.Add(this.mtBorrar);
            this.Controls.Add(this.mtEditar);
            this.Controls.Add(this.mtGuardar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBarraBuscar);
            this.Controls.Add(this.txtTarifaAlcantarillado);
            this.Controls.Add(this.txtTarifaAcueductoM3);
            this.Controls.Add(this.txtRangoConsumoM3);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.dataGridViewTarifasResidenciales);
            this.Name = "TarifasResidencialesForm";
            this.Resizable = false;
            this.Text = "Tarifas Residenciales";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.TarifaResidencialesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTarifasResidenciales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblTarifaAlcantarillado;
        private MetroFramework.Controls.MetroLabel lblTarifaAcueducto;
        private MetroFramework.Controls.MetroLabel lblRangoConsumeM3;
        private MetroFramework.Controls.MetroLabel lblID;
        private MetroFramework.Controls.MetroTile mtMenu;
        private MetroFramework.Controls.MetroTile mtCaja;
        private MetroFramework.Controls.MetroTile mtRefrescar;
        private MetroFramework.Controls.MetroTile mtBorrar;
        private MetroFramework.Controls.MetroTile mtEditar;
        private MetroFramework.Controls.MetroTile mtGuardar;
        private MetroFramework.Controls.MetroButton btnBuscar;
        private MetroFramework.Controls.MetroTextBox txtBarraBuscar;
        private MetroFramework.Controls.MetroTextBox txtTarifaAlcantarillado;
        private MetroFramework.Controls.MetroTextBox txtTarifaAcueductoM3;
        private MetroFramework.Controls.MetroTextBox txtRangoConsumoM3;
        private MetroFramework.Controls.MetroTextBox txtID;
        private System.Windows.Forms.DataGridView dataGridViewTarifasResidenciales;
        private MetroFramework.Controls.MetroLabel lblPageNumber;
        private MetroFramework.Controls.MetroButton btnNext;
        private MetroFramework.Controls.MetroButton btnPrevious;
    }
}