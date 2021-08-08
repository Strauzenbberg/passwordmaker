
namespace Clipper
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lblPergunta = new System.Windows.Forms.Label();
            this.maskChute = new System.Windows.Forms.MaskedTextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.lblDica = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPergunta
            // 
            this.lblPergunta.AutoSize = true;
            this.lblPergunta.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPergunta.Location = new System.Drawing.Point(35, 52);
            this.lblPergunta.Name = "lblPergunta";
            this.lblPergunta.Size = new System.Drawing.Size(0, 22);
            this.lblPergunta.TabIndex = 1;
            // 
            // maskChute
            // 
            this.maskChute.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskChute.Location = new System.Drawing.Point(375, 238);
            this.maskChute.Mask = "00";
            this.maskChute.Name = "maskChute";
            this.maskChute.Size = new System.Drawing.Size(28, 29);
            this.maskChute.TabIndex = 2;
            this.maskChute.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskChute_KeyPress);
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(409, 238);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 29);
            this.btnGo.TabIndex = 3;
            this.btnGo.Text = "Enter";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // lblDica
            // 
            this.lblDica.AutoSize = true;
            this.lblDica.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDica.Location = new System.Drawing.Point(72, 103);
            this.lblDica.Name = "lblDica";
            this.lblDica.Size = new System.Drawing.Size(0, 22);
            this.lblDica.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Clippy.Properties.Resources._504767_Microsoft_0;
            this.pictureBox1.Location = new System.Drawing.Point(39, 155);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(718, 326);
            this.Controls.Add(this.lblDica);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.maskChute);
            this.Controls.Add(this.lblPergunta);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clippy";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblPergunta;
        private System.Windows.Forms.MaskedTextBox maskChute;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Label lblDica;
    }
}

