namespace WindowsFormsApp1.tp4.ej4
{
    partial class Ej4Tp4
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
            this.nombreBox = new System.Windows.Forms.TextBox();
            this.apellidoBox = new System.Windows.Forms.TextBox();
            this.edadBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listaBox = new System.Windows.Forms.ListBox();
            this.agregarButton = new System.Windows.Forms.Button();
            this.editarButton = new System.Windows.Forms.Button();
            this.eliminarButton = new System.Windows.Forms.Button();
            this.agregarSiguienteButton = new System.Windows.Forms.Button();
            this.agregarEditarButton = new System.Windows.Forms.Button();
            this.cancelarEditarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dniBox
            // 
            this.dniBox.Location = new System.Drawing.Point(89, 79);
            this.dniBox.Name = "dniBox";
            this.dniBox.Size = new System.Drawing.Size(100, 20);
            this.dniBox.TabIndex = 0;
            // 
            // nombreBox
            // 
            this.nombreBox.Location = new System.Drawing.Point(89, 142);
            this.nombreBox.Name = "nombreBox";
            this.nombreBox.Size = new System.Drawing.Size(100, 20);
            this.nombreBox.TabIndex = 1;
            // 
            // apellidoBox
            // 
            this.apellidoBox.Location = new System.Drawing.Point(89, 214);
            this.apellidoBox.Name = "apellidoBox";
            this.apellidoBox.Size = new System.Drawing.Size(100, 20);
            this.apellidoBox.TabIndex = 2;
            // 
            // edadBox
            // 
            this.edadBox.Location = new System.Drawing.Point(89, 280);
            this.edadBox.Name = "edadBox";
            this.edadBox.Size = new System.Drawing.Size(100, 20);
            this.edadBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Apellido: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Edad: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Dni: ";
            // 
            // listaBox
            // 
            this.listaBox.FormattingEnabled = true;
            this.listaBox.Location = new System.Drawing.Point(628, 79);
            this.listaBox.Name = "listaBox";
            this.listaBox.Size = new System.Drawing.Size(120, 264);
            this.listaBox.TabIndex = 8;
            // 
            // agregarButton
            // 
            this.agregarButton.Location = new System.Drawing.Point(101, 319);
            this.agregarButton.Name = "agregarButton";
            this.agregarButton.Size = new System.Drawing.Size(75, 23);
            this.agregarButton.TabIndex = 9;
            this.agregarButton.Text = "Agregar";
            this.agregarButton.UseVisualStyleBackColor = true;
            this.agregarButton.Click += new System.EventHandler(this.agregarButton_Click);
            // 
            // editarButton
            // 
            this.editarButton.Location = new System.Drawing.Point(469, 79);
            this.editarButton.Name = "editarButton";
            this.editarButton.Size = new System.Drawing.Size(75, 23);
            this.editarButton.TabIndex = 10;
            this.editarButton.Text = "Editar";
            this.editarButton.UseVisualStyleBackColor = true;
            this.editarButton.Click += new System.EventHandler(this.editarButton_Click);
            // 
            // eliminarButton
            // 
            this.eliminarButton.Location = new System.Drawing.Point(469, 130);
            this.eliminarButton.Name = "eliminarButton";
            this.eliminarButton.Size = new System.Drawing.Size(75, 23);
            this.eliminarButton.TabIndex = 11;
            this.eliminarButton.Text = "Eliminar";
            this.eliminarButton.UseVisualStyleBackColor = true;
            this.eliminarButton.Click += new System.EventHandler(this.eliminarButton_Click);
            // 
            // agregarSiguienteButton
            // 
            this.agregarSiguienteButton.Location = new System.Drawing.Point(469, 184);
            this.agregarSiguienteButton.Name = "agregarSiguienteButton";
            this.agregarSiguienteButton.Size = new System.Drawing.Size(75, 50);
            this.agregarSiguienteButton.TabIndex = 12;
            this.agregarSiguienteButton.Text = "Agregar siguiente";
            this.agregarSiguienteButton.UseVisualStyleBackColor = true;
            this.agregarSiguienteButton.Click += new System.EventHandler(this.agregarSiguienteButton_Click);
            // 
            // agregarEditarButton
            // 
            this.agregarEditarButton.Location = new System.Drawing.Point(142, 363);
            this.agregarEditarButton.Name = "agregarEditarButton";
            this.agregarEditarButton.Size = new System.Drawing.Size(84, 42);
            this.agregarEditarButton.TabIndex = 13;
            this.agregarEditarButton.Text = "Editar seleccionado";
            this.agregarEditarButton.UseVisualStyleBackColor = true;
            this.agregarEditarButton.Visible = false;
            this.agregarEditarButton.Click += new System.EventHandler(this.agregarEditarButton_Click);
            // 
            // cancelarEditarButton
            // 
            this.cancelarEditarButton.Location = new System.Drawing.Point(61, 363);
            this.cancelarEditarButton.Name = "cancelarEditarButton";
            this.cancelarEditarButton.Size = new System.Drawing.Size(75, 42);
            this.cancelarEditarButton.TabIndex = 14;
            this.cancelarEditarButton.Text = "cancelar edicion";
            this.cancelarEditarButton.UseVisualStyleBackColor = true;
            this.cancelarEditarButton.Visible = false;
            this.cancelarEditarButton.Click += new System.EventHandler(this.cancelarEditarButton_Click);
            // 
            // Ej4Tp4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancelarEditarButton);
            this.Controls.Add(this.agregarEditarButton);
            this.Controls.Add(this.agregarSiguienteButton);
            this.Controls.Add(this.eliminarButton);
            this.Controls.Add(this.editarButton);
            this.Controls.Add(this.agregarButton);
            this.Controls.Add(this.listaBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.edadBox);
            this.Controls.Add(this.apellidoBox);
            this.Controls.Add(this.nombreBox);
            this.Controls.Add(this.dniBox);
            this.Name = "Ej4Tp4";
            this.Text = "Ej4Tp4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox dniBox;
        private System.Windows.Forms.TextBox nombreBox;
        private System.Windows.Forms.TextBox apellidoBox;
        private System.Windows.Forms.TextBox edadBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listaBox;
        private System.Windows.Forms.Button agregarButton;
        private System.Windows.Forms.Button editarButton;
        private System.Windows.Forms.Button eliminarButton;
        private System.Windows.Forms.Button agregarSiguienteButton;
        private System.Windows.Forms.Button agregarEditarButton;
        private System.Windows.Forms.Button cancelarEditarButton;
    }
}