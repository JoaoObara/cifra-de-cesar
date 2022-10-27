
namespace cifra_de_cesar.Forms
{
    partial class Criptoanalise
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Criptoanalise));
            this.label4 = new System.Windows.Forms.Label();
            this.TxT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxResult = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxDesencriptar = new System.Windows.Forms.TextBox();
            this.BtDesencriptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightGray;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(332, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 24);
            this.label4.TabIndex = 25;
            this.label4.Text = "Tentativas";
            // 
            // TxT
            // 
            this.TxT.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.TxT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxT.Location = new System.Drawing.Point(336, 179);
            this.TxT.Name = "TxT";
            this.TxT.Size = new System.Drawing.Size(91, 28);
            this.TxT.TabIndex = 24;
            this.TxT.Text = "10";
            this.TxT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxT_KeyPress);
            this.TxT.Leave += new System.EventHandler(this.TxT_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightGray;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(343, 24);
            this.label3.TabIndex = 23;
            this.label3.Text = "Resultados (texto em claro e valor de K)";
            // 
            // TxResult
            // 
            this.TxResult.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.TxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxResult.Location = new System.Drawing.Point(24, 330);
            this.TxResult.Multiline = true;
            this.TxResult.Name = "TxResult";
            this.TxResult.ReadOnly = true;
            this.TxResult.Size = new System.Drawing.Size(682, 279);
            this.TxResult.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 24);
            this.label2.TabIndex = 21;
            this.label2.Text = "Texto Cifrado";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-1, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(720, 44);
            this.label1.TabIndex = 20;
            this.label1.Text = "Função Criptoanalise";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TxDesencriptar
            // 
            this.TxDesencriptar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.TxDesencriptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxDesencriptar.Location = new System.Drawing.Point(24, 179);
            this.TxDesencriptar.Name = "TxDesencriptar";
            this.TxDesencriptar.Size = new System.Drawing.Size(278, 28);
            this.TxDesencriptar.TabIndex = 18;
            // 
            // BtDesencriptar
            // 
            this.BtDesencriptar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtDesencriptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtDesencriptar.Location = new System.Drawing.Point(507, 152);
            this.BtDesencriptar.Name = "BtDesencriptar";
            this.BtDesencriptar.Size = new System.Drawing.Size(169, 74);
            this.BtDesencriptar.TabIndex = 19;
            this.BtDesencriptar.Text = "Desencriptar";
            this.BtDesencriptar.UseVisualStyleBackColor = false;
            this.BtDesencriptar.Click += new System.EventHandler(this.BtDesencriptar_Click);
            // 
            // Criptoanalise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::cifra_de_cesar.Properties.Resources.metal_texture_background_with_rivets;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(718, 621);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxDesencriptar);
            this.Controls.Add(this.BtDesencriptar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Criptoanalise";
            this.Text = "Criptoanalise";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxDesencriptar;
        private System.Windows.Forms.Button BtDesencriptar;
    }
}