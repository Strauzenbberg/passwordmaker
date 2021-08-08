
namespace TopElevenForWindows
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.mskTextHoraDoJogo = new System.Windows.Forms.MaskedTextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblHoraDoJogo = new System.Windows.Forms.Label();
            this.lblDigite = new System.Windows.Forms.Label();
            this.lblEnergia = new System.Windows.Forms.Label();
            this.lblAtual = new System.Windows.Forms.Label();
            this.lblTempo = new System.Windows.Forms.Label();
            this.lblGanho = new System.Windows.Forms.Label();
            this.lblEnergiaShow = new System.Windows.Forms.Label();
            this.lblAtualShow = new System.Windows.Forms.Label();
            this.lblTempoShow = new System.Windows.Forms.Label();
            this.lblGanhoShow = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mskTextHoraDoJogo
            // 
            this.mskTextHoraDoJogo.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert;
            this.mskTextHoraDoJogo.Location = new System.Drawing.Point(206, 86);
            this.mskTextHoraDoJogo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mskTextHoraDoJogo.Mask = "00";
            this.mskTextHoraDoJogo.Name = "mskTextHoraDoJogo";
            this.mskTextHoraDoJogo.Size = new System.Drawing.Size(32, 22);
            this.mskTextHoraDoJogo.TabIndex = 0;
            this.mskTextHoraDoJogo.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskTextHoraDoJogo_MaskInputRejected);
            this.mskTextHoraDoJogo.Click += new System.EventHandler(this.mskTextHoraDoJogo_Click);
            this.mskTextHoraDoJogo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mskTextHoraDoJogo_KeyDown);
            this.mskTextHoraDoJogo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskTextHoraDoJogo_KeyPress);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(206, 297);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(87, 28);
            this.btnCalcular.TabIndex = 1;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            this.btnCalcular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnCalcular_KeyPress);
            // 
            // lblHoraDoJogo
            // 
            this.lblHoraDoJogo.AutoSize = true;
            this.lblHoraDoJogo.Location = new System.Drawing.Point(14, 90);
            this.lblHoraDoJogo.Name = "lblHoraDoJogo";
            this.lblHoraDoJogo.Size = new System.Drawing.Size(88, 16);
            this.lblHoraDoJogo.TabIndex = 2;
            this.lblHoraDoJogo.Text = "Hora do Jogo:";
            // 
            // lblDigite
            // 
            this.lblDigite.AutoSize = true;
            this.lblDigite.Location = new System.Drawing.Point(14, 34);
            this.lblDigite.Name = "lblDigite";
            this.lblDigite.Size = new System.Drawing.Size(425, 16);
            this.lblDigite.TabIndex = 3;
            this.lblDigite.Text = "Digite a hora do jogo, sem os minutos, no formato 24 e pressione Enter:";
            // 
            // lblEnergia
            // 
            this.lblEnergia.AutoSize = true;
            this.lblEnergia.Location = new System.Drawing.Point(17, 124);
            this.lblEnergia.Name = "lblEnergia";
            this.lblEnergia.Size = new System.Drawing.Size(102, 16);
            this.lblEnergia.TabIndex = 4;
            this.lblEnergia.Text = "Energia Mínima:";
            // 
            // lblAtual
            // 
            this.lblAtual.AutoSize = true;
            this.lblAtual.Location = new System.Drawing.Point(17, 164);
            this.lblAtual.Name = "lblAtual";
            this.lblAtual.Size = new System.Drawing.Size(72, 16);
            this.lblAtual.TabIndex = 5;
            this.lblAtual.Text = "Hora Atual:";
            // 
            // lblTempo
            // 
            this.lblTempo.AutoSize = true;
            this.lblTempo.Location = new System.Drawing.Point(17, 206);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(111, 16);
            this.lblTempo.TabIndex = 6;
            this.lblTempo.Text = "Tempo até o jogo:";
            // 
            // lblGanho
            // 
            this.lblGanho.AutoSize = true;
            this.lblGanho.Location = new System.Drawing.Point(17, 246);
            this.lblGanho.Name = "lblGanho";
            this.lblGanho.Size = new System.Drawing.Size(175, 16);
            this.lblGanho.TabIndex = 7;
            this.lblGanho.Text = "Ganho de energia até o jogo:";
            // 
            // lblEnergiaShow
            // 
            this.lblEnergiaShow.AutoSize = true;
            this.lblEnergiaShow.Location = new System.Drawing.Point(203, 124);
            this.lblEnergiaShow.Name = "lblEnergiaShow";
            this.lblEnergiaShow.Size = new System.Drawing.Size(0, 16);
            this.lblEnergiaShow.TabIndex = 8;
            // 
            // lblAtualShow
            // 
            this.lblAtualShow.AutoSize = true;
            this.lblAtualShow.Location = new System.Drawing.Point(203, 164);
            this.lblAtualShow.Name = "lblAtualShow";
            this.lblAtualShow.Size = new System.Drawing.Size(0, 16);
            this.lblAtualShow.TabIndex = 9;
            // 
            // lblTempoShow
            // 
            this.lblTempoShow.AutoSize = true;
            this.lblTempoShow.Location = new System.Drawing.Point(203, 206);
            this.lblTempoShow.Name = "lblTempoShow";
            this.lblTempoShow.Size = new System.Drawing.Size(0, 16);
            this.lblTempoShow.TabIndex = 10;
            // 
            // lblGanhoShow
            // 
            this.lblGanhoShow.AutoSize = true;
            this.lblGanhoShow.Location = new System.Drawing.Point(203, 246);
            this.lblGanhoShow.Name = "lblGanhoShow";
            this.lblGanhoShow.Size = new System.Drawing.Size(0, 16);
            this.lblGanhoShow.TabIndex = 11;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLimpar.Location = new System.Drawing.Point(316, 297);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(87, 28);
            this.btnLimpar.TabIndex = 2;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            this.btnLimpar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnLimpar_KeyDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TopElevenForWindows.Properties.Resources.olympics_sport_football_ball_2277;
            this.pictureBox1.Location = new System.Drawing.Point(284, 124);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 358);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lblGanhoShow);
            this.Controls.Add(this.lblTempoShow);
            this.Controls.Add(this.lblAtualShow);
            this.Controls.Add(this.lblEnergiaShow);
            this.Controls.Add(this.lblGanho);
            this.Controls.Add(this.lblTempo);
            this.Controls.Add(this.lblAtual);
            this.Controls.Add(this.lblEnergia);
            this.Controls.Add(this.lblDigite);
            this.Controls.Add(this.lblHoraDoJogo);
            this.Controls.Add(this.mskTextHoraDoJogo);
            this.Controls.Add(this.btnCalcular);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Top Eleven Time For Windows";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPrincipal_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmPrincipal_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblHoraDoJogo;
        private System.Windows.Forms.Label lblDigite;
        private System.Windows.Forms.Label lblEnergia;
        private System.Windows.Forms.Label lblAtual;
        private System.Windows.Forms.Label lblTempo;
        private System.Windows.Forms.Label lblGanho;
        private System.Windows.Forms.Label lblEnergiaShow;
        private System.Windows.Forms.Label lblAtualShow;
        private System.Windows.Forms.Label lblTempoShow;
        private System.Windows.Forms.Label lblGanhoShow;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.MaskedTextBox mskTextHoraDoJogo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

