namespace LabirintoComTelas
{
    partial class LabirintoInicio
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnInicioLabirinto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInicioLabirinto
            // 
            this.btnInicioLabirinto.BackgroundImage = global::LabirintoComTelas.Properties.Resources.png_clipart_push_button_pixel_art_button_start_text_logo_thumbnail;
            this.btnInicioLabirinto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInicioLabirinto.Location = new System.Drawing.Point(297, 233);
            this.btnInicioLabirinto.Name = "btnInicioLabirinto";
            this.btnInicioLabirinto.Size = new System.Drawing.Size(237, 107);
            this.btnInicioLabirinto.TabIndex = 0;
            this.btnInicioLabirinto.UseVisualStyleBackColor = true;
            this.btnInicioLabirinto.Click += new System.EventHandler(this.btnInicioLabirinto_Click);
            // 
            // LabirintoInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LabirintoComTelas.Properties.Resources.labirinto;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnInicioLabirinto);
            this.Name = "LabirintoInicio";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInicioLabirinto;
    }
}

