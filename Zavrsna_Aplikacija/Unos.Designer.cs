namespace Zavrsna_Aplikacija
{
    partial class Unos
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
            this.textBoxUnesiLokaciju = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Lokacija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Obranbeni_sustav = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxSAM = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUnesi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxUnesiLokaciju
            // 
            this.textBoxUnesiLokaciju.Location = new System.Drawing.Point(56, 220);
            this.textBoxUnesiLokaciju.Multiline = true;
            this.textBoxUnesiLokaciju.Name = "textBoxUnesiLokaciju";
            this.textBoxUnesiLokaciju.Size = new System.Drawing.Size(158, 20);
            this.textBoxUnesiLokaciju.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Unesi lokaciju";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Lokacija,
            this.Obranbeni_sustav});
            this.dataGridView1.Location = new System.Drawing.Point(56, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(462, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // Lokacija
            // 
            this.Lokacija.HeaderText = "Lokacija";
            this.Lokacija.Name = "Lokacija";
            // 
            // Obranbeni_sustav
            // 
            this.Obranbeni_sustav.HeaderText = "Protuzrani sustavi";
            this.Obranbeni_sustav.Name = "Obranbeni_sustav";
            // 
            // textBoxSAM
            // 
            this.textBoxSAM.Location = new System.Drawing.Point(56, 275);
            this.textBoxSAM.Multiline = true;
            this.textBoxSAM.Name = "textBoxSAM";
            this.textBoxSAM.Size = new System.Drawing.Size(158, 20);
            this.textBoxSAM.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Unesi protuzracni sustav";
            // 
            // btnUnesi
            // 
            this.btnUnesi.Location = new System.Drawing.Point(56, 301);
            this.btnUnesi.Name = "btnUnesi";
            this.btnUnesi.Size = new System.Drawing.Size(158, 40);
            this.btnUnesi.TabIndex = 5;
            this.btnUnesi.Text = "Unesi";
            this.btnUnesi.UseVisualStyleBackColor = true;
            // 
            // Unos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 384);
            this.Controls.Add(this.btnUnesi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxSAM);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxUnesiLokaciju);
            this.Name = "Unos";
            this.Text = "Unos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUnesiLokaciju;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lokacija;
        private System.Windows.Forms.DataGridViewTextBoxColumn Obranbeni_sustav;
        private System.Windows.Forms.TextBox textBoxSAM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUnesi;
    }
}