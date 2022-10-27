
namespace cifra_de_cesar
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.BtEnc = new System.Windows.Forms.Button();
            this.BtDes = new System.Windows.Forms.Button();
            this.BtCri = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtEnc
            // 
            this.BtEnc.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtEnc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtEnc.Location = new System.Drawing.Point(68, 232);
            this.BtEnc.Name = "BtEnc";
            this.BtEnc.Size = new System.Drawing.Size(187, 125);
            this.BtEnc.TabIndex = 0;
            this.BtEnc.Text = "Encriptar";
            this.BtEnc.UseVisualStyleBackColor = false;
            this.BtEnc.Click += new System.EventHandler(this.BtEnc_Click);
            // 
            // BtDes
            // 
            this.BtDes.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtDes.Location = new System.Drawing.Point(311, 232);
            this.BtDes.Name = "BtDes";
            this.BtDes.Size = new System.Drawing.Size(187, 125);
            this.BtDes.TabIndex = 1;
            this.BtDes.Text = "Desencriptar";
            this.BtDes.UseVisualStyleBackColor = false;
            this.BtDes.Click += new System.EventHandler(this.BtDes_Click);
            // 
            // BtCri
            // 
            this.BtCri.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtCri.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtCri.Location = new System.Drawing.Point(559, 232);
            this.BtCri.Name = "BtCri";
            this.BtCri.Size = new System.Drawing.Size(187, 125);
            this.BtCri.TabIndex = 2;
            this.BtCri.Text = "Criptoanalise";
            this.BtCri.UseVisualStyleBackColor = false;
            this.BtCri.Click += new System.EventHandler(this.BtCri_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(799, 44);
            this.label1.TabIndex = 3;
            this.label1.Text = "Escolha uma opção";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::cifra_de_cesar.Properties.Resources.metal_texture_background_with_rivets;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtCri);
            this.Controls.Add(this.BtDes);
            this.Controls.Add(this.BtEnc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Principal";
            this.Text = "Cifra de Cesar";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtEnc;
        private System.Windows.Forms.Button BtDes;
        private System.Windows.Forms.Button BtCri;
        private System.Windows.Forms.Label label1;
    }
}

