
namespace cifra_de_cesar.Forms
{
    partial class Encriptar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Encriptar));
            this.BtEncriptar = new System.Windows.Forms.Button();
            this.TxEncriptar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxResult = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxK = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtEncriptar
            // 
            this.BtEncriptar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtEncriptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtEncriptar.Location = new System.Drawing.Point(459, 299);
            this.BtEncriptar.Name = "BtEncriptar";
            this.BtEncriptar.Size = new System.Drawing.Size(169, 74);
            this.BtEncriptar.TabIndex = 1;
            this.BtEncriptar.Text = "Encriptar";
            this.BtEncriptar.UseVisualStyleBackColor = false;
            this.BtEncriptar.Click += new System.EventHandler(this.BtEncriptar_Click);
            // 
            // TxEncriptar
            // 
            this.TxEncriptar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.TxEncriptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxEncriptar.Location = new System.Drawing.Point(133, 246);
            this.TxEncriptar.Name = "TxEncriptar";
            this.TxEncriptar.Size = new System.Drawing.Size(278, 28);
            this.TxEncriptar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(712, 44);
            this.label1.TabIndex = 4;
            this.label1.Text = "Função Encriptar";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(129, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Informe a palavra";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightGray;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(129, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Resultado";
            // 
            // TxResult
            // 
            this.TxResult.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.TxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxResult.Location = new System.Drawing.Point(133, 345);
            this.TxResult.Name = "TxResult";
            this.TxResult.ReadOnly = true;
            this.TxResult.Size = new System.Drawing.Size(278, 28);
            this.TxResult.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightGray;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(455, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Valor de k";
            // 
            // TxK
            // 
            this.TxK.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.TxK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxK.Location = new System.Drawing.Point(459, 246);
            this.TxK.Name = "TxK";
            this.TxK.Size = new System.Drawing.Size(91, 28);
            this.TxK.TabIndex = 8;
            this.TxK.Text = "3";
            this.TxK.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxK_KeyPress);
            this.TxK.Leave += new System.EventHandler(this.TxK_Leave);
            // 
            // Encriptar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::cifra_de_cesar.Properties.Resources.metal_texture_background_with_rivets;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(711, 473);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxEncriptar);
            this.Controls.Add(this.BtEncriptar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Encriptar";
            this.Text = "Encriptar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtEncriptar;
        private System.Windows.Forms.TextBox TxEncriptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxResult;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxK;
    }
}