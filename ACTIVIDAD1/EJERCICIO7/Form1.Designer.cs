namespace EJERCICIO7
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
            this.textBoxInicio = new System.Windows.Forms.TextBox();
            this.textBoxFin = new System.Windows.Forms.TextBox();
            this.lstBoxPrimos = new System.Windows.Forms.ListBox();
            this.btnNumPrimos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxInicio
            // 
            this.textBoxInicio.BackColor = System.Drawing.Color.MistyRose;
            this.textBoxInicio.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInicio.Location = new System.Drawing.Point(103, 190);
            this.textBoxInicio.Name = "textBoxInicio";
            this.textBoxInicio.Size = new System.Drawing.Size(100, 46);
            this.textBoxInicio.TabIndex = 0;
            this.textBoxInicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxFin
            // 
            this.textBoxFin.BackColor = System.Drawing.Color.MistyRose;
            this.textBoxFin.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFin.Location = new System.Drawing.Point(292, 190);
            this.textBoxFin.Name = "textBoxFin";
            this.textBoxFin.Size = new System.Drawing.Size(100, 46);
            this.textBoxFin.TabIndex = 1;
            this.textBoxFin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lstBoxPrimos
            // 
            this.lstBoxPrimos.BackColor = System.Drawing.Color.MistyRose;
            this.lstBoxPrimos.Font = new System.Drawing.Font("Century Schoolbook", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBoxPrimos.FormattingEnabled = true;
            this.lstBoxPrimos.ItemHeight = 33;
            this.lstBoxPrimos.Location = new System.Drawing.Point(496, 114);
            this.lstBoxPrimos.Name = "lstBoxPrimos";
            this.lstBoxPrimos.Size = new System.Drawing.Size(212, 202);
            this.lstBoxPrimos.TabIndex = 2;
            this.lstBoxPrimos.SelectedIndexChanged += new System.EventHandler(this.lstBoxPrimos_SelectedIndexChanged);
            // 
            // btnNumPrimos
            // 
            this.btnNumPrimos.BackColor = System.Drawing.Color.LightPink;
            this.btnNumPrimos.Font = new System.Drawing.Font("Century Schoolbook", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumPrimos.Location = new System.Drawing.Point(141, 256);
            this.btnNumPrimos.Name = "btnNumPrimos";
            this.btnNumPrimos.Size = new System.Drawing.Size(209, 72);
            this.btnNumPrimos.TabIndex = 3;
            this.btnNumPrimos.Text = "Buscar ";
            this.btnNumPrimos.UseVisualStyleBackColor = false;
            this.btnNumPrimos.Click += new System.EventHandler(this.btnNumPrimos_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 10.875F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 41);
            this.label1.TabIndex = 4;
            this.label1.Text = "Inicio";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 10.875F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(292, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 41);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fin";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(65, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(377, 93);
            this.label3.TabIndex = 6;
            this.label3.Text = "Rango en números primos";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNumPrimos);
            this.Controls.Add(this.lstBoxPrimos);
            this.Controls.Add(this.textBoxFin);
            this.Controls.Add(this.textBoxInicio);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInicio;
        private System.Windows.Forms.TextBox textBoxFin;
        private System.Windows.Forms.ListBox lstBoxPrimos;
        private System.Windows.Forms.Button btnNumPrimos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

