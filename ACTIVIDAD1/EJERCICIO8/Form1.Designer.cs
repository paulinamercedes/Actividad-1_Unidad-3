namespace EJERCICIO8
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
            this.textBoxOracion = new System.Windows.Forms.TextBox();
            this.btnOracion = new System.Windows.Forms.Button();
            this.lblPalabras = new System.Windows.Forms.Label();
            this.labelOracion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxOracion
            // 
            this.textBoxOracion.Font = new System.Drawing.Font("Century Schoolbook", 10.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOracion.Location = new System.Drawing.Point(68, 209);
            this.textBoxOracion.Multiline = true;
            this.textBoxOracion.Name = "textBoxOracion";
            this.textBoxOracion.Size = new System.Drawing.Size(330, 42);
            this.textBoxOracion.TabIndex = 0;
            this.textBoxOracion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnOracion
            // 
            this.btnOracion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnOracion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOracion.Font = new System.Drawing.Font("Century Schoolbook", 7.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOracion.Location = new System.Drawing.Point(122, 266);
            this.btnOracion.Name = "btnOracion";
            this.btnOracion.Size = new System.Drawing.Size(223, 66);
            this.btnOracion.TabIndex = 1;
            this.btnOracion.Text = "Contar Palabras";
            this.btnOracion.UseVisualStyleBackColor = false;
            this.btnOracion.Click += new System.EventHandler(this.btnOracion_Click);
            // 
            // lblPalabras
            // 
            this.lblPalabras.BackColor = System.Drawing.Color.Transparent;
            this.lblPalabras.Font = new System.Drawing.Font("Century Schoolbook", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPalabras.Location = new System.Drawing.Point(431, 201);
            this.lblPalabras.Name = "lblPalabras";
            this.lblPalabras.Size = new System.Drawing.Size(225, 55);
            this.lblPalabras.TabIndex = 2;
            this.lblPalabras.Text = "Cantidad: 0";
            this.lblPalabras.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelOracion
            // 
            this.labelOracion.BackColor = System.Drawing.Color.Transparent;
            this.labelOracion.Font = new System.Drawing.Font("Century Schoolbook", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOracion.Location = new System.Drawing.Point(103, 157);
            this.labelOracion.Name = "labelOracion";
            this.labelOracion.Size = new System.Drawing.Size(270, 49);
            this.labelOracion.TabIndex = 3;
            this.labelOracion.Text = "Escribir Oración";
            this.labelOracion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelOracion);
            this.Controls.Add(this.lblPalabras);
            this.Controls.Add(this.btnOracion);
            this.Controls.Add(this.textBoxOracion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxOracion;
        private System.Windows.Forms.Button btnOracion;
        private System.Windows.Forms.Label lblPalabras;
        private System.Windows.Forms.Label labelOracion;
        private System.Windows.Forms.Label label1;
    }
}

