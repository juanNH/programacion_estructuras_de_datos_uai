namespace WindowsFormsApp1.tp4.ej2
{
    partial class Ej2Tp4
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
            this.dniBox = new System.Windows.Forms.TextBox();
            this.nombresBox = new System.Windows.Forms.TextBox();
            this.apellidosBox = new System.Windows.Forms.TextBox();
            this.direccionBox = new System.Windows.Forms.TextBox();
            this.telefonoBox = new System.Windows.Forms.TextBox();
            this.nacimientoBox = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.alumnosLista = new System.Windows.Forms.ListBox();
            this.agregarButton = new System.Windows.Forms.Button();
            this.eliminarButton = new System.Windows.Forms.Button();
            this.editarButton = new System.Windows.Forms.Button();
            this.agregarArribaButton = new System.Windows.Forms.Button();
            this.agregarAbajoButton = new System.Windows.Forms.Button();
            this.editarAlumnoButton = new System.Windows.Forms.Button();
            this.editarCancelarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dniBox
            // 
            this.dniBox.Location = new System.Drawing.Point(76, 60);
            this.dniBox.Name = "dniBox";
            this.dniBox.Size = new System.Drawing.Size(100, 20);
            this.dniBox.TabIndex = 0;
            // 
            // nombresBox
            // 
            this.nombresBox.Location = new System.Drawing.Point(76, 124);
            this.nombresBox.Name = "nombresBox";
            this.nombresBox.Size = new System.Drawing.Size(100, 20);
            this.nombresBox.TabIndex = 2;
            // 
            // apellidosBox
            // 
            this.apellidosBox.Location = new System.Drawing.Point(76, 196);
            this.apellidosBox.Name = "apellidosBox";
            this.apellidosBox.Size = new System.Drawing.Size(100, 20);
            this.apellidosBox.TabIndex = 3;
            // 
            // direccionBox
            // 
            this.direccionBox.Location = new System.Drawing.Point(76, 259);
            this.direccionBox.Name = "direccionBox";
            this.direccionBox.Size = new System.Drawing.Size(100, 20);
            this.direccionBox.TabIndex = 4;
            // 
            // telefonoBox
            // 
            this.telefonoBox.Location = new System.Drawing.Point(76, 327);
            this.telefonoBox.Name = "telefonoBox";
            this.telefonoBox.Size = new System.Drawing.Size(100, 20);
            this.telefonoBox.TabIndex = 5;
            // 
            // nacimientoBox
            // 
            this.nacimientoBox.Location = new System.Drawing.Point(76, 400);
            this.nacimientoBox.Name = "nacimientoBox";
            this.nacimientoBox.Size = new System.Drawing.Size(200, 20);
            this.nacimientoBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "DNI: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nombres:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Apellidos: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Direccion:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Telefono: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(73, 368);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Fecha de nacimiento:";
            // 
            // alumnosLista
            // 
            this.alumnosLista.FormattingEnabled = true;
            this.alumnosLista.Location = new System.Drawing.Point(603, 34);
            this.alumnosLista.Name = "alumnosLista";
            this.alumnosLista.Size = new System.Drawing.Size(139, 381);
            this.alumnosLista.TabIndex = 13;
            // 
            // agregarButton
            // 
            this.agregarButton.Location = new System.Drawing.Point(388, 57);
            this.agregarButton.Name = "agregarButton";
            this.agregarButton.Size = new System.Drawing.Size(110, 23);
            this.agregarButton.TabIndex = 14;
            this.agregarButton.Text = "Agregar";
            this.agregarButton.UseVisualStyleBackColor = true;
            this.agregarButton.Click += new System.EventHandler(this.agregarButton_Click);
            // 
            // eliminarButton
            // 
            this.eliminarButton.Location = new System.Drawing.Point(388, 108);
            this.eliminarButton.Name = "eliminarButton";
            this.eliminarButton.Size = new System.Drawing.Size(110, 23);
            this.eliminarButton.TabIndex = 15;
            this.eliminarButton.Text = "Eliminar";
            this.eliminarButton.UseVisualStyleBackColor = true;
            this.eliminarButton.Click += new System.EventHandler(this.eliminarButton_Click);
            // 
            // editarButton
            // 
            this.editarButton.Location = new System.Drawing.Point(388, 158);
            this.editarButton.Name = "editarButton";
            this.editarButton.Size = new System.Drawing.Size(110, 23);
            this.editarButton.TabIndex = 16;
            this.editarButton.Text = "editarButton";
            this.editarButton.UseVisualStyleBackColor = true;
            this.editarButton.Click += new System.EventHandler(this.editarButton_Click);
            // 
            // agregarArribaButton
            // 
            this.agregarArribaButton.Location = new System.Drawing.Point(388, 214);
            this.agregarArribaButton.Name = "agregarArribaButton";
            this.agregarArribaButton.Size = new System.Drawing.Size(110, 45);
            this.agregarArribaButton.TabIndex = 17;
            this.agregarArribaButton.Text = "Agregar arriba del seleccionado";
            this.agregarArribaButton.UseVisualStyleBackColor = true;
            this.agregarArribaButton.Click += new System.EventHandler(this.agregarArribaButton_Click);
            // 
            // agregarAbajoButton
            // 
            this.agregarAbajoButton.Location = new System.Drawing.Point(388, 271);
            this.agregarAbajoButton.Name = "agregarAbajoButton";
            this.agregarAbajoButton.Size = new System.Drawing.Size(110, 50);
            this.agregarAbajoButton.TabIndex = 18;
            this.agregarAbajoButton.Text = "Agregar abajo del seleccionado";
            this.agregarAbajoButton.UseVisualStyleBackColor = true;
            this.agregarAbajoButton.Click += new System.EventHandler(this.agregarAbajoButton_Click);
            // 
            // editarAlumnoButton
            // 
            this.editarAlumnoButton.Location = new System.Drawing.Point(222, 133);
            this.editarAlumnoButton.Name = "editarAlumnoButton";
            this.editarAlumnoButton.Size = new System.Drawing.Size(75, 48);
            this.editarAlumnoButton.TabIndex = 19;
            this.editarAlumnoButton.Text = "Editar alumno";
            this.editarAlumnoButton.UseVisualStyleBackColor = true;
            this.editarAlumnoButton.Visible = false;
            this.editarAlumnoButton.Click += new System.EventHandler(this.editarAlumnoButton_Click);
            // 
            // editarCancelarButton
            // 
            this.editarCancelarButton.Location = new System.Drawing.Point(222, 244);
            this.editarCancelarButton.Name = "editarCancelarButton";
            this.editarCancelarButton.Size = new System.Drawing.Size(75, 49);
            this.editarCancelarButton.TabIndex = 20;
            this.editarCancelarButton.Text = "Cancelar edicion";
            this.editarCancelarButton.UseVisualStyleBackColor = true;
            this.editarCancelarButton.Visible = false;
            this.editarCancelarButton.Click += new System.EventHandler(this.editarCancelarButton_Click);
            // 
            // Ej2Tp4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.editarCancelarButton);
            this.Controls.Add(this.editarAlumnoButton);
            this.Controls.Add(this.agregarAbajoButton);
            this.Controls.Add(this.agregarArribaButton);
            this.Controls.Add(this.editarButton);
            this.Controls.Add(this.eliminarButton);
            this.Controls.Add(this.agregarButton);
            this.Controls.Add(this.alumnosLista);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nacimientoBox);
            this.Controls.Add(this.telefonoBox);
            this.Controls.Add(this.direccionBox);
            this.Controls.Add(this.apellidosBox);
            this.Controls.Add(this.nombresBox);
            this.Controls.Add(this.dniBox);
            this.Name = "Ej2Tp4";
            this.Text = "Ej2Tp4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox dniBox;
        private System.Windows.Forms.TextBox nombresBox;
        private System.Windows.Forms.TextBox apellidosBox;
        private System.Windows.Forms.TextBox direccionBox;
        private System.Windows.Forms.TextBox telefonoBox;
        private System.Windows.Forms.DateTimePicker nacimientoBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox alumnosLista;
        private System.Windows.Forms.Button agregarButton;
        private System.Windows.Forms.Button eliminarButton;
        private System.Windows.Forms.Button editarButton;
        private System.Windows.Forms.Button agregarArribaButton;
        private System.Windows.Forms.Button agregarAbajoButton;
        private System.Windows.Forms.Button editarAlumnoButton;
        private System.Windows.Forms.Button editarCancelarButton;
    }
}