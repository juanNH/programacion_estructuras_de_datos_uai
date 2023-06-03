namespace WindowsFormsApp1.tp7._1
{
    partial class Ej0Tp7
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
            this.treeNodo = new System.Windows.Forms.TreeView();
            this.agregarButton = new System.Windows.Forms.Button();
            this.numeroBox = new System.Windows.Forms.NumericUpDown();
            this.preOrderButton = new System.Windows.Forms.Button();
            this.treeBox = new System.Windows.Forms.TextBox();
            this.inOrderButton = new System.Windows.Forms.Button();
            this.postOrderButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numeroBox)).BeginInit();
            this.SuspendLayout();
            // 
            // treeNodo
            // 
            this.treeNodo.Location = new System.Drawing.Point(85, 66);
            this.treeNodo.Name = "treeNodo";
            this.treeNodo.Size = new System.Drawing.Size(160, 213);
            this.treeNodo.TabIndex = 0;
            // 
            // agregarButton
            // 
            this.agregarButton.Location = new System.Drawing.Point(389, 65);
            this.agregarButton.Name = "agregarButton";
            this.agregarButton.Size = new System.Drawing.Size(75, 23);
            this.agregarButton.TabIndex = 1;
            this.agregarButton.Text = "Agregar";
            this.agregarButton.UseVisualStyleBackColor = true;
            this.agregarButton.Click += new System.EventHandler(this.agregarButton_Click);
            // 
            // numeroBox
            // 
            this.numeroBox.Location = new System.Drawing.Point(367, 34);
            this.numeroBox.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numeroBox.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numeroBox.Name = "numeroBox";
            this.numeroBox.Size = new System.Drawing.Size(120, 20);
            this.numeroBox.TabIndex = 2;
            // 
            // preOrderButton
            // 
            this.preOrderButton.Location = new System.Drawing.Point(389, 128);
            this.preOrderButton.Name = "preOrderButton";
            this.preOrderButton.Size = new System.Drawing.Size(98, 32);
            this.preOrderButton.TabIndex = 3;
            this.preOrderButton.Text = "Pre order";
            this.preOrderButton.UseVisualStyleBackColor = true;
            this.preOrderButton.Click += new System.EventHandler(this.preOrderButton_Click);
            // 
            // treeBox
            // 
            this.treeBox.Location = new System.Drawing.Point(12, 370);
            this.treeBox.Name = "treeBox";
            this.treeBox.Size = new System.Drawing.Size(776, 20);
            this.treeBox.TabIndex = 4;
            // 
            // inOrderButton
            // 
            this.inOrderButton.Location = new System.Drawing.Point(389, 175);
            this.inOrderButton.Name = "inOrderButton";
            this.inOrderButton.Size = new System.Drawing.Size(98, 31);
            this.inOrderButton.TabIndex = 5;
            this.inOrderButton.Text = "In order";
            this.inOrderButton.UseVisualStyleBackColor = true;
            this.inOrderButton.Click += new System.EventHandler(this.inOrderButton_Click);
            // 
            // postOrderButton
            // 
            this.postOrderButton.Location = new System.Drawing.Point(389, 222);
            this.postOrderButton.Name = "postOrderButton";
            this.postOrderButton.Size = new System.Drawing.Size(98, 32);
            this.postOrderButton.TabIndex = 6;
            this.postOrderButton.Text = "Post Order";
            this.postOrderButton.UseVisualStyleBackColor = true;
            this.postOrderButton.Click += new System.EventHandler(this.postOrderButton_Click);
            // 
            // Ej0Tp7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.postOrderButton);
            this.Controls.Add(this.inOrderButton);
            this.Controls.Add(this.treeBox);
            this.Controls.Add(this.preOrderButton);
            this.Controls.Add(this.numeroBox);
            this.Controls.Add(this.agregarButton);
            this.Controls.Add(this.treeNodo);
            this.Name = "Ej0Tp7";
            this.Text = "Ej0Tp7";
            ((System.ComponentModel.ISupportInitialize)(this.numeroBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeNodo;
        private System.Windows.Forms.Button agregarButton;
        private System.Windows.Forms.NumericUpDown numeroBox;
        private System.Windows.Forms.Button preOrderButton;
        private System.Windows.Forms.TextBox treeBox;
        private System.Windows.Forms.Button inOrderButton;
        private System.Windows.Forms.Button postOrderButton;
    }
}