﻿namespace WFAppPractica8
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
            this.button1 = new System.Windows.Forms.Button();
            this.tbx_idfactura = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_condiciones = new System.Windows.Forms.TextBox();
            this.tbx_idcliente = new System.Windows.Forms.TextBox();
            this.tbx_monto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_estado = new System.Windows.Forms.ComboBox();
            this.tbx_fecha = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(58, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(301, 89);
            this.button1.TabIndex = 0;
            this.button1.Text = "Consultar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbx_idfactura
            // 
            this.tbx_idfactura.Location = new System.Drawing.Point(183, 54);
            this.tbx_idfactura.Name = "tbx_idfactura";
            this.tbx_idfactura.Size = new System.Drawing.Size(121, 20);
            this.tbx_idfactura.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID Factura";
            // 
            // tbx_condiciones
            // 
            this.tbx_condiciones.Location = new System.Drawing.Point(183, 89);
            this.tbx_condiciones.Name = "tbx_condiciones";
            this.tbx_condiciones.Size = new System.Drawing.Size(121, 20);
            this.tbx_condiciones.TabIndex = 3;
            // 
            // tbx_idcliente
            // 
            this.tbx_idcliente.Location = new System.Drawing.Point(183, 126);
            this.tbx_idcliente.Name = "tbx_idcliente";
            this.tbx_idcliente.Size = new System.Drawing.Size(121, 20);
            this.tbx_idcliente.TabIndex = 4;
            // 
            // tbx_monto
            // 
            this.tbx_monto.Location = new System.Drawing.Point(183, 203);
            this.tbx_monto.Name = "tbx_monto";
            this.tbx_monto.Size = new System.Drawing.Size(121, 20);
            this.tbx_monto.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Condiciones";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "ID Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Fecha Factura";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(116, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Monto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(120, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Estado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(60, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(299, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Practica 8 usando Command List";
            // 
            // cmb_estado
            // 
            this.cmb_estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_estado.FormattingEnabled = true;
            this.cmb_estado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cmb_estado.Location = new System.Drawing.Point(183, 242);
            this.cmb_estado.Name = "cmb_estado";
            this.cmb_estado.Size = new System.Drawing.Size(121, 21);
            this.cmb_estado.TabIndex = 15;
            // 
            // tbx_fecha
            // 
            this.tbx_fecha.Location = new System.Drawing.Point(183, 168);
            this.tbx_fecha.Mask = "00/00/0000";
            this.tbx_fecha.Name = "tbx_fecha";
            this.tbx_fecha.Size = new System.Drawing.Size(121, 20);
            this.tbx_fecha.TabIndex = 16;
            this.tbx_fecha.ValidatingType = typeof(System.DateTime);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 409);
            this.Controls.Add(this.tbx_fecha);
            this.Controls.Add(this.cmb_estado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbx_monto);
            this.Controls.Add(this.tbx_idcliente);
            this.Controls.Add(this.tbx_condiciones);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbx_idfactura);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbx_idfactura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_condiciones;
        private System.Windows.Forms.TextBox tbx_idcliente;
        private System.Windows.Forms.TextBox tbx_monto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_estado;
        private System.Windows.Forms.MaskedTextBox tbx_fecha;
    }
}

