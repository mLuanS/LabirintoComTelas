namespace LabirintoComTelas
{
    partial class LabirintoTela1
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
            this.btnDTela1 = new System.Windows.Forms.Button();
            this.btnBTela1 = new System.Windows.Forms.Button();
            this.btnETela1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDTela1
            // 
            this.btnDTela1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDTela1.Location = new System.Drawing.Point(673, 167);
            this.btnDTela1.Name = "btnDTela1";
            this.btnDTela1.Size = new System.Drawing.Size(115, 71);
            this.btnDTela1.TabIndex = 0;
            this.btnDTela1.Text = "Direita";
            this.btnDTela1.UseVisualStyleBackColor = false;
            this.btnDTela1.Click += new System.EventHandler(this.btnDTela1_Click);
            // 
            // btnBTela1
            // 
            this.btnBTela1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnBTela1.Location = new System.Drawing.Point(348, 367);
            this.btnBTela1.Name = "btnBTela1";
            this.btnBTela1.Size = new System.Drawing.Size(115, 71);
            this.btnBTela1.TabIndex = 1;
            this.btnBTela1.Text = "Baixo";
            this.btnBTela1.UseVisualStyleBackColor = false;
            this.btnBTela1.Click += new System.EventHandler(this.btnBTela1_Click);
            // 
            // btnETela1
            // 
            this.btnETela1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnETela1.Location = new System.Drawing.Point(12, 167);
            this.btnETela1.Name = "btnETela1";
            this.btnETela1.Size = new System.Drawing.Size(115, 71);
            this.btnETela1.TabIndex = 2;
            this.btnETela1.Text = "Esquerda";
            this.btnETela1.UseVisualStyleBackColor = false;
            this.btnETela1.Click += new System.EventHandler(this.btnTela1_Click);
            // 
            // LabirintoTela1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LabirintoComTelas.Properties.Resources.labirinto;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnETela1);
            this.Controls.Add(this.btnBTela1);
            this.Controls.Add(this.btnDTela1);
            this.Name = "LabirintoTela1";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.LabirintoTela1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDTela1;
        private System.Windows.Forms.Button btnBTela1;
        private System.Windows.Forms.Button btnETela1;
    }
}