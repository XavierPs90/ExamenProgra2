
namespace ExamenPractico2
{
    partial class FormRegistroPacientes
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
            this.dataGridViewPacientes = new System.Windows.Forms.DataGridView();
            this.btnRegistraPaciente = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblGrupoRiesgo = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblCedula = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.lblRegistrarPacientes = new System.Windows.Forms.Label();
            this.comboBoxGrupoRiesgo = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPacientes
            // 
            this.dataGridViewPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPacientes.Location = new System.Drawing.Point(170, 106);
            this.dataGridViewPacientes.Name = "dataGridViewPacientes";
            this.dataGridViewPacientes.ReadOnly = true;
            this.dataGridViewPacientes.Size = new System.Drawing.Size(592, 229);
            this.dataGridViewPacientes.TabIndex = 0;
            this.dataGridViewPacientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPacientes_CellClick);
            // 
            // btnRegistraPaciente
            // 
            this.btnRegistraPaciente.Location = new System.Drawing.Point(70, 361);
            this.btnRegistraPaciente.Name = "btnRegistraPaciente";
            this.btnRegistraPaciente.Size = new System.Drawing.Size(163, 50);
            this.btnRegistraPaciente.TabIndex = 1;
            this.btnRegistraPaciente.Text = "Registrar paciente";
            this.btnRegistraPaciente.UseVisualStyleBackColor = true;
            this.btnRegistraPaciente.Click += new System.EventHandler(this.btnRegistraPaciente_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(568, 361);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(163, 50);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblGrupoRiesgo
            // 
            this.lblGrupoRiesgo.AutoSize = true;
            this.lblGrupoRiesgo.Location = new System.Drawing.Point(30, 299);
            this.lblGrupoRiesgo.Name = "lblGrupoRiesgo";
            this.lblGrupoRiesgo.Size = new System.Drawing.Size(82, 13);
            this.lblGrupoRiesgo.TabIndex = 17;
            this.lblGrupoRiesgo.Text = "Grupo de riesgo";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(30, 237);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(32, 13);
            this.lblEdad.TabIndex = 15;
            this.lblEdad.Text = "Edad";
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(33, 253);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(117, 20);
            this.txtEdad.TabIndex = 14;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(30, 172);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(105, 13);
            this.lblNombre.TabIndex = 13;
            this.lblNombre.Text = "Nombre del paciente";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(33, 188);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(117, 20);
            this.txtNombre.TabIndex = 12;
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Location = new System.Drawing.Point(30, 106);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(40, 13);
            this.lblCedula.TabIndex = 11;
            this.lblCedula.Text = "Cedula";
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(33, 122);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(117, 20);
            this.txtCedula.TabIndex = 10;
            // 
            // lblRegistrarPacientes
            // 
            this.lblRegistrarPacientes.AutoSize = true;
            this.lblRegistrarPacientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrarPacientes.Location = new System.Drawing.Point(26, 22);
            this.lblRegistrarPacientes.Name = "lblRegistrarPacientes";
            this.lblRegistrarPacientes.Size = new System.Drawing.Size(359, 42);
            this.lblRegistrarPacientes.TabIndex = 9;
            this.lblRegistrarPacientes.Text = "Registrar pacientes";
            // 
            // comboBoxGrupoRiesgo
            // 
            this.comboBoxGrupoRiesgo.FormattingEnabled = true;
            this.comboBoxGrupoRiesgo.Items.AddRange(new object[] {
            "Alto ",
            "Medio",
            "Bajo"});
            this.comboBoxGrupoRiesgo.Location = new System.Drawing.Point(33, 315);
            this.comboBoxGrupoRiesgo.Name = "comboBoxGrupoRiesgo";
            this.comboBoxGrupoRiesgo.Size = new System.Drawing.Size(117, 21);
            this.comboBoxGrupoRiesgo.TabIndex = 18;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(325, 361);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(163, 50);
            this.btnEliminar.TabIndex = 19;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // FormRegistroPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.comboBoxGrupoRiesgo);
            this.Controls.Add(this.lblGrupoRiesgo);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblCedula);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.lblRegistrarPacientes);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnRegistraPaciente);
            this.Controls.Add(this.dataGridViewPacientes);
            this.Name = "FormRegistroPacientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormRegistroPacientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPacientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPacientes;
        private System.Windows.Forms.Button btnRegistraPaciente;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblGrupoRiesgo;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label lblRegistrarPacientes;
        private System.Windows.Forms.ComboBox comboBoxGrupoRiesgo;
        private System.Windows.Forms.Button btnEliminar;
    }
}

