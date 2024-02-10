namespace LabirintoComTelas
{
    partial class LabirintoTela2
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
            this.btnETela = new System.Windows.Forms.Button();
            this.btnBTela2 = new System.Windows.Forms.Button();
            this.btnDTela2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnETela
            // 
            this.btnETela.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnETela.Location = new System.Drawing.Point(8, 167);
            this.btnETela.Name = "btnETela";
            this.btnETela.Size = new System.Drawing.Size(115, 71);
            this.btnETela.TabIndex = 5;
            this.btnETela.Text = "Esquerda";
            this.btnETela.UseVisualStyleBackColor = false;
            this.btnETela.Click += new System.EventHandler(this.btnETela_Click);
            // 
            // btnBTela2
            // 
            this.btnBTela2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnBTela2.Location = new System.Drawing.Point(344, 367);
            this.btnBTela2.Name = "btnBTela2";
            this.btnBTela2.Size = new System.Drawing.Size(115, 71);
            this.btnBTela2.TabIndex = 4;
            this.btnBTela2.Text = "Baixo";
            this.btnBTela2.UseVisualStyleBackColor = false;
            this.btnBTela2.Click += new System.EventHandler(this.btnBTela2_Click);
            // 
            // btnDTela2
            // 
            this.btnDTela2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnDTela2.Location = new System.Drawing.Point(669, 167);
            this.btnDTela2.Name = "btnDTela2";
            this.btnDTela2.Size = new System.Drawing.Size(115, 71);
            this.btnDTela2.TabIndex = 3;
            this.btnDTela2.Text = "Direita";
            this.btnDTela2.UseVisualStyleBackColor = false;
            this.btnDTela2.Click += new System.EventHandler(this.btnDTela2_Click);
            // 
            // LabirintoTela2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LabirintoComTelas.Properties.Resources.labirinto;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnETela);
            this.Controls.Add(this.btnBTela2);
            this.Controls.Add(this.btnDTela2);
            this.Name = "LabirintoTela2";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnETela;
        private System.Windows.Forms.Button btnBTela2;
        private System.Windows.Forms.Button btnDTela2;
    }
}