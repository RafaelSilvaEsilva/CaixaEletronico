namespace CaixaBanco
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtSaque = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbResultado = new System.Windows.Forms.Label();
            this.btSacar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSaque
            // 
            this.txtSaque.Location = new System.Drawing.Point(70, 96);
            this.txtSaque.Name = "txtSaque";
            this.txtSaque.Size = new System.Drawing.Size(100, 20);
            this.txtSaque.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "valor do saque";
            // 
            // lbResultado
            // 
            this.lbResultado.AutoSize = true;
            this.lbResultado.Location = new System.Drawing.Point(253, 75);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(16, 13);
            this.lbResultado.TabIndex = 2;
            this.lbResultado.Text = "...";
            this.lbResultado.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbResultado.Visible = false;
            // 
            // btSacar
            // 
            this.btSacar.BackColor = System.Drawing.SystemColors.Control;
            this.btSacar.BackgroundImage = global::CaixaBanco.Properties.Resources.Imagem1;
            this.btSacar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btSacar.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSacar.ForeColor = System.Drawing.Color.Black;
            this.btSacar.Location = new System.Drawing.Point(70, 274);
            this.btSacar.Name = "btSacar";
            this.btSacar.Size = new System.Drawing.Size(133, 76);
            this.btSacar.TabIndex = 3;
            this.btSacar.Text = "   \r\n\r\n\r\n  Sacar";
            this.btSacar.UseVisualStyleBackColor = false;
            this.btSacar.Click += new System.EventHandler(this.btSacar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CaixaBanco.Properties.Resources.png_transparent_automated_teller_machine_scalable_graphics_icon_atm_miscellaneous_rectangle_cartoon_thumbnail;
            this.ClientSize = new System.Drawing.Size(422, 351);
            this.Controls.Add(this.btSacar);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSaque);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSaque;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbResultado;
        private System.Windows.Forms.Button btSacar;
    }
}

