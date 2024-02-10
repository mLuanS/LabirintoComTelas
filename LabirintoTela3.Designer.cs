namespace LabirintoComTelas
{
    partial class LabirintoTela3
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
            this.btnDTela2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnETela
            // 
            this.btnETela.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnETela.Location = new System.Drawing.Point(9, 167);
            this.btnETela.Name = "btnETela";
            this.btnETela.Size = new System.Drawing.Size(115, 71);
            this.btnETela.TabIndex = 8;
            this.btnETela.Text = "PAZ MUNDIAL";
            this.btnETela.UseVisualStyleBackColor = false;
            this.btnETela.Click += new System.EventHandler(this.btnETela_Click);
            // 
            // btnDTela2
            // 
            this.btnDTela2.BackColor = System.Drawing.Color.GreenYellow;
            this.btnDTela2.Location = new System.Drawing.Point(670, 167);
            this.btnDTela2.Name = "btnDTela2";
            this.btnDTela2.Size = new System.Drawing.Size(115, 71);
            this.btnDTela2.TabIndex = 6;
            this.btnDTela2.Text = "1 BILHÃO EM REAIS";
            this.btnDTela2.UseVisualStyleBackColor = false;
            this.btnDTela2.UseWaitCursor = true;
            // 
            // LabirintoTela3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LabirintoComTelas.Properties.Resources.labirinto;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnETela);
            this.Controls.Add(this.btnDTela2);
            this.Name = "LabirintoTela3";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnETela;
        private System.Windows.Forms.Button btnDTela2;
    }
}