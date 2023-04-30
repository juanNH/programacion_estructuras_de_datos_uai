namespace WindowsFormsApp1.tp4.ej3
{
    partial class Ej3Tp4
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
            this.listaCliente = new System.Windows.Forms.ListBox();
            this.apellidosBox = new System.Windows.Forms.TextBox();
            this.dniBox = new System.Windows.Forms.TextBox();
            this.nombresBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.agregarButton = new System.Windows.Forms.Button();
            this.eliminarButton = new System.Windows.Forms.Button();
            this.editarButton = new System.Windows.Forms.Button();
            this.editarCancelarButton = new System.Windows.Forms.Button();
            this.editarClienteButton = new System.Windows.Forms.Button();
            this.agregarSiguienteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listaCliente
            // 
            this.listaCliente.FormattingEnabled = true;
            this.listaCliente.Location = new System.Drawing.Point(632, 12);
            this.listaCliente.Name = "listaCliente";
            this.listaCliente.Size = new System.Drawing.Size(120, 407);
            this.listaCliente.TabIndex = 0;
            // 
            // apellidosBox
            // 
            this.apellidosBox.Location = new System.Drawing.Point(133, 177);
            this.apellidosBox.Name = "apellidosBox";
            this.apellidosBox.Size = new System.Drawing.Size(100, 20);
            this.apellidosBox.TabIndex = 1;
            // 
            // dniBox
            // 
            this.dniBox.Location = new System.Drawing.Point(133, 63);
            this.dniBox.Name = "dniBox";
            this.dniBox.Size = new System.Drawing.Size(100, 20);
            this.dniBox.TabIndex = 2;
            // 
            // nombresBox
            // 
            this.nombresBox.Location = new System.Drawing.Point(133, 121);
            this.nombresBox.Name = "nombresBox";
            this.nombresBox.Size = new System.Drawing.Size(100, 20);
            this.nombresBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Dni: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombres: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Apellidos: ";
            // 
            // agregarButton
            // 
            this.agregarButton.Location = new System.Drawing.Point(147, 235);
            this.agregarButton.Name = "agregarButton";
            this.agregarButton.Size = new System.Drawing.Size(75, 23);
            this.agregarButton.TabIndex = 7;
            this.agregarButton.Text = "Agregar";
            this.agregarButton.UseVisualStyleBackColor = true;
            this.agregarButton.Click += new System.EventHandler(this.agregarButton_Click);
            // 
            // eliminarButton
            // 
            this.eliminarButton.Location = new System.Drawing.Point(506, 142);
            this.eliminarButton.Name = "eliminarButton";
            this.eliminarButton.Size = new System.Drawing.Size(75, 23);
            this.eliminarButton.TabIndex = 8;
            this.eliminarButton.Text = "Eliminar";
            this.eliminarButton.UseVisualStyleBackColor = true;
            this.eliminarButton.Click += new System.EventHandler(this.eliminarButton_Click);
            // 
            // editarButton
            // 
            this.editarButton.Location = new System.Drawing.Point(506, 187);
            this.editarButton.Name = "editarButton";
            this.editarButton.Size = new System.Drawing.Size(75, 23);
            this.editarButton.TabIndex = 9;
            this.editarButton.Text = "Editar";
            this.editarButton.UseVisualStyleBackColor = true;
            this.editarButton.Click += new System.EventHandler(this.editarButton_Click);
            // 
            // editarCancelarButton
            // 
            this.editarCancelarButton.Location = new System.Drawing.Point(86, 297);
            this.editarCancelarButton.Name = "editarCancelarButton";
            this.editarCancelarButton.Size = new System.Drawing.Size(73, 40);
            this.editarCancelarButton.TabIndex = 10;
            this.editarCancelarButton.Text = "Cancelar edicion";
            this.editarCancelarButton.UseVisualStyleBackColor = true;
            this.editarCancelarButton.Visible = false;
            this.editarCancelarButton.Click += new System.EventHandler(this.editarCancelarButton_Click);
            // 
            // editarClienteButton
            // 
            this.editarClienteButton.Location = new System.Drawing.Point(204, 297);
            this.editarClienteButton.Name = "editarClienteButton";
            this.editarClienteButton.Size = new System.Drawing.Size(71, 40);
            this.editarClienteButton.TabIndex = 11;
            this.editarClienteButton.Text = "Editar cliente";
            this.editarClienteButton.UseVisualStyleBackColor = true;
            this.editarClienteButton.Visible = false;
            this.editarClienteButton.Click += new System.EventHandler(this.editarClienteButton_Click);
            // 
            // agregarSiguienteButton
            // 
            this.agregarSiguienteButton.Location = new System.Drawing.Point(506, 235);
            this.agregarSiguienteButton.Name = "agregarSiguienteButton";
            this.agregarSiguienteButton.Size = new System.Drawing.Size(75, 34);
            this.agregarSiguienteButton.TabIndex = 12;
            this.agregarSiguienteButton.Text = "Agregar despues";
            this.agregarSiguienteButton.UseVisualStyleBackColor = true;
            this.agregarSiguienteButton.Click += new System.EventHandler(this.agregarSiguienteButton_Click);
            // 
            // Ej3Tp4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.agregarSiguienteButton);
            this.Controls.Add(this.editarClienteButton);
            this.Controls.Add(this.editarCancelarButton);
            this.Controls.Add(this.editarButton);
            this.Controls.Add(this.eliminarButton);
            this.Controls.Add(this.agregarButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nombresBox);
            this.Controls.Add(this.dniBox);
            this.Controls.Add(this.apellidosBox);
            this.Controls.Add(this.listaCliente);
            this.Name = "Ej3Tp4";
            this.Text = "Ej3Tp4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listaCliente;
        private System.Windows.Forms.TextBox apellidosBox;
        private System.Windows.Forms.TextBox dniBox;
        private System.Windows.Forms.TextBox nombresBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button agregarButton;
        private System.Windows.Forms.Button eliminarButton;
        private System.Windows.Forms.Button editarButton;
        private System.Windows.Forms.Button editarCancelarButton;
        private System.Windows.Forms.Button editarClienteButton;
        private System.Windows.Forms.Button agregarSiguienteButton;
    }
}