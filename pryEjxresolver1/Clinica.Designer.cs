namespace pryEjxresolver1
{
    partial class frmClinica
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
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.cmbEspecialidadConsulta = new System.Windows.Forms.ComboBox();
            this.lblConsultarEspecialidad = new System.Windows.Forms.Button();
            this.mrcConsulta = new System.Windows.Forms.GroupBox();
            this.mrcRegistroEspecialidad = new System.Windows.Forms.GroupBox();
            this.txtAgregarEspecialidad = new System.Windows.Forms.TextBox();
            this.lblEspecialidadRegistro = new System.Windows.Forms.Label();
            this.btnRegistrarEspecialidad = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbEspecialiadMedico = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRegistrarMedico = new System.Windows.Forms.Button();
            this.lstConsulta = new System.Windows.Forms.ListBox();
            this.mrcConsulta.SuspendLayout();
            this.mrcRegistroEspecialidad.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.Location = new System.Drawing.Point(4, 24);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(157, 16);
            this.lblEspecialidad.TabIndex = 0;
            this.lblEspecialidad.Text = "Seleccione especialidad";
            // 
            // cmbEspecialidadConsulta
            // 
            this.cmbEspecialidadConsulta.FormattingEnabled = true;
            this.cmbEspecialidadConsulta.Items.AddRange(new object[] {
            ""});
            this.cmbEspecialidadConsulta.Location = new System.Drawing.Point(167, 21);
            this.cmbEspecialidadConsulta.Name = "cmbEspecialidadConsulta";
            this.cmbEspecialidadConsulta.Size = new System.Drawing.Size(121, 24);
            this.cmbEspecialidadConsulta.TabIndex = 1;
            // 
            // lblConsultarEspecialidad
            // 
            this.lblConsultarEspecialidad.Location = new System.Drawing.Point(167, 61);
            this.lblConsultarEspecialidad.Name = "lblConsultarEspecialidad";
            this.lblConsultarEspecialidad.Size = new System.Drawing.Size(121, 23);
            this.lblConsultarEspecialidad.TabIndex = 2;
            this.lblConsultarEspecialidad.Text = "Consultar";
            this.lblConsultarEspecialidad.UseVisualStyleBackColor = true;
            this.lblConsultarEspecialidad.Click += new System.EventHandler(this.lblConsultarEspecialidad_Click);
            // 
            // mrcConsulta
            // 
            this.mrcConsulta.Controls.Add(this.lstConsulta);
            this.mrcConsulta.Controls.Add(this.lblEspecialidad);
            this.mrcConsulta.Controls.Add(this.lblConsultarEspecialidad);
            this.mrcConsulta.Controls.Add(this.cmbEspecialidadConsulta);
            this.mrcConsulta.Location = new System.Drawing.Point(26, 366);
            this.mrcConsulta.Name = "mrcConsulta";
            this.mrcConsulta.Size = new System.Drawing.Size(786, 264);
            this.mrcConsulta.TabIndex = 4;
            this.mrcConsulta.TabStop = false;
            this.mrcConsulta.Text = "Consulta";
            // 
            // mrcRegistroEspecialidad
            // 
            this.mrcRegistroEspecialidad.Controls.Add(this.txtAgregarEspecialidad);
            this.mrcRegistroEspecialidad.Controls.Add(this.lblEspecialidadRegistro);
            this.mrcRegistroEspecialidad.Controls.Add(this.btnRegistrarEspecialidad);
            this.mrcRegistroEspecialidad.Location = new System.Drawing.Point(26, 27);
            this.mrcRegistroEspecialidad.Name = "mrcRegistroEspecialidad";
            this.mrcRegistroEspecialidad.Size = new System.Drawing.Size(407, 104);
            this.mrcRegistroEspecialidad.TabIndex = 5;
            this.mrcRegistroEspecialidad.TabStop = false;
            this.mrcRegistroEspecialidad.Text = "Registro Especialidad";
            // 
            // txtAgregarEspecialidad
            // 
            this.txtAgregarEspecialidad.Location = new System.Drawing.Point(177, 29);
            this.txtAgregarEspecialidad.Name = "txtAgregarEspecialidad";
            this.txtAgregarEspecialidad.Size = new System.Drawing.Size(100, 22);
            this.txtAgregarEspecialidad.TabIndex = 13;
            // 
            // lblEspecialidadRegistro
            // 
            this.lblEspecialidadRegistro.AutoSize = true;
            this.lblEspecialidadRegistro.Location = new System.Drawing.Point(16, 32);
            this.lblEspecialidadRegistro.Name = "lblEspecialidadRegistro";
            this.lblEspecialidadRegistro.Size = new System.Drawing.Size(142, 16);
            this.lblEspecialidadRegistro.TabIndex = 9;
            this.lblEspecialidadRegistro.Text = "Agregue Especialidad";
            // 
            // btnRegistrarEspecialidad
            // 
            this.btnRegistrarEspecialidad.Location = new System.Drawing.Point(177, 67);
            this.btnRegistrarEspecialidad.Name = "btnRegistrarEspecialidad";
            this.btnRegistrarEspecialidad.Size = new System.Drawing.Size(100, 22);
            this.btnRegistrarEspecialidad.TabIndex = 10;
            this.btnRegistrarEspecialidad.Text = "Registrar";
            this.btnRegistrarEspecialidad.UseVisualStyleBackColor = true;
            this.btnRegistrarEspecialidad.Click += new System.EventHandler(this.btnRegistrarEspecialidad_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbEspecialiadMedico);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.txtMatricula);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnRegistrarMedico);
            this.groupBox1.Location = new System.Drawing.Point(26, 153);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(407, 196);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro Medico";
            // 
            // cmbEspecialiadMedico
            // 
            this.cmbEspecialiadMedico.FormattingEnabled = true;
            this.cmbEspecialiadMedico.Location = new System.Drawing.Point(123, 139);
            this.cmbEspecialiadMedico.Name = "cmbEspecialiadMedico";
            this.cmbEspecialiadMedico.Size = new System.Drawing.Size(100, 24);
            this.cmbEspecialiadMedico.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(123, 82);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 22);
            this.txtNombre.TabIndex = 14;
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(123, 29);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(100, 22);
            this.txtMatricula.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Especialidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Nombre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Matricula";
            // 
            // btnRegistrarMedico
            // 
            this.btnRegistrarMedico.Location = new System.Drawing.Point(267, 141);
            this.btnRegistrarMedico.Name = "btnRegistrarMedico";
            this.btnRegistrarMedico.Size = new System.Drawing.Size(78, 22);
            this.btnRegistrarMedico.TabIndex = 10;
            this.btnRegistrarMedico.Text = "Registrar";
            this.btnRegistrarMedico.UseVisualStyleBackColor = true;
            this.btnRegistrarMedico.Click += new System.EventHandler(this.btnRegistrarMedico_Click);
            // 
            // lstConsulta
            // 
            this.lstConsulta.FormattingEnabled = true;
            this.lstConsulta.ItemHeight = 16;
            this.lstConsulta.Location = new System.Drawing.Point(312, 21);
            this.lstConsulta.Name = "lstConsulta";
            this.lstConsulta.Size = new System.Drawing.Size(455, 228);
            this.lstConsulta.TabIndex = 17;
            // 
            // frmClinica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 712);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mrcRegistroEspecialidad);
            this.Controls.Add(this.mrcConsulta);
            this.Name = "frmClinica";
            this.Text = "Clinica El Sol";
            this.mrcConsulta.ResumeLayout(false);
            this.mrcConsulta.PerformLayout();
            this.mrcRegistroEspecialidad.ResumeLayout(false);
            this.mrcRegistroEspecialidad.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.ComboBox cmbEspecialidadConsulta;
        private System.Windows.Forms.Button lblConsultarEspecialidad;
        private System.Windows.Forms.GroupBox mrcConsulta;
        private System.Windows.Forms.GroupBox mrcRegistroEspecialidad;
        private System.Windows.Forms.TextBox txtAgregarEspecialidad;
        private System.Windows.Forms.Label lblEspecialidadRegistro;
        private System.Windows.Forms.Button btnRegistrarEspecialidad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbEspecialiadMedico;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRegistrarMedico;
        private System.Windows.Forms.ListBox lstConsulta;
    }
}

