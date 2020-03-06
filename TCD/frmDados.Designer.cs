namespace TCD
{
    partial class frmDados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDados));
            this.txtT1 = new System.Windows.Forms.TextBox();
            this.txtT2 = new System.Windows.Forms.TextBox();
            this.txtT3 = new System.Windows.Forms.TextBox();
            this.txtT4 = new System.Windows.Forms.TextBox();
            this.txtTTotal = new System.Windows.Forms.TextBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDigiteTempoMax = new System.Windows.Forms.Label();
            this.lblDigiteT1 = new System.Windows.Forms.Label();
            this.lblDigiteT2 = new System.Windows.Forms.Label();
            this.lblDigiteT3 = new System.Windows.Forms.Label();
            this.lblDigiteT4 = new System.Windows.Forms.Label();
            this.lblCreditos = new System.Windows.Forms.Label();
            this.lblRegras = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtT1
            // 
            this.txtT1.Location = new System.Drawing.Point(454, 257);
            this.txtT1.Name = "txtT1";
            this.txtT1.Size = new System.Drawing.Size(64, 20);
            this.txtT1.TabIndex = 0;
            this.txtT1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.formatarTempos);
            // 
            // txtT2
            // 
            this.txtT2.Location = new System.Drawing.Point(454, 285);
            this.txtT2.Name = "txtT2";
            this.txtT2.Size = new System.Drawing.Size(64, 20);
            this.txtT2.TabIndex = 1;
            this.txtT2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.formatarTempos);
            // 
            // txtT3
            // 
            this.txtT3.Location = new System.Drawing.Point(454, 311);
            this.txtT3.Name = "txtT3";
            this.txtT3.Size = new System.Drawing.Size(64, 20);
            this.txtT3.TabIndex = 2;
            this.txtT3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.formatarTempos);
            // 
            // txtT4
            // 
            this.txtT4.Location = new System.Drawing.Point(454, 337);
            this.txtT4.Name = "txtT4";
            this.txtT4.Size = new System.Drawing.Size(64, 20);
            this.txtT4.TabIndex = 3;
            this.txtT4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.formatarTempos);
            // 
            // txtTTotal
            // 
            this.txtTTotal.Location = new System.Drawing.Point(454, 382);
            this.txtTTotal.Name = "txtTTotal";
            this.txtTTotal.Size = new System.Drawing.Size(64, 20);
            this.txtTTotal.TabIndex = 4;
            this.txtTTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.formatarTempos);
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(12, 420);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(506, 54);
            this.btnIniciar.TabIndex = 5;
            this.btnIniciar.Text = "JOGAR";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(506, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // lblDigiteTempoMax
            // 
            this.lblDigiteTempoMax.AutoSize = true;
            this.lblDigiteTempoMax.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDigiteTempoMax.Location = new System.Drawing.Point(334, 382);
            this.lblDigiteTempoMax.Name = "lblDigiteTempoMax";
            this.lblDigiteTempoMax.Size = new System.Drawing.Size(103, 18);
            this.lblDigiteTempoMax.TabIndex = 11;
            this.lblDigiteTempoMax.Text = "Tempo Máximo";
            // 
            // lblDigiteT1
            // 
            this.lblDigiteT1.AutoSize = true;
            this.lblDigiteT1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDigiteT1.Location = new System.Drawing.Point(334, 259);
            this.lblDigiteT1.Name = "lblDigiteT1";
            this.lblDigiteT1.Size = new System.Drawing.Size(99, 18);
            this.lblDigiteT1.TabIndex = 9;
            this.lblDigiteT1.Text = "Tempo 1 - John";
            // 
            // lblDigiteT2
            // 
            this.lblDigiteT2.AutoSize = true;
            this.lblDigiteT2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDigiteT2.Location = new System.Drawing.Point(334, 285);
            this.lblDigiteT2.Name = "lblDigiteT2";
            this.lblDigiteT2.Size = new System.Drawing.Size(97, 18);
            this.lblDigiteT2.TabIndex = 9;
            this.lblDigiteT2.Text = "Tempo 2 - Paul";
            // 
            // lblDigiteT3
            // 
            this.lblDigiteT3.AutoSize = true;
            this.lblDigiteT3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDigiteT3.Location = new System.Drawing.Point(334, 311);
            this.lblDigiteT3.Name = "lblDigiteT3";
            this.lblDigiteT3.Size = new System.Drawing.Size(114, 18);
            this.lblDigiteT3.TabIndex = 10;
            this.lblDigiteT3.Text = "Tempo 3 - George";
            // 
            // lblDigiteT4
            // 
            this.lblDigiteT4.AutoSize = true;
            this.lblDigiteT4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDigiteT4.Location = new System.Drawing.Point(334, 337);
            this.lblDigiteT4.Name = "lblDigiteT4";
            this.lblDigiteT4.Size = new System.Drawing.Size(105, 18);
            this.lblDigiteT4.TabIndex = 11;
            this.lblDigiteT4.Text = "Tempo 4 - Ringo";
            // 
            // lblCreditos
            // 
            this.lblCreditos.AutoSize = true;
            this.lblCreditos.Location = new System.Drawing.Point(347, 477);
            this.lblCreditos.Name = "lblCreditos";
            this.lblCreditos.Size = new System.Drawing.Size(171, 13);
            this.lblCreditos.TabIndex = 12;
            this.lblCreditos.Text = "by Lucas Miranda e Higor Gustavo";
            // 
            // lblRegras
            // 
            this.lblRegras.AutoSize = true;
            this.lblRegras.Location = new System.Drawing.Point(9, 260);
            this.lblRegras.Name = "lblRegras";
            this.lblRegras.Size = new System.Drawing.Size(51, 13);
            this.lblRegras.TabIndex = 13;
            this.lblRegras.Text = "lblRegras";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(9, 157);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(35, 13);
            this.lblInfo.TabIndex = 14;
            this.lblInfo.Text = "lblInfo";
            // 
            // frmDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 499);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblRegras);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.lblCreditos);
            this.Controls.Add(this.lblDigiteT4);
            this.Controls.Add(this.lblDigiteT3);
            this.Controls.Add(this.lblDigiteT2);
            this.Controls.Add(this.lblDigiteT1);
            this.Controls.Add(this.lblDigiteTempoMax);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtTTotal);
            this.Controls.Add(this.txtT4);
            this.Controls.Add(this.txtT3);
            this.Controls.Add(this.txtT2);
            this.Controls.Add(this.txtT1);
            this.MaximizeBox = false;
            this.Name = "frmDados";
            this.Text = "The Beatles - Cross the Bridge";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtT1;
        private System.Windows.Forms.TextBox txtT2;
        private System.Windows.Forms.TextBox txtT3;
        private System.Windows.Forms.TextBox txtT4;
        private System.Windows.Forms.TextBox txtTTotal;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblDigiteTempoMax;
        private System.Windows.Forms.Label lblDigiteT1;
        private System.Windows.Forms.Label lblDigiteT2;
        private System.Windows.Forms.Label lblDigiteT3;
        private System.Windows.Forms.Label lblDigiteT4;
        private System.Windows.Forms.Label lblCreditos;
        private System.Windows.Forms.Label lblRegras;
        private System.Windows.Forms.Label lblInfo;
    }
}

