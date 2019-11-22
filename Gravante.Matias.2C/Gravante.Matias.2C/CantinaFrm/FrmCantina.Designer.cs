namespace CantinaFrm
{
    partial class FrmCantina
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCantina));
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtBoxMarca = new System.Windows.Forms.TextBox();
            this.numUpDwContenido = new System.Windows.Forms.NumericUpDown();
            this.cmbBotellaTipo = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.rBtnCerveza = new System.Windows.Forms.RadioButton();
            this.barra1 = new ControlCantina.Barra();
            this.rBtnAgua = new System.Windows.Forms.RadioButton();
            this.lblCapacidad = new System.Windows.Forms.Label();
            this.lblContenido = new System.Windows.Forms.Label();
            this.numUpDwCapacidad = new System.Windows.Forms.NumericUpDown();
            this.lblBotellaTipo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwContenido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwCapacidad)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(180, 416);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 0;
            this.lblMarca.Text = "Marca";
            // 
            // txtBoxMarca
            // 
            this.txtBoxMarca.Location = new System.Drawing.Point(183, 437);
            this.txtBoxMarca.Name = "txtBoxMarca";
            this.txtBoxMarca.Size = new System.Drawing.Size(174, 20);
            this.txtBoxMarca.TabIndex = 1;
            // 
            // numUpDwContenido
            // 
            this.numUpDwContenido.Location = new System.Drawing.Point(295, 497);
            this.numUpDwContenido.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numUpDwContenido.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDwContenido.Name = "numUpDwContenido";
            this.numUpDwContenido.Size = new System.Drawing.Size(52, 20);
            this.numUpDwContenido.TabIndex = 2;
            this.numUpDwContenido.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // cmbBotellaTipo
            // 
            this.cmbBotellaTipo.FormattingEnabled = true;
            this.cmbBotellaTipo.Location = new System.Drawing.Point(398, 436);
            this.cmbBotellaTipo.Name = "cmbBotellaTipo";
            this.cmbBotellaTipo.Size = new System.Drawing.Size(121, 21);
            this.cmbBotellaTipo.TabIndex = 3;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(398, 481);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(121, 36);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // rBtnCerveza
            // 
            this.rBtnCerveza.AutoSize = true;
            this.rBtnCerveza.Location = new System.Drawing.Point(42, 412);
            this.rBtnCerveza.Name = "rBtnCerveza";
            this.rBtnCerveza.Size = new System.Drawing.Size(64, 17);
            this.rBtnCerveza.TabIndex = 5;
            this.rBtnCerveza.TabStop = true;
            this.rBtnCerveza.Text = "Cerveza";
            this.rBtnCerveza.UseVisualStyleBackColor = true;
            // 
            // barra1
            // 
            this.barra1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("barra1.BackgroundImage")));
            this.barra1.Location = new System.Drawing.Point(12, 12);
            this.barra1.Name = "barra1";
            this.barra1.Size = new System.Drawing.Size(551, 368);
            this.barra1.TabIndex = 6;
            // 
            // rBtnAgua
            // 
            this.rBtnAgua.AutoSize = true;
            this.rBtnAgua.Location = new System.Drawing.Point(42, 440);
            this.rBtnAgua.Name = "rBtnAgua";
            this.rBtnAgua.Size = new System.Drawing.Size(50, 17);
            this.rBtnAgua.TabIndex = 7;
            this.rBtnAgua.TabStop = true;
            this.rBtnAgua.Text = "Agua";
            this.rBtnAgua.UseVisualStyleBackColor = true;
            // 
            // lblCapacidad
            // 
            this.lblCapacidad.AutoSize = true;
            this.lblCapacidad.Location = new System.Drawing.Point(180, 481);
            this.lblCapacidad.Name = "lblCapacidad";
            this.lblCapacidad.Size = new System.Drawing.Size(58, 13);
            this.lblCapacidad.TabIndex = 8;
            this.lblCapacidad.Text = "Capacidad";
            // 
            // lblContenido
            // 
            this.lblContenido.AutoSize = true;
            this.lblContenido.Location = new System.Drawing.Point(292, 481);
            this.lblContenido.Name = "lblContenido";
            this.lblContenido.Size = new System.Drawing.Size(55, 13);
            this.lblContenido.TabIndex = 9;
            this.lblContenido.Text = "Contenido";
            // 
            // numUpDwCapacidad
            // 
            this.numUpDwCapacidad.Location = new System.Drawing.Point(183, 497);
            this.numUpDwCapacidad.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numUpDwCapacidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDwCapacidad.Name = "numUpDwCapacidad";
            this.numUpDwCapacidad.Size = new System.Drawing.Size(55, 20);
            this.numUpDwCapacidad.TabIndex = 10;
            this.numUpDwCapacidad.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // lblBotellaTipo
            // 
            this.lblBotellaTipo.AutoSize = true;
            this.lblBotellaTipo.Location = new System.Drawing.Point(395, 416);
            this.lblBotellaTipo.Name = "lblBotellaTipo";
            this.lblBotellaTipo.Size = new System.Drawing.Size(63, 13);
            this.lblBotellaTipo.TabIndex = 11;
            this.lblBotellaTipo.Text = "Botella Tipo";
            // 
            // FrmCantina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 548);
            this.Controls.Add(this.lblBotellaTipo);
            this.Controls.Add(this.numUpDwCapacidad);
            this.Controls.Add(this.lblContenido);
            this.Controls.Add(this.lblCapacidad);
            this.Controls.Add(this.rBtnAgua);
            this.Controls.Add(this.barra1);
            this.Controls.Add(this.rBtnCerveza);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cmbBotellaTipo);
            this.Controls.Add(this.numUpDwContenido);
            this.Controls.Add(this.txtBoxMarca);
            this.Controls.Add(this.lblMarca);
            this.Name = "FrmCantina";
            this.Text = "Alumno Matias Gravante";
            this.Load += new System.EventHandler(this.FrmCantina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwContenido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwCapacidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtBoxMarca;
        private System.Windows.Forms.NumericUpDown numUpDwContenido;
        private System.Windows.Forms.ComboBox cmbBotellaTipo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.RadioButton rBtnCerveza;
        private ControlCantina.Barra barra1;
        private System.Windows.Forms.RadioButton rBtnAgua;
        private System.Windows.Forms.Label lblCapacidad;
        private System.Windows.Forms.Label lblContenido;
        private System.Windows.Forms.NumericUpDown numUpDwCapacidad;
        private System.Windows.Forms.Label lblBotellaTipo;
    }
}

