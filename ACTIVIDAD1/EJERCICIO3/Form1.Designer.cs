namespace EJERCICIO3
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
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.comboBoxEntrada = new System.Windows.Forms.ComboBox();
            this.comboBoxSalida = new System.Windows.Forms.ComboBox();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.labelResultado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxValor
            // 
            this.textBoxValor.BackColor = System.Drawing.Color.Thistle;
            this.textBoxValor.Font = new System.Drawing.Font("Century Schoolbook", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxValor.Location = new System.Drawing.Point(90, 116);
            this.textBoxValor.Multiline = true;
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(170, 44);
            this.textBoxValor.TabIndex = 0;
            this.textBoxValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxValor.TextChanged += new System.EventHandler(this.textBoxValor_TextChanged);
            // 
            // comboBoxEntrada
            // 
            this.comboBoxEntrada.Font = new System.Drawing.Font("Century Schoolbook", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEntrada.FormattingEnabled = true;
            this.comboBoxEntrada.Location = new System.Drawing.Point(304, 176);
            this.comboBoxEntrada.Name = "comboBoxEntrada";
            this.comboBoxEntrada.Size = new System.Drawing.Size(170, 33);
            this.comboBoxEntrada.TabIndex = 1;
            this.comboBoxEntrada.Text = "Seleccionar";
            // 
            // comboBoxSalida
            // 
            this.comboBoxSalida.Font = new System.Drawing.Font("Century Schoolbook", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSalida.FormattingEnabled = true;
            this.comboBoxSalida.Location = new System.Drawing.Point(304, 221);
            this.comboBoxSalida.Name = "comboBoxSalida";
            this.comboBoxSalida.Size = new System.Drawing.Size(170, 33);
            this.comboBoxSalida.TabIndex = 2;
            this.comboBoxSalida.Text = "Seleccionar";
            this.comboBoxSalida.SelectedIndexChanged += new System.EventHandler(this.comboBoxSalida_SelectedIndexChanged);
            // 
            // btnConvertir
            // 
            this.btnConvertir.BackColor = System.Drawing.Color.Plum;
            this.btnConvertir.Font = new System.Drawing.Font("Century Schoolbook", 7.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertir.Location = new System.Drawing.Point(281, 294);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(171, 67);
            this.btnConvertir.TabIndex = 3;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = false;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // labelResultado
            // 
            this.labelResultado.BackColor = System.Drawing.Color.Thistle;
            this.labelResultado.Font = new System.Drawing.Font("Century Schoolbook", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultado.Location = new System.Drawing.Point(473, 116);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(175, 42);
            this.labelResultado.TabIndex = 4;
            this.labelResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelResultado.Click += new System.EventHandler(this.labelResultado_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 33);
            this.label1.TabIndex = 5;
            this.label1.Text = "Unidad de Entrada:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Unidad de Salida:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(309, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 41);
            this.label3.TabIndex = 7;
            this.label3.Text = "Resultado:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Schoolbook", 16.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(103, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(532, 51);
            this.label4.TabIndex = 8;
            this.label4.Text = "Conversor de Unidades";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.comboBoxSalida);
            this.Controls.Add(this.comboBoxEntrada);
            this.Controls.Add(this.textBoxValor);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxValor;
        private System.Windows.Forms.ComboBox comboBoxEntrada;
        private System.Windows.Forms.ComboBox comboBoxSalida;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

