namespace SistemaCobroAgua.Vistas
{
    partial class BuscadorClienteForm
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
            this.dataGridViewClientesBuscador = new System.Windows.Forms.DataGridView();
            this.lblPageNumber = new MetroFramework.Controls.MetroLabel();
            this.btnNext = new MetroFramework.Controls.MetroButton();
            this.btnPrevious = new MetroFramework.Controls.MetroButton();
            this.lblID = new MetroFramework.Controls.MetroLabel();
            this.txtID = new MetroFramework.Controls.MetroTextBox();
            this.btnBuscar = new MetroFramework.Controls.MetroButton();
            this.txtBarraBuscar = new MetroFramework.Controls.MetroTextBox();
            this.btnEnviarClienteCaja = new MetroFramework.Controls.MetroButton();
            this.lblApellido = new MetroFramework.Controls.MetroLabel();
            this.lblNombre = new MetroFramework.Controls.MetroLabel();
            this.txtApellido = new MetroFramework.Controls.MetroTextBox();
            this.txtNombre = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientesBuscador)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewClientesBuscador
            // 
            this.dataGridViewClientesBuscador.AllowUserToAddRows = false;
            this.dataGridViewClientesBuscador.AllowUserToDeleteRows = false;
            this.dataGridViewClientesBuscador.AllowUserToResizeRows = false;
            this.dataGridViewClientesBuscador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClientesBuscador.Location = new System.Drawing.Point(37, 242);
            this.dataGridViewClientesBuscador.MultiSelect = false;
            this.dataGridViewClientesBuscador.Name = "dataGridViewClientesBuscador";
            this.dataGridViewClientesBuscador.ReadOnly = true;
            this.dataGridViewClientesBuscador.Size = new System.Drawing.Size(777, 239);
            this.dataGridViewClientesBuscador.TabIndex = 0;
            this.dataGridViewClientesBuscador.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewClientesBuscador_CellClick);
            this.dataGridViewClientesBuscador.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewClientesBuscador_CellContentClick);
            // 
            // lblPageNumber
            // 
            this.lblPageNumber.AutoSize = true;
            this.lblPageNumber.Location = new System.Drawing.Point(382, 507);
            this.lblPageNumber.Name = "lblPageNumber";
            this.lblPageNumber.Size = new System.Drawing.Size(68, 19);
            this.lblPageNumber.TabIndex = 36;
            this.lblPageNumber.Text = "Cargando";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(635, 507);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(57, 19);
            this.btnNext.TabIndex = 35;
            this.btnNext.Text = ">";
            this.btnNext.UseSelectable = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(124, 507);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(56, 19);
            this.btnPrevious.TabIndex = 34;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseSelectable = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(21, 116);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(65, 19);
            this.lblID.TabIndex = 38;
            this.lblID.Text = "Cliente ID";
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
            this.txtID.Location = new System.Drawing.Point(126, 112);
            this.txtID.MaxLength = 32767;
            this.txtID.Name = "txtID";
            this.txtID.PasswordChar = '\0';
            this.txtID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtID.SelectedText = "";
            this.txtID.SelectionLength = 0;
            this.txtID.SelectionStart = 0;
            this.txtID.ShortcutsEnabled = true;
            this.txtID.Size = new System.Drawing.Size(208, 23);
            this.txtID.TabIndex = 37;
            this.txtID.UseSelectable = true;
            this.txtID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(670, 199);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(105, 23);
            this.btnBuscar.TabIndex = 40;
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
            this.txtBarraBuscar.CustomButton.Location = new System.Drawing.Point(203, 1);
            this.txtBarraBuscar.CustomButton.Name = "";
            this.txtBarraBuscar.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBarraBuscar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBarraBuscar.CustomButton.TabIndex = 1;
            this.txtBarraBuscar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBarraBuscar.CustomButton.UseSelectable = true;
            this.txtBarraBuscar.CustomButton.Visible = false;
            this.txtBarraBuscar.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtBarraBuscar.Lines = new string[0];
            this.txtBarraBuscar.Location = new System.Drawing.Point(406, 199);
            this.txtBarraBuscar.MaxLength = 32767;
            this.txtBarraBuscar.Name = "txtBarraBuscar";
            this.txtBarraBuscar.PasswordChar = '\0';
            this.txtBarraBuscar.PromptText = "Buscar cliente...";
            this.txtBarraBuscar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBarraBuscar.SelectedText = "";
            this.txtBarraBuscar.SelectionLength = 0;
            this.txtBarraBuscar.SelectionStart = 0;
            this.txtBarraBuscar.ShortcutsEnabled = true;
            this.txtBarraBuscar.Size = new System.Drawing.Size(225, 23);
            this.txtBarraBuscar.TabIndex = 39;
            this.txtBarraBuscar.UseSelectable = true;
            this.txtBarraBuscar.WaterMark = "Buscar cliente...";
            this.txtBarraBuscar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBarraBuscar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnEnviarClienteCaja
            // 
            this.btnEnviarClienteCaja.Location = new System.Drawing.Point(439, 112);
            this.btnEnviarClienteCaja.Name = "btnEnviarClienteCaja";
            this.btnEnviarClienteCaja.Size = new System.Drawing.Size(145, 23);
            this.btnEnviarClienteCaja.TabIndex = 41;
            this.btnEnviarClienteCaja.Text = "Enviar Cliente a Caja";
            this.btnEnviarClienteCaja.UseSelectable = true;
            this.btnEnviarClienteCaja.Click += new System.EventHandler(this.btnEnviarClienteCaja_Click);
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(28, 203);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(58, 19);
            this.lblApellido.TabIndex = 45;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(27, 162);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(59, 19);
            this.lblNombre.TabIndex = 44;
            this.lblNombre.Text = "Nombre";
            // 
            // txtApellido
            // 
            // 
            // 
            // 
            this.txtApellido.CustomButton.Image = null;
            this.txtApellido.CustomButton.Location = new System.Drawing.Point(186, 1);
            this.txtApellido.CustomButton.Name = "";
            this.txtApellido.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtApellido.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtApellido.CustomButton.TabIndex = 1;
            this.txtApellido.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtApellido.CustomButton.UseSelectable = true;
            this.txtApellido.CustomButton.Visible = false;
            this.txtApellido.Enabled = false;
            this.txtApellido.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtApellido.Lines = new string[0];
            this.txtApellido.Location = new System.Drawing.Point(126, 204);
            this.txtApellido.MaxLength = 32767;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.PasswordChar = '\0';
            this.txtApellido.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtApellido.SelectedText = "";
            this.txtApellido.SelectionLength = 0;
            this.txtApellido.SelectionStart = 0;
            this.txtApellido.ShortcutsEnabled = true;
            this.txtApellido.Size = new System.Drawing.Size(208, 23);
            this.txtApellido.TabIndex = 43;
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
            this.txtNombre.CustomButton.Location = new System.Drawing.Point(186, 1);
            this.txtNombre.CustomButton.Name = "";
            this.txtNombre.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNombre.CustomButton.TabIndex = 1;
            this.txtNombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNombre.CustomButton.UseSelectable = true;
            this.txtNombre.CustomButton.Visible = false;
            this.txtNombre.Enabled = false;
            this.txtNombre.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtNombre.Lines = new string[0];
            this.txtNombre.Location = new System.Drawing.Point(126, 154);
            this.txtNombre.MaxLength = 32767;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNombre.SelectedText = "";
            this.txtNombre.SelectionLength = 0;
            this.txtNombre.SelectionStart = 0;
            this.txtNombre.ShortcutsEnabled = true;
            this.txtNombre.Size = new System.Drawing.Size(208, 23);
            this.txtNombre.TabIndex = 42;
            this.txtNombre.UseSelectable = true;
            this.txtNombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // BuscadorClienteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 556);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnEnviarClienteCaja);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBarraBuscar);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblPageNumber);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.dataGridViewClientesBuscador);
            this.Name = "BuscadorClienteForm";
            this.Resizable = false;
            this.Text = "Buscador de Clientes Para Caja";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.BuscadorClienteForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientesBuscador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewClientesBuscador;
        private MetroFramework.Controls.MetroLabel lblPageNumber;
        private MetroFramework.Controls.MetroButton btnNext;
        private MetroFramework.Controls.MetroButton btnPrevious;
        private MetroFramework.Controls.MetroLabel lblID;
        private MetroFramework.Controls.MetroButton btnBuscar;
        private MetroFramework.Controls.MetroTextBox txtBarraBuscar;
        private MetroFramework.Controls.MetroButton btnEnviarClienteCaja;
        private MetroFramework.Controls.MetroLabel lblApellido;
        private MetroFramework.Controls.MetroLabel lblNombre;
        public MetroFramework.Controls.MetroTextBox txtID;
        public MetroFramework.Controls.MetroTextBox txtApellido;
        public MetroFramework.Controls.MetroTextBox txtNombre;
    }
}