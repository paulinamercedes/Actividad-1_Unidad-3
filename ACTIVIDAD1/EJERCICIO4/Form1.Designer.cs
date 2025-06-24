namespace EJERCICIO4
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
            this.textBoxPalabra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxPalabra
            // 
            this.textBoxPalabra.Font = new System.Drawing.Font("Century Schoolbook", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPalabra.Location = new System.Drawing.Point(232, 206);
            this.textBoxPalabra.Multiline = true;
            this.textBoxPalabra.Name = "textBoxPalabra";
            this.textBoxPalabra.Size = new System.Drawing.Size(239, 86);
            this.textBoxPalabra.TabIndex = 0;
            this.textBoxPalabra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPalabra.TextChanged += new System.EventHandler(this.textBoxPalabra_TextChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 16.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(12, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(703, 122);
            this.label1.TabIndex = 1;
            this.label1.Text = "Comprobar La Palabra Palíndroma";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnVerificar
            // 
            this.btnVerificar.BackColor = System.Drawing.Color.LightBlue;
            this.btnVerificar.Font = new System.Drawing.Font("Century Schoolbook", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificar.Location = new System.Drawing.Point(256, 309);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(204, 72);
            this.btnVerificar.TabIndex = 2;
            this.btnVerificar.Text = "Comprobar";
            this.btnVerificar.UseVisualStyleBackColor = false;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(764, 434);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPalabra);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPalabra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVerificar;
    }
}

