
namespace IMCforWindows
{
    partial class Frm_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Principal));
            this.But_Calculator = new System.Windows.Forms.Button();
            this.Lbl1_Peso = new System.Windows.Forms.Label();
            this.Lbl2_Altura = new System.Windows.Forms.Label();
            this.Mask1_Peso = new System.Windows.Forms.MaskedTextBox();
            this.Mask2_Altura = new System.Windows.Forms.MaskedTextBox();
            this.Lbl_Resultado = new System.Windows.Forms.Label();
            this.But_Limpar = new System.Windows.Forms.Button();
            this.Lbl_Diag = new System.Windows.Forms.Label();
            this.Lbl_IMC = new System.Windows.Forms.Label();
            this.lbl_Version = new System.Windows.Forms.Label();
            this.lblTeste = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // But_Calculator
            // 
            this.But_Calculator.Location = new System.Drawing.Point(75, 140);
            this.But_Calculator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.But_Calculator.Name = "But_Calculator";
            this.But_Calculator.Size = new System.Drawing.Size(87, 28);
            this.But_Calculator.TabIndex = 2;
            this.But_Calculator.Text = "Calcular IMC";
            this.But_Calculator.UseVisualStyleBackColor = true;
            this.But_Calculator.Click += new System.EventHandler(this.But_Calculator_Click);
            this.But_Calculator.KeyDown += new System.Windows.Forms.KeyEventHandler(this.But_Calculator_KeyDown);
            // 
            // Lbl1_Peso
            // 
            this.Lbl1_Peso.AutoSize = true;
            this.Lbl1_Peso.Location = new System.Drawing.Point(28, 47);
            this.Lbl1_Peso.Name = "Lbl1_Peso";
            this.Lbl1_Peso.Size = new System.Drawing.Size(42, 16);
            this.Lbl1_Peso.TabIndex = 1;
            this.Lbl1_Peso.Text = "Peso:";
            // 
            // Lbl2_Altura
            // 
            this.Lbl2_Altura.AutoSize = true;
            this.Lbl2_Altura.Location = new System.Drawing.Point(28, 91);
            this.Lbl2_Altura.Name = "Lbl2_Altura";
            this.Lbl2_Altura.Size = new System.Drawing.Size(46, 16);
            this.Lbl2_Altura.TabIndex = 2;
            this.Lbl2_Altura.Text = "Altura:";
            // 
            // Mask1_Peso
            // 
            this.Mask1_Peso.Location = new System.Drawing.Point(75, 43);
            this.Mask1_Peso.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Mask1_Peso.Mask = "000";
            this.Mask1_Peso.Name = "Mask1_Peso";
            this.Mask1_Peso.Size = new System.Drawing.Size(37, 22);
            this.Mask1_Peso.TabIndex = 0;
            this.Mask1_Peso.ValidatingType = typeof(int);
            this.Mask1_Peso.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.Mask1_Peso_MaskInputRejected);
            // 
            // Mask2_Altura
            // 
            this.Mask2_Altura.Location = new System.Drawing.Point(75, 87);
            this.Mask2_Altura.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Mask2_Altura.Mask = "0,00";
            this.Mask2_Altura.Name = "Mask2_Altura";
            this.Mask2_Altura.Size = new System.Drawing.Size(37, 22);
            this.Mask2_Altura.TabIndex = 1;
            this.Mask2_Altura.ValidatingType = typeof(int);
            this.Mask2_Altura.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.Mask2_Altura_MaskInputRejected);
            this.Mask2_Altura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Mask2_Altura_KeyPress);
            // 
            // Lbl_Resultado
            // 
            this.Lbl_Resultado.AutoSize = true;
            this.Lbl_Resultado.Location = new System.Drawing.Point(71, 213);
            this.Lbl_Resultado.Name = "Lbl_Resultado";
            this.Lbl_Resultado.Size = new System.Drawing.Size(0, 16);
            this.Lbl_Resultado.TabIndex = 5;
            // 
            // But_Limpar
            // 
            this.But_Limpar.Location = new System.Drawing.Point(185, 140);
            this.But_Limpar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.But_Limpar.Name = "But_Limpar";
            this.But_Limpar.Size = new System.Drawing.Size(87, 28);
            this.But_Limpar.TabIndex = 3;
            this.But_Limpar.Text = "Limpar";
            this.But_Limpar.UseVisualStyleBackColor = true;
            this.But_Limpar.Click += new System.EventHandler(this.But_Limpar_Click);
            // 
            // Lbl_Diag
            // 
            this.Lbl_Diag.AutoSize = true;
            this.Lbl_Diag.Location = new System.Drawing.Point(209, 91);
            this.Lbl_Diag.Name = "Lbl_Diag";
            this.Lbl_Diag.Size = new System.Drawing.Size(0, 16);
            this.Lbl_Diag.TabIndex = 6;
            // 
            // Lbl_IMC
            // 
            this.Lbl_IMC.AutoSize = true;
            this.Lbl_IMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_IMC.Location = new System.Drawing.Point(205, 57);
            this.Lbl_IMC.Name = "Lbl_IMC";
            this.Lbl_IMC.Size = new System.Drawing.Size(29, 13);
            this.Lbl_IMC.TabIndex = 7;
            this.Lbl_IMC.Text = "IMC";
            // 
            // lbl_Version
            // 
            this.lbl_Version.AutoSize = true;
            this.lbl_Version.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Version.Location = new System.Drawing.Point(250, 286);
            this.lbl_Version.Name = "lbl_Version";
            this.lbl_Version.Size = new System.Drawing.Size(50, 12);
            this.lbl_Version.TabIndex = 8;
            this.lbl_Version.Text = "Versão 3.0";
            this.lbl_Version.UseMnemonic = false;
            // 
            // lblTeste
            // 
            this.lblTeste.AutoSize = true;
            this.lblTeste.Location = new System.Drawing.Point(31, 254);
            this.lblTeste.Name = "lblTeste";
            this.lblTeste.Size = new System.Drawing.Size(0, 16);
            this.lblTeste.TabIndex = 9;
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 302);
            this.Controls.Add(this.lblTeste);
            this.Controls.Add(this.lbl_Version);
            this.Controls.Add(this.Lbl_IMC);
            this.Controls.Add(this.Lbl_Diag);
            this.Controls.Add(this.But_Limpar);
            this.Controls.Add(this.Lbl_Resultado);
            this.Controls.Add(this.Mask2_Altura);
            this.Controls.Add(this.Mask1_Peso);
            this.Controls.Add(this.Lbl2_Altura);
            this.Controls.Add(this.Lbl1_Peso);
            this.Controls.Add(this.But_Calculator);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IMC for Windows";
            this.Load += new System.EventHandler(this.Frm_Principal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button But_Calculator;
        private System.Windows.Forms.Label Lbl1_Peso;
        private System.Windows.Forms.Label Lbl2_Altura;
        private System.Windows.Forms.MaskedTextBox Mask1_Peso;
        private System.Windows.Forms.MaskedTextBox Mask2_Altura;
        private System.Windows.Forms.Label Lbl_Resultado;
        private System.Windows.Forms.Button But_Limpar;
        private System.Windows.Forms.Label Lbl_Diag;
        private System.Windows.Forms.Label Lbl_IMC;
        private System.Windows.Forms.Label lbl_Version;
        private System.Windows.Forms.Label lblTeste;
    }
}

