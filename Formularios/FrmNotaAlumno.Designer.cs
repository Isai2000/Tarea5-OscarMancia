namespace Tarea5_OscarMancia.Formularios
{
    partial class FrmNotaAlumno
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtCal1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtCal2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtCal3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtCal4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.DtvDatos = new System.Windows.Forms.DataGridView();
            this.TxtPromGen = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtAprobado = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtReprobado = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.DcNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DcCalificacion1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DcCalificacion2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DcCalificacion3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DcCalificacion4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DcPromedio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DtvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(130, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(498, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "Planilla de Notas";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre:";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(103, 63);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(234, 25);
            this.TxtNombre.TabIndex = 3;
            // 
            // TxtCal1
            // 
            this.TxtCal1.Location = new System.Drawing.Point(103, 94);
            this.TxtCal1.Name = "TxtCal1";
            this.TxtCal1.Size = new System.Drawing.Size(104, 25);
            this.TxtCal1.TabIndex = 5;
            this.TxtCal1.TextChanged += new System.EventHandler(this.TxtCal1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Calificacion 1:";
            // 
            // TxtCal2
            // 
            this.TxtCal2.Location = new System.Drawing.Point(103, 125);
            this.TxtCal2.Name = "TxtCal2";
            this.TxtCal2.Size = new System.Drawing.Size(104, 25);
            this.TxtCal2.TabIndex = 7;
            this.TxtCal2.TextChanged += new System.EventHandler(this.TxtCal2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Calificacion 2:";
            // 
            // TxtCal3
            // 
            this.TxtCal3.Location = new System.Drawing.Point(103, 156);
            this.TxtCal3.Name = "TxtCal3";
            this.TxtCal3.Size = new System.Drawing.Size(104, 25);
            this.TxtCal3.TabIndex = 9;
            this.TxtCal3.TextChanged += new System.EventHandler(this.TxtCal3_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Calificacion 3:";
            // 
            // TxtCal4
            // 
            this.TxtCal4.Location = new System.Drawing.Point(103, 187);
            this.TxtCal4.Name = "TxtCal4";
            this.TxtCal4.Size = new System.Drawing.Size(104, 25);
            this.TxtCal4.TabIndex = 11;
            this.TxtCal4.TextChanged += new System.EventHandler(this.TxtCal4_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Calificacion 4:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(338, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 35);
            this.button1.TabIndex = 12;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(436, 152);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 35);
            this.button2.TabIndex = 13;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(534, 152);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 35);
            this.button3.TabIndex = 14;
            this.button3.Text = "Salir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // DtvDatos
            // 
            this.DtvDatos.AllowUserToAddRows = false;
            this.DtvDatos.AllowUserToDeleteRows = false;
            this.DtvDatos.AllowUserToResizeColumns = false;
            this.DtvDatos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtvDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DtvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DcNombre,
            this.DcCalificacion1,
            this.DcCalificacion2,
            this.DcCalificacion3,
            this.DcCalificacion4,
            this.DcPromedio});
            this.DtvDatos.Location = new System.Drawing.Point(12, 218);
            this.DtvDatos.Name = "DtvDatos";
            this.DtvDatos.Size = new System.Drawing.Size(747, 199);
            this.DtvDatos.TabIndex = 15;
            // 
            // TxtPromGen
            // 
            this.TxtPromGen.BackColor = System.Drawing.Color.White;
            this.TxtPromGen.Location = new System.Drawing.Point(129, 441);
            this.TxtPromGen.Name = "TxtPromGen";
            this.TxtPromGen.ReadOnly = true;
            this.TxtPromGen.Size = new System.Drawing.Size(104, 25);
            this.TxtPromGen.TabIndex = 17;
            this.TxtPromGen.Text = "0.0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 444);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Promedio General:";
            // 
            // TxtAprobado
            // 
            this.TxtAprobado.BackColor = System.Drawing.Color.White;
            this.TxtAprobado.Location = new System.Drawing.Point(326, 441);
            this.TxtAprobado.Name = "TxtAprobado";
            this.TxtAprobado.ReadOnly = true;
            this.TxtAprobado.Size = new System.Drawing.Size(104, 25);
            this.TxtAprobado.TabIndex = 19;
            this.TxtAprobado.Text = "0.0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(249, 442);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "Aprobados:";
            // 
            // TxtReprobado
            // 
            this.TxtReprobado.BackColor = System.Drawing.Color.White;
            this.TxtReprobado.Location = new System.Drawing.Point(524, 439);
            this.TxtReprobado.Name = "TxtReprobado";
            this.TxtReprobado.ReadOnly = true;
            this.TxtReprobado.Size = new System.Drawing.Size(104, 25);
            this.TxtReprobado.TabIndex = 21;
            this.TxtReprobado.Text = "0.0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(438, 440);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 20);
            this.label10.TabIndex = 20;
            this.label10.Text = "Reprobados:";
            // 
            // DcNombre
            // 
            this.DcNombre.HeaderText = "NOMBRE";
            this.DcNombre.Name = "DcNombre";
            this.DcNombre.Width = 200;
            // 
            // DcCalificacion1
            // 
            this.DcCalificacion1.HeaderText = "CALIFICACION NO.1";
            this.DcCalificacion1.Name = "DcCalificacion1";
            // 
            // DcCalificacion2
            // 
            this.DcCalificacion2.HeaderText = "CALIFICACION NO.2";
            this.DcCalificacion2.Name = "DcCalificacion2";
            // 
            // DcCalificacion3
            // 
            this.DcCalificacion3.HeaderText = "CALIFICACION NO.3";
            this.DcCalificacion3.Name = "DcCalificacion3";
            // 
            // DcCalificacion4
            // 
            this.DcCalificacion4.HeaderText = "CALIFICACION NO.4";
            this.DcCalificacion4.Name = "DcCalificacion4";
            // 
            // DcPromedio
            // 
            this.DcPromedio.HeaderText = "PROMEDIO";
            this.DcPromedio.Name = "DcPromedio";
            // 
            // FrmNotaAlumno
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(780, 517);
            this.ControlBox = false;
            this.Controls.Add(this.TxtReprobado);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TxtAprobado);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TxtPromGen);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DtvDatos);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtCal4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtCal3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtCal2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtCal1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmNotaAlumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nota de Alumno";
            this.Load += new System.EventHandler(this.FrmNotaAlumno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtCal1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtCal2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtCal3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtCal4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView DtvDatos;
        private System.Windows.Forms.TextBox TxtPromGen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtAprobado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtReprobado;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcCalificacion1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcCalificacion2;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcCalificacion3;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcCalificacion4;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcPromedio;
    }
}