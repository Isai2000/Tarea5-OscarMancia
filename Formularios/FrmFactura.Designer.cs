namespace Tarea5_OscarMancia.Formularios
{
    partial class FrmFactura
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCode = new System.Windows.Forms.TextBox();
            this.TxtProducto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtCant = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtPrecu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.DtgDatos = new System.Windows.Forms.DataGridView();
            this.TxtSub = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtISV = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtDescrip = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.DcCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DcProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DcDescrip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DcCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DcPrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DcTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DtgDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(132, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(476, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "TIENDAS ESPERANZA DE VIDA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Codigo:";
            // 
            // TxtCode
            // 
            this.TxtCode.Location = new System.Drawing.Point(106, 88);
            this.TxtCode.Name = "TxtCode";
            this.TxtCode.Size = new System.Drawing.Size(100, 25);
            this.TxtCode.TabIndex = 0;
            // 
            // TxtProducto
            // 
            this.TxtProducto.Location = new System.Drawing.Point(106, 119);
            this.TxtProducto.Name = "TxtProducto";
            this.TxtProducto.Size = new System.Drawing.Size(197, 25);
            this.TxtProducto.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Producto:";
            // 
            // TxtCant
            // 
            this.TxtCant.Location = new System.Drawing.Point(106, 181);
            this.TxtCant.Name = "TxtCant";
            this.TxtCant.Size = new System.Drawing.Size(100, 25);
            this.TxtCant.TabIndex = 3;
            this.TxtCant.TextChanged += new System.EventHandler(this.TxtCant_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cantidad:";
            // 
            // TxtPrecu
            // 
            this.TxtPrecu.Location = new System.Drawing.Point(106, 212);
            this.TxtPrecu.Name = "TxtPrecu";
            this.TxtPrecu.Size = new System.Drawing.Size(100, 25);
            this.TxtPrecu.TabIndex = 4;
            this.TxtPrecu.TextChanged += new System.EventHandler(this.TxtPrecu_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Precio Unitario:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(358, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 39);
            this.button1.TabIndex = 5;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(464, 85);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 39);
            this.button2.TabIndex = 6;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(570, 85);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 39);
            this.button3.TabIndex = 7;
            this.button3.Text = "Salir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // DtgDatos
            // 
            this.DtgDatos.AllowUserToAddRows = false;
            this.DtgDatos.AllowUserToDeleteRows = false;
            this.DtgDatos.AllowUserToResizeColumns = false;
            this.DtgDatos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.DtgDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DtgDatos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DtgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DcCodigo,
            this.DcProducto,
            this.DcDescrip,
            this.DcCantidad,
            this.DcPrecioUnitario,
            this.DcTotal});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DtgDatos.DefaultCellStyle = dataGridViewCellStyle2;
            this.DtgDatos.GridColor = System.Drawing.Color.Cyan;
            this.DtgDatos.Location = new System.Drawing.Point(12, 243);
            this.DtgDatos.Name = "DtgDatos";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.DtgDatos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DtgDatos.Size = new System.Drawing.Size(768, 174);
            this.DtgDatos.TabIndex = 12;
            // 
            // TxtSub
            // 
            this.TxtSub.BackColor = System.Drawing.Color.White;
            this.TxtSub.Location = new System.Drawing.Point(89, 423);
            this.TxtSub.Name = "TxtSub";
            this.TxtSub.ReadOnly = true;
            this.TxtSub.Size = new System.Drawing.Size(100, 25);
            this.TxtSub.TabIndex = 14;
            this.TxtSub.Text = "0.0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 426);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Sub-Total:";
            // 
            // TxtISV
            // 
            this.TxtISV.BackColor = System.Drawing.Color.White;
            this.TxtISV.Location = new System.Drawing.Point(89, 454);
            this.TxtISV.Name = "TxtISV";
            this.TxtISV.ReadOnly = true;
            this.TxtISV.Size = new System.Drawing.Size(100, 25);
            this.TxtISV.TabIndex = 16;
            this.TxtISV.Text = "0.0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 459);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "I.S.V:";
            // 
            // TxtTotal
            // 
            this.TxtTotal.BackColor = System.Drawing.Color.White;
            this.TxtTotal.Location = new System.Drawing.Point(89, 485);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.ReadOnly = true;
            this.TxtTotal.Size = new System.Drawing.Size(100, 25);
            this.TxtTotal.TabIndex = 18;
            this.TxtTotal.Text = "0.0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 485);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Total:";
            // 
            // TxtDescrip
            // 
            this.TxtDescrip.Location = new System.Drawing.Point(106, 150);
            this.TxtDescrip.Name = "TxtDescrip";
            this.TxtDescrip.Size = new System.Drawing.Size(256, 25);
            this.TxtDescrip.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Descripcion:";
            // 
            // DcCodigo
            // 
            this.DcCodigo.HeaderText = "CODIGO";
            this.DcCodigo.Name = "DcCodigo";
            this.DcCodigo.Width = 80;
            // 
            // DcProducto
            // 
            this.DcProducto.HeaderText = "PRODUCTO";
            this.DcProducto.Name = "DcProducto";
            // 
            // DcDescrip
            // 
            this.DcDescrip.HeaderText = "DESCRIPCION";
            this.DcDescrip.Name = "DcDescrip";
            this.DcDescrip.Width = 300;
            // 
            // DcCantidad
            // 
            this.DcCantidad.HeaderText = "CANTIDAD";
            this.DcCantidad.Name = "DcCantidad";
            this.DcCantidad.Width = 80;
            // 
            // DcPrecioUnitario
            // 
            this.DcPrecioUnitario.HeaderText = "PRECIO UNITARIO";
            this.DcPrecioUnitario.Name = "DcPrecioUnitario";
            this.DcPrecioUnitario.Width = 80;
            // 
            // DcTotal
            // 
            this.DcTotal.HeaderText = "TOTAL";
            this.DcTotal.Name = "DcTotal";
            this.DcTotal.Width = 80;
            // 
            // FrmFactura
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(792, 517);
            this.ControlBox = false;
            this.Controls.Add(this.TxtDescrip);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TxtTotal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtISV);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtSub);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DtgDatos);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtPrecu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtCant);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtProducto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FACTURADOR";
            ((System.ComponentModel.ISupportInitialize)(this.DtgDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtCode;
        private System.Windows.Forms.TextBox TxtProducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtCant;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtPrecu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView DtgDatos;
        private System.Windows.Forms.TextBox TxtSub;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtISV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtDescrip;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcDescrip;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcPrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcTotal;
    }
}