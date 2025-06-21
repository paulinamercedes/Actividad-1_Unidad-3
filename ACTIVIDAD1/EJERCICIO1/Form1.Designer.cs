namespace EJERCICIO1
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
            this.BotonTabla = new System.Windows.Forms.Button();
            this.TextBoxNum = new System.Windows.Forms.TextBox();
            this.ListBoxTabla = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // BotonTabla
            // 
            this.BotonTabla.BackColor = System.Drawing.Color.MistyRose;
            this.BotonTabla.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonTabla.Location = new System.Drawing.Point(42, 165);
            this.BotonTabla.Name = "BotonTabla";
            this.BotonTabla.Size = new System.Drawing.Size(192, 57);
            this.BotonTabla.TabIndex = 0;
            this.BotonTabla.Text = "Crear Tabla";
            this.BotonTabla.UseVisualStyleBackColor = false;
            this.BotonTabla.Click += new System.EventHandler(this.BotonTabla_Click);
            // 
            // TextBoxNum
            // 
            this.TextBoxNum.Font = new System.Drawing.Font("Century Schoolbook", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxNum.Location = new System.Drawing.Point(83, 85);
            this.TextBoxNum.Name = "TextBoxNum";
            this.TextBoxNum.Size = new System.Drawing.Size(100, 40);
            this.TextBoxNum.TabIndex = 1;
            // 
            // ListBoxTabla
            // 
            this.ListBoxTabla.BackColor = System.Drawing.Color.GhostWhite;
            this.ListBoxTabla.Font = new System.Drawing.Font("Century Schoolbook", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBoxTabla.FormattingEnabled = true;
            this.ListBoxTabla.ItemHeight = 33;
            this.ListBoxTabla.Location = new System.Drawing.Point(446, 65);
            this.ListBoxTabla.Name = "ListBoxTabla";
            this.ListBoxTabla.Size = new System.Drawing.Size(256, 202);
            this.ListBoxTabla.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ListBoxTabla);
            this.Controls.Add(this.TextBoxNum);
            this.Controls.Add(this.BotonTabla);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BotonTabla;
        private System.Windows.Forms.TextBox TextBoxNum;
        private System.Windows.Forms.ListBox ListBoxTabla;
    }
}

