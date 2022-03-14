namespace Zavrsna_Aplikacija
{
    partial class Form2
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDALJE = new System.Windows.Forms.Button();
            this.buttonUNESI = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(107, 49);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(210, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Odaberi lokaciju";
            // 
            // buttonDALJE
            // 
            this.buttonDALJE.Location = new System.Drawing.Point(140, 155);
            this.buttonDALJE.Name = "buttonDALJE";
            this.buttonDALJE.Size = new System.Drawing.Size(134, 58);
            this.buttonDALJE.TabIndex = 2;
            this.buttonDALJE.Text = "DALJE";
            this.buttonDALJE.UseVisualStyleBackColor = true;
            // 
            // buttonUNESI
            // 
            this.buttonUNESI.Location = new System.Drawing.Point(142, 76);
            this.buttonUNESI.Name = "buttonUNESI";
            this.buttonUNESI.Size = new System.Drawing.Size(132, 58);
            this.buttonUNESI.TabIndex = 3;
            this.buttonUNESI.Text = "UNESI";
            this.buttonUNESI.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 240);
            this.Controls.Add(this.buttonUNESI);
            this.Controls.Add(this.buttonDALJE);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form2";
            this.Text = "LOKACIJA NAPADA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDALJE;
        private System.Windows.Forms.Button buttonUNESI;
    }
}