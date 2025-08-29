namespace SenhaParaTCC
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtNumeroUm = new System.Windows.Forms.TextBox();
            this.txtNumeroTres = new System.Windows.Forms.TextBox();
            this.txtNumeroDois = new System.Windows.Forms.TextBox();
            this.txtNumeroQuatro = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(330, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtNumeroUm
            // 
            this.txtNumeroUm.Location = new System.Drawing.Point(83, 62);
            this.txtNumeroUm.Name = "txtNumeroUm";
            this.txtNumeroUm.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroUm.TabIndex = 1;
            // 
            // txtNumeroTres
            // 
            this.txtNumeroTres.Location = new System.Drawing.Point(83, 185);
            this.txtNumeroTres.Name = "txtNumeroTres";
            this.txtNumeroTres.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroTres.TabIndex = 2;
            // 
            // txtNumeroDois
            // 
            this.txtNumeroDois.Location = new System.Drawing.Point(83, 123);
            this.txtNumeroDois.Name = "txtNumeroDois";
            this.txtNumeroDois.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroDois.TabIndex = 3;
            // 
            // txtNumeroQuatro
            // 
            this.txtNumeroQuatro.Location = new System.Drawing.Point(83, 231);
            this.txtNumeroQuatro.Name = "txtNumeroQuatro";
            this.txtNumeroQuatro.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroQuatro.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNumeroQuatro);
            this.Controls.Add(this.txtNumeroDois);
            this.Controls.Add(this.txtNumeroTres);
            this.Controls.Add(this.txtNumeroUm);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNumeroUm;
        private System.Windows.Forms.TextBox txtNumeroTres;
        private System.Windows.Forms.TextBox txtNumeroDois;
        private System.Windows.Forms.TextBox txtNumeroQuatro;
    }
}

