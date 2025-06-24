namespace EJERCICIO5
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MtxtBoxNumero = new System.Windows.Forms.MaskedTextBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MtxtBoxNumero
            // 
            this.MtxtBoxNumero.Font = new System.Drawing.Font("Century Schoolbook", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MtxtBoxNumero.Location = new System.Drawing.Point(291, 191);
            this.MtxtBoxNumero.Name = "MtxtBoxNumero";
            this.MtxtBoxNumero.Size = new System.Drawing.Size(100, 59);
            this.MtxtBoxNumero.TabIndex = 0;
            this.MtxtBoxNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnVerificar
            // 
            this.btnVerificar.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnVerificar.Font = new System.Drawing.Font("Century Schoolbook", 13.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificar.Location = new System.Drawing.Point(230, 271);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(224, 90);
            this.btnVerificar.TabIndex = 1;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = false;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 16.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(512, 106);
            this.label1.TabIndex = 2;
            this.label1.Text = "Verificación de los número primos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(742, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.MtxtBoxNumero);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox MtxtBoxNumero;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Label label1;
    }
}

