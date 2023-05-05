namespace WindowsFormsApp1.tp5.ej1
{
    partial class Ej1Tp5
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
            this.containerLista = new System.Windows.Forms.ListBox();
            this.popButton = new System.Windows.Forms.Button();
            this.pushButton = new System.Windows.Forms.Button();
            this.idBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.eliminarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // containerLista
            // 
            this.containerLista.FormattingEnabled = true;
            this.containerLista.Location = new System.Drawing.Point(96, 52);
            this.containerLista.Name = "containerLista";
            this.containerLista.Size = new System.Drawing.Size(120, 186);
            this.containerLista.TabIndex = 0;
            // 
            // popButton
            // 
            this.popButton.Location = new System.Drawing.Point(308, 143);
            this.popButton.Name = "popButton";
            this.popButton.Size = new System.Drawing.Size(75, 23);
            this.popButton.TabIndex = 1;
            this.popButton.Text = "Pop";
            this.popButton.UseVisualStyleBackColor = true;
            this.popButton.Click += new System.EventHandler(this.popButton_Click);
            // 
            // pushButton
            // 
            this.pushButton.Location = new System.Drawing.Point(308, 100);
            this.pushButton.Name = "pushButton";
            this.pushButton.Size = new System.Drawing.Size(75, 23);
            this.pushButton.TabIndex = 2;
            this.pushButton.Text = "Push";
            this.pushButton.UseVisualStyleBackColor = true;
            this.pushButton.Click += new System.EventHandler(this.pushButton_Click);
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(298, 52);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(100, 20);
            this.idBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(295, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ingrese identificador unico: ";
            // 
            // eliminarButton
            // 
            this.eliminarButton.Location = new System.Drawing.Point(298, 190);
            this.eliminarButton.Name = "eliminarButton";
            this.eliminarButton.Size = new System.Drawing.Size(100, 37);
            this.eliminarButton.TabIndex = 5;
            this.eliminarButton.Text = "Eliminar Seleccionado";
            this.eliminarButton.UseVisualStyleBackColor = true;
            this.eliminarButton.Click += new System.EventHandler(this.eliminarButton_Click);
            // 
            // Ej1Tp5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.eliminarButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.pushButton);
            this.Controls.Add(this.popButton);
            this.Controls.Add(this.containerLista);
            this.Name = "Ej1Tp5";
            this.Text = "Ej1tp5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox containerLista;
        private System.Windows.Forms.Button popButton;
        private System.Windows.Forms.Button pushButton;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button eliminarButton;
    }
}