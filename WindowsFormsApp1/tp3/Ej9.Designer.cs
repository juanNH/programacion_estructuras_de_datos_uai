namespace WindowsFormsApp1
{
    partial class Ej9
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.uno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuatro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cinco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unoPorcentual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dosPorcentual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tresPorcentual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuatroPorcentual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cincoPorcentual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seisPorcentual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dado1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dado2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uno,
            this.dos,
            this.tres,
            this.cuatro,
            this.cinco,
            this.seis,
            this.unoPorcentual,
            this.dosPorcentual,
            this.tresPorcentual,
            this.cuatroPorcentual,
            this.cincoPorcentual,
            this.seisPorcentual});
            this.dataGridView1.Location = new System.Drawing.Point(12, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1143, 360);
            this.dataGridView1.TabIndex = 4;
            // 
            // uno
            // 
            this.uno.HeaderText = "uno";
            this.uno.Name = "uno";
            // 
            // dos
            // 
            this.dos.HeaderText = "dos";
            this.dos.Name = "dos";
            // 
            // tres
            // 
            this.tres.HeaderText = "tres";
            this.tres.Name = "tres";
            // 
            // cuatro
            // 
            this.cuatro.HeaderText = "cuatro";
            this.cuatro.Name = "cuatro";
            // 
            // cinco
            // 
            this.cinco.HeaderText = "cinco";
            this.cinco.Name = "cinco";
            // 
            // seis
            // 
            this.seis.HeaderText = "seis";
            this.seis.Name = "seis";
            // 
            // unoPorcentual
            // 
            this.unoPorcentual.HeaderText = "unoPorcentual";
            this.unoPorcentual.Name = "unoPorcentual";
            // 
            // dosPorcentual
            // 
            this.dosPorcentual.HeaderText = "dosPorcentual";
            this.dosPorcentual.Name = "dosPorcentual";
            // 
            // tresPorcentual
            // 
            this.tresPorcentual.HeaderText = "tresPorcentual";
            this.tresPorcentual.Name = "tresPorcentual";
            // 
            // cuatroPorcentual
            // 
            this.cuatroPorcentual.HeaderText = "cuatroPorcentual";
            this.cuatroPorcentual.Name = "cuatroPorcentual";
            // 
            // cincoPorcentual
            // 
            this.cincoPorcentual.HeaderText = "cincoPorcentual";
            this.cincoPorcentual.Name = "cincoPorcentual";
            // 
            // seisPorcentual
            // 
            this.seisPorcentual.HeaderText = "seisPorcentual";
            this.seisPorcentual.Name = "seisPorcentual";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(237, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Tirar dados";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Ej9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Ej9";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn uno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dos;
        private System.Windows.Forms.DataGridViewTextBoxColumn tres;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuatro;
        private System.Windows.Forms.DataGridViewTextBoxColumn cinco;
        private System.Windows.Forms.DataGridViewTextBoxColumn seis;
        private System.Windows.Forms.DataGridViewTextBoxColumn unoPorcentual;
        private System.Windows.Forms.DataGridViewTextBoxColumn dosPorcentual;
        private System.Windows.Forms.DataGridViewTextBoxColumn tresPorcentual;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuatroPorcentual;
        private System.Windows.Forms.DataGridViewTextBoxColumn cincoPorcentual;
        private System.Windows.Forms.DataGridViewTextBoxColumn seisPorcentual;
        private System.Windows.Forms.Button button1;
    }
}