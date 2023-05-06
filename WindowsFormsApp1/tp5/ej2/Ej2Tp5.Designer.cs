namespace WindowsFormsApp1.tp5.ej2
{
    partial class Ej2Tp5
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
            this.pushButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.recorridoLista = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.puebloBox = new System.Windows.Forms.TextBox();
            this.labelPueblo = new System.Windows.Forms.Label();
            this.viajarButton = new System.Windows.Forms.Button();
            this.popButton = new System.Windows.Forms.Button();
            this.pueblosLista = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // pushButton
            // 
            this.pushButton.Location = new System.Drawing.Point(327, 148);
            this.pushButton.Name = "pushButton";
            this.pushButton.Size = new System.Drawing.Size(75, 33);
            this.pushButton.TabIndex = 1;
            this.pushButton.Text = "Push";
            this.pushButton.UseVisualStyleBackColor = true;
            this.pushButton.Click += new System.EventHandler(this.pushButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(313, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingrese nuevo pueblo";
            // 
            // recorridoLista
            // 
            this.recorridoLista.FormattingEnabled = true;
            this.recorridoLista.Location = new System.Drawing.Point(566, 97);
            this.recorridoLista.Name = "recorridoLista";
            this.recorridoLista.Size = new System.Drawing.Size(120, 160);
            this.recorridoLista.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(563, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Recorrido hasta el destino:";
            // 
            // puebloBox
            // 
            this.puebloBox.Location = new System.Drawing.Point(316, 97);
            this.puebloBox.Name = "puebloBox";
            this.puebloBox.Size = new System.Drawing.Size(110, 20);
            this.puebloBox.TabIndex = 5;
            // 
            // labelPueblo
            // 
            this.labelPueblo.AutoSize = true;
            this.labelPueblo.Location = new System.Drawing.Point(364, 23);
            this.labelPueblo.Name = "labelPueblo";
            this.labelPueblo.Size = new System.Drawing.Size(73, 13);
            this.labelPueblo.TabIndex = 6;
            this.labelPueblo.Text = "Pueblo Actual";
            // 
            // viajarButton
            // 
            this.viajarButton.Location = new System.Drawing.Point(184, 148);
            this.viajarButton.Name = "viajarButton";
            this.viajarButton.Size = new System.Drawing.Size(75, 33);
            this.viajarButton.TabIndex = 7;
            this.viajarButton.Text = "Viajar";
            this.viajarButton.UseVisualStyleBackColor = true;
            this.viajarButton.Click += new System.EventHandler(this.viajarButton_Click);
            // 
            // popButton
            // 
            this.popButton.Location = new System.Drawing.Point(327, 187);
            this.popButton.Name = "popButton";
            this.popButton.Size = new System.Drawing.Size(75, 33);
            this.popButton.TabIndex = 8;
            this.popButton.Text = "Pop";
            this.popButton.UseVisualStyleBackColor = true;
            this.popButton.Click += new System.EventHandler(this.popButton_Click);
            // 
            // pueblosLista
            // 
            this.pueblosLista.FormattingEnabled = true;
            this.pueblosLista.Location = new System.Drawing.Point(44, 70);
            this.pueblosLista.Name = "pueblosLista";
            this.pueblosLista.Size = new System.Drawing.Size(120, 199);
            this.pueblosLista.TabIndex = 9;
            // 
            // Ej2Tp5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pueblosLista);
            this.Controls.Add(this.popButton);
            this.Controls.Add(this.viajarButton);
            this.Controls.Add(this.labelPueblo);
            this.Controls.Add(this.puebloBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.recorridoLista);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pushButton);
            this.Name = "Ej2Tp5";
            this.Text = "Ej2Tp5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button pushButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox recorridoLista;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox puebloBox;
        private System.Windows.Forms.Label labelPueblo;
        private System.Windows.Forms.Button viajarButton;
        private System.Windows.Forms.Button popButton;
        private System.Windows.Forms.ListBox pueblosLista;
    }
}