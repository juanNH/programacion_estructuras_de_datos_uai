namespace WindowsFormsApp1.tp4
{
    partial class Ej1tp4
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
            this.listaPacientes = new System.Windows.Forms.ListBox();
            this.codigoBox = new System.Windows.Forms.TextBox();
            this.registrarButton = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.nombreBox = new System.Windows.Forms.TextBox();
            this.boxTelefono = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Apellido = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nombresBox = new System.Windows.Forms.TextBox();
            this.codigo = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.apellidoBox = new System.Windows.Forms.TextBox();
            this.telefonoBox = new System.Windows.Forms.TextBox();
            this.buttonRegistrar = new System.Windows.Forms.Button();
            this.eliminarButton = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonEditarPaciente = new System.Windows.Forms.Button();
            this.buttonCancelarEditar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listaPacientes
            // 
            this.listaPacientes.FormattingEnabled = true;
            this.listaPacientes.Location = new System.Drawing.Point(60, 44);
            this.listaPacientes.Name = "listaPacientes";
            this.listaPacientes.Size = new System.Drawing.Size(120, 186);
            this.listaPacientes.TabIndex = 0;
            // 
            // codigoBox
            // 
            this.codigoBox.Location = new System.Drawing.Point(386, 44);
            this.codigoBox.Name = "codigoBox";
            this.codigoBox.Size = new System.Drawing.Size(155, 20);
            this.codigoBox.TabIndex = 1;
            // 
            // registrarButton
            // 
            this.registrarButton.Location = new System.Drawing.Point(426, 208);
            this.registrarButton.Name = "registrarButton";
            this.registrarButton.Size = new System.Drawing.Size(75, 23);
            this.registrarButton.TabIndex = 2;
            this.registrarButton.Text = "Registrar";
            this.registrarButton.UseVisualStyleBackColor = true;
            this.registrarButton.Click += new System.EventHandler(this.registrarButton_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(226, 63);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(75, 23);
            this.buttonEliminar.TabIndex = 3;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // nombreBox
            // 
            this.nombreBox.Location = new System.Drawing.Point(386, 89);
            this.nombreBox.Name = "nombreBox";
            this.nombreBox.Size = new System.Drawing.Size(155, 20);
            this.nombreBox.TabIndex = 5;
            // 
            // boxTelefono
            // 
            this.boxTelefono.Location = new System.Drawing.Point(386, 167);
            this.boxTelefono.Name = "boxTelefono";
            this.boxTelefono.Size = new System.Drawing.Size(155, 20);
            this.boxTelefono.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(383, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Codigo: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(383, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nombres: ";
            // 
            // Apellido
            // 
            this.Apellido.AutoSize = true;
            this.Apellido.Location = new System.Drawing.Point(383, 112);
            this.Apellido.Name = "Apellido";
            this.Apellido.Size = new System.Drawing.Size(44, 13);
            this.Apellido.TabIndex = 9;
            this.Apellido.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(383, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "telefono";
            // 
            // nombresBox
            // 
            this.nombresBox.Location = new System.Drawing.Point(279, 83);
            this.nombresBox.Name = "nombresBox";
            this.nombresBox.Size = new System.Drawing.Size(100, 20);
            this.nombresBox.TabIndex = 4;
            // 
            // codigo
            // 
            this.codigo.Location = new System.Drawing.Point(279, 44);
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(100, 20);
            this.codigo.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(279, 118);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(276, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Apellido";
            // 
            // apellidoBox
            // 
            this.apellidoBox.Location = new System.Drawing.Point(386, 128);
            this.apellidoBox.Name = "apellidoBox";
            this.apellidoBox.Size = new System.Drawing.Size(155, 20);
            this.apellidoBox.TabIndex = 11;
            // 
            // telefonoBox
            // 
            this.telefonoBox.Location = new System.Drawing.Point(302, 282);
            this.telefonoBox.Name = "telefonoBox";
            this.telefonoBox.Size = new System.Drawing.Size(100, 20);
            this.telefonoBox.TabIndex = 6;
            // 
            // buttonRegistrar
            // 
            this.buttonRegistrar.Location = new System.Drawing.Point(543, 116);
            this.buttonRegistrar.Name = "buttonRegistrar";
            this.buttonRegistrar.Size = new System.Drawing.Size(75, 23);
            this.buttonRegistrar.TabIndex = 2;
            this.buttonRegistrar.Text = "button1";
            this.buttonRegistrar.UseVisualStyleBackColor = true;
            // 
            // eliminarButton
            // 
            this.eliminarButton.Location = new System.Drawing.Point(543, 216);
            this.eliminarButton.Name = "eliminarButton";
            this.eliminarButton.Size = new System.Drawing.Size(75, 23);
            this.eliminarButton.TabIndex = 3;
            this.eliminarButton.Text = "Eliminar";
            this.eliminarButton.UseVisualStyleBackColor = true;
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(226, 107);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(75, 23);
            this.buttonEditar.TabIndex = 12;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonEditarPaciente
            // 
            this.buttonEditarPaciente.Location = new System.Drawing.Point(475, 237);
            this.buttonEditarPaciente.Name = "buttonEditarPaciente";
            this.buttonEditarPaciente.Size = new System.Drawing.Size(66, 47);
            this.buttonEditarPaciente.TabIndex = 13;
            this.buttonEditarPaciente.Text = "Editar paciente";
            this.buttonEditarPaciente.UseVisualStyleBackColor = true;
            this.buttonEditarPaciente.Visible = false;
            this.buttonEditarPaciente.Click += new System.EventHandler(this.buttonEditarPaciente_Click);
            // 
            // buttonCancelarEditar
            // 
            this.buttonCancelarEditar.Location = new System.Drawing.Point(385, 237);
            this.buttonCancelarEditar.Name = "buttonCancelarEditar";
            this.buttonCancelarEditar.Size = new System.Drawing.Size(71, 47);
            this.buttonCancelarEditar.TabIndex = 14;
            this.buttonCancelarEditar.Text = "cancelar edicion";
            this.buttonCancelarEditar.UseVisualStyleBackColor = true;
            this.buttonCancelarEditar.Visible = false;
            this.buttonCancelarEditar.Click += new System.EventHandler(this.buttonCancelarEditar_Click);
            // 
            // Ej1tp4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCancelarEditar);
            this.Controls.Add(this.buttonEditarPaciente);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.apellidoBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Apellido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boxTelefono);
            this.Controls.Add(this.nombreBox);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.registrarButton);
            this.Controls.Add(this.codigoBox);
            this.Controls.Add(this.listaPacientes);
            this.Name = "Ej1tp4";
            this.Text = "Ej1tp4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listaPacientes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox codigoBox;
        private System.Windows.Forms.Button registrarButton;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.TextBox nombreBox;
        private System.Windows.Forms.TextBox boxTelefono;
        private System.Windows.Forms.Label Apellido;
        private System.Windows.Forms.TextBox nombresBox;
        private System.Windows.Forms.TextBox apellidoBox;
        private System.Windows.Forms.TextBox telefonoBox;
        private System.Windows.Forms.Button buttonRegistrar;
        private System.Windows.Forms.Button eliminarButton;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.TextBox codigo;
        private System.Windows.Forms.Button buttonEditarPaciente;
        private System.Windows.Forms.Button buttonCancelarEditar;
    }
}