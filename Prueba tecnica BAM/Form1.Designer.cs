namespace Prueba_tecnica_BAM
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_filas = new System.Windows.Forms.TextBox();
            this.txt_columnas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_crear_matriz = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Traslado_controles = new System.Windows.Forms.GroupBox();
            this.Realizar_traslado = new System.Windows.Forms.Button();
            this.Coordenada_i_x = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.coordenada_i_y = new System.Windows.Forms.TextBox();
            this.coordenada_f_y = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.coordenada_f_x = new System.Windows.Forms.TextBox();
            this.CALCULO_4 = new System.Windows.Forms.Button();
            this.Calculo_3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.calculo2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TOTAL_CALCULO2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_total_c3 = new System.Windows.Forms.TextBox();
            this.Calculo1 = new System.Windows.Forms.Button();
            this.btn_limpiarmatriz = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.Traslado_controles.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_filas
            // 
            this.txt_filas.Location = new System.Drawing.Point(4, 50);
            this.txt_filas.Name = "txt_filas";
            this.txt_filas.Size = new System.Drawing.Size(100, 23);
            this.txt_filas.TabIndex = 0;
            // 
            // txt_columnas
            // 
            this.txt_columnas.Location = new System.Drawing.Point(133, 50);
            this.txt_columnas.Name = "txt_columnas";
            this.txt_columnas.Size = new System.Drawing.Size(100, 23);
            this.txt_columnas.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Columnas";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(133, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Crear columna";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(4, 89);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Crear Fila";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_crear_matriz
            // 
            this.btn_crear_matriz.Location = new System.Drawing.Point(246, 24);
            this.btn_crear_matriz.Name = "btn_crear_matriz";
            this.btn_crear_matriz.Size = new System.Drawing.Size(94, 71);
            this.btn_crear_matriz.TabIndex = 6;
            this.btn_crear_matriz.Text = "Crear Matriz";
            this.btn_crear_matriz.UseVisualStyleBackColor = true;
            this.btn_crear_matriz.Click += new System.EventHandler(this.btn_crear_matriz_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Traslado_controles);
            this.groupBox1.Controls.Add(this.CALCULO_4);
            this.groupBox1.Controls.Add(this.Calculo_3);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.calculo2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TOTAL_CALCULO2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_total_c3);
            this.groupBox1.Controls.Add(this.Calculo1);
            this.groupBox1.Controls.Add(this.btn_limpiarmatriz);
            this.groupBox1.Controls.Add(this.txt_columnas);
            this.groupBox1.Controls.Add(this.btn_crear_matriz);
            this.groupBox1.Controls.Add(this.txt_filas);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1760, 231);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controles";
            // 
            // Traslado_controles
            // 
            this.Traslado_controles.Controls.Add(this.Realizar_traslado);
            this.Traslado_controles.Controls.Add(this.Coordenada_i_x);
            this.Traslado_controles.Controls.Add(this.label6);
            this.Traslado_controles.Controls.Add(this.coordenada_i_y);
            this.Traslado_controles.Controls.Add(this.coordenada_f_y);
            this.Traslado_controles.Controls.Add(this.label5);
            this.Traslado_controles.Controls.Add(this.coordenada_f_x);
            this.Traslado_controles.Location = new System.Drawing.Point(428, 97);
            this.Traslado_controles.Name = "Traslado_controles";
            this.Traslado_controles.Size = new System.Drawing.Size(281, 121);
            this.Traslado_controles.TabIndex = 25;
            this.Traslado_controles.TabStop = false;
            // 
            // Realizar_traslado
            // 
            this.Realizar_traslado.Location = new System.Drawing.Point(209, 30);
            this.Realizar_traslado.Name = "Realizar_traslado";
            this.Realizar_traslado.Size = new System.Drawing.Size(68, 76);
            this.Realizar_traslado.TabIndex = 24;
            this.Realizar_traslado.Text = "trasladar";
            this.Realizar_traslado.UseVisualStyleBackColor = true;
            this.Realizar_traslado.Click += new System.EventHandler(this.Realizar_traslado_Click);
            // 
            // Coordenada_i_x
            // 
            this.Coordenada_i_x.Location = new System.Drawing.Point(2, 30);
            this.Coordenada_i_x.Name = "Coordenada_i_x";
            this.Coordenada_i_x.Size = new System.Drawing.Size(100, 23);
            this.Coordenada_i_x.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 15);
            this.label6.TabIndex = 23;
            this.label6.Text = "coordenada destino (x,y)";
            // 
            // coordenada_i_y
            // 
            this.coordenada_i_y.Location = new System.Drawing.Point(108, 30);
            this.coordenada_i_y.Name = "coordenada_i_y";
            this.coordenada_i_y.Size = new System.Drawing.Size(100, 23);
            this.coordenada_i_y.TabIndex = 19;
            // 
            // coordenada_f_y
            // 
            this.coordenada_f_y.Location = new System.Drawing.Point(108, 80);
            this.coordenada_f_y.Name = "coordenada_f_y";
            this.coordenada_f_y.Size = new System.Drawing.Size(100, 23);
            this.coordenada_f_y.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 15);
            this.label5.TabIndex = 20;
            this.label5.Text = "coordenada origen (x,y)";
            // 
            // coordenada_f_x
            // 
            this.coordenada_f_x.Location = new System.Drawing.Point(2, 80);
            this.coordenada_f_x.Name = "coordenada_f_x";
            this.coordenada_f_x.Size = new System.Drawing.Size(100, 23);
            this.coordenada_f_x.TabIndex = 21;
            // 
            // CALCULO_4
            // 
            this.CALCULO_4.Location = new System.Drawing.Point(965, 24);
            this.CALCULO_4.Name = "CALCULO_4";
            this.CALCULO_4.Size = new System.Drawing.Size(175, 71);
            this.CALCULO_4.TabIndex = 16;
            this.CALCULO_4.Text = "Dividir el total del inciso anterior y colocar en partes iguales en las [filas 3 " +
    "a 7][columna 4]";
            this.CALCULO_4.UseVisualStyleBackColor = true;
            this.CALCULO_4.Click += new System.EventHandler(this.CALCULO_4_Click);
            // 
            // Calculo_3
            // 
            this.Calculo_3.Location = new System.Drawing.Point(837, 24);
            this.Calculo_3.Name = "Calculo_3";
            this.Calculo_3.Size = new System.Drawing.Size(123, 71);
            this.Calculo_3.TabIndex = 15;
            this.Calculo_3.Text = "Eliminar los valores de las [filas 1 y 2] [columna 2] ";
            this.Calculo_3.UseVisualStyleBackColor = true;
            this.Calculo_3.Click += new System.EventHandler(this.Calculo_3_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1144, 24);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(139, 71);
            this.button5.TabIndex = 14;
            this.button5.Text = "Llenar la columna 3 con la suma de las columnas 1, 2 y 4 ";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // calculo2
            // 
            this.calculo2.Location = new System.Drawing.Point(710, 24);
            this.calculo2.Name = "calculo2";
            this.calculo2.Size = new System.Drawing.Size(121, 71);
            this.calculo2.TabIndex = 13;
            this.calculo2.Text = "Calcular el total de las [filas 1 y 2] [columna 2] ";
            this.calculo2.UseVisualStyleBackColor = true;
            this.calculo2.Click += new System.EventHandler(this.calculo2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1462, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "total de las [filas 1 y 2] [columna 2] ";
            // 
            // TOTAL_CALCULO2
            // 
            this.TOTAL_CALCULO2.Location = new System.Drawing.Point(1462, 49);
            this.TOTAL_CALCULO2.Name = "TOTAL_CALCULO2";
            this.TOTAL_CALCULO2.Size = new System.Drawing.Size(193, 23);
            this.TOTAL_CALCULO2.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1333, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "total columna 3";
            // 
            // txt_total_c3
            // 
            this.txt_total_c3.Location = new System.Drawing.Point(1318, 49);
            this.txt_total_c3.Name = "txt_total_c3";
            this.txt_total_c3.Size = new System.Drawing.Size(139, 23);
            this.txt_total_c3.TabIndex = 9;
            // 
            // Calculo1
            // 
            this.Calculo1.Location = new System.Drawing.Point(430, 24);
            this.Calculo1.Name = "Calculo1";
            this.Calculo1.Size = new System.Drawing.Size(274, 71);
            this.Calculo1.TabIndex = 8;
            this.Calculo1.Text = "Trasladar los valores de las [filas 1 y 2] [columna 1] hacia las filas nuevas";
            this.Calculo1.UseVisualStyleBackColor = true;
            this.Calculo1.Click += new System.EventHandler(this.Calculo1_Click);
            // 
            // btn_limpiarmatriz
            // 
            this.btn_limpiarmatriz.Location = new System.Drawing.Point(342, 24);
            this.btn_limpiarmatriz.Name = "btn_limpiarmatriz";
            this.btn_limpiarmatriz.Size = new System.Drawing.Size(86, 71);
            this.btn_limpiarmatriz.TabIndex = 7;
            this.btn_limpiarmatriz.Text = "Borrar matriz";
            this.btn_limpiarmatriz.UseVisualStyleBackColor = true;
            this.btn_limpiarmatriz.Click += new System.EventHandler(this.btn_limpiarmatriz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1784, 681);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Traslado_controles.ResumeLayout(false);
            this.Traslado_controles.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox txt_filas;
        private TextBox txt_columnas;
        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button btn_crear_matriz;
        private GroupBox groupBox1;
        private Button btn_limpiarmatriz;
        private Button Calculo1;
        private Label label3;
        private TextBox txt_total_c3;
        private TextBox textBox1;
        private Button CALCULO_4;
        private Button Calculo_3;
        private Button button5;
        private Button calculo2;
        private Label label4;
        private Label label6;
        private TextBox coordenada_f_y;
        private TextBox coordenada_f_x;
        private Label label5;
        private TextBox coordenada_i_y;
        private TextBox Coordenada_i_x;
        private Button Realizar_traslado;
        private GroupBox Traslado_controles;
        private TextBox TOTAL_CALCULO2;
    }
}