namespace WindowsFormsApp1.tp5.ej3
{
    partial class Ej3Tp5
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
            this.listaExpedientes = new System.Windows.Forms.ListBox();
            this.nroExpBox = new System.Windows.Forms.TextBox();
            this.caratulaBox = new System.Windows.Forms.TextBox();
            this.popButton = new System.Windows.Forms.Button();
            this.pushButton = new System.Windows.Forms.Button();
            this.ordenarButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fechaBox = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // listaExpedientes
            // 
            this.listaExpedientes.FormattingEnabled = true;
            this.listaExpedientes.Location = new System.Drawing.Point(69, 73);
            this.listaExpedientes.Name = "listaExpedientes";
            this.listaExpedientes.Size = new System.Drawing.Size(120, 186);
            this.listaExpedientes.TabIndex = 0;
            // 
            // nroExpBox
            // 
            this.nroExpBox.Location = new System.Drawing.Point(277, 102);
            this.nroExpBox.Name = "nroExpBox";
            this.nroExpBox.Size = new System.Drawing.Size(100, 20);
            this.nroExpBox.TabIndex = 1;
            // 
            // caratulaBox
            // 
            this.caratulaBox.Location = new System.Drawing.Point(277, 162);
            this.caratulaBox.Name = "caratulaBox";
            this.caratulaBox.Size = new System.Drawing.Size(100, 20);
            this.caratulaBox.TabIndex = 2;
            // 
            // popButton
            // 
            this.popButton.Location = new System.Drawing.Point(302, 323);
            this.popButton.Name = "popButton";
            this.popButton.Size = new System.Drawing.Size(75, 23);
            this.popButton.TabIndex = 4;
            this.popButton.Text = "Pop";
            this.popButton.UseVisualStyleBackColor = true;
            this.popButton.Click += new System.EventHandler(this.popButton_Click);
            // 
            // pushButton
            // 
            this.pushButton.Location = new System.Drawing.Point(302, 278);
            this.pushButton.Name = "pushButton";
            this.pushButton.Size = new System.Drawing.Size(75, 23);
            this.pushButton.TabIndex = 5;
            this.pushButton.Text = "Push";
            this.pushButton.UseVisualStyleBackColor = true;
            this.pushButton.Click += new System.EventHandler(this.pushButton_Click);
            // 
            // ordenarButton
            // 
            this.ordenarButton.Location = new System.Drawing.Point(302, 365);
            this.ordenarButton.Name = "ordenarButton";
            this.ordenarButton.Size = new System.Drawing.Size(75, 23);
            this.ordenarButton.TabIndex = 6;
            this.ordenarButton.Text = "Ordernar";
            this.ordenarButton.UseVisualStyleBackColor = true;
            this.ordenarButton.Click += new System.EventHandler(this.ordenarButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(274, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "nroExpediente: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Caratula: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Fecha: ";
            // 
            // fechaBox
            // 
            this.fechaBox.Location = new System.Drawing.Point(277, 235);
            this.fechaBox.Name = "fechaBox";
            this.fechaBox.Size = new System.Drawing.Size(200, 20);
            this.fechaBox.TabIndex = 10;
            // 
            // Ej3Tp5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fechaBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ordenarButton);
            this.Controls.Add(this.pushButton);
            this.Controls.Add(this.popButton);
            this.Controls.Add(this.caratulaBox);
            this.Controls.Add(this.nroExpBox);
            this.Controls.Add(this.listaExpedientes);
            this.Name = "Ej3Tp5";
            this.Text = "Ej3Tp5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listaExpedientes;
        private System.Windows.Forms.TextBox nroExpBox;
        private System.Windows.Forms.TextBox caratulaBox;
        private System.Windows.Forms.Button popButton;
        private System.Windows.Forms.Button pushButton;
        private System.Windows.Forms.Button ordenarButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker fechaBox;
    }
}