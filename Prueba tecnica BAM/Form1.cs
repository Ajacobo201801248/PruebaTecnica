using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using Prueba_tecnica_BAM.Estructuras;

namespace Prueba_tecnica_BAM
{
    public partial class Form1 : Form // se hereda de la case FOrm del lenguaje. 
    {
        // declaracion de varialbes globales. se crea 2 hilos nuevos agregados al hilo principañ
        private Thread thread2 = null;
        private Thread thread3 = null;
        // se instancia la case Manejo de matrices
        Manejo_de_Matrices Matriz = new Manejo_de_Matrices();
        //se crea un delegado para manejar el formulario desde diferentes hilos asociados. 
        private delegate void SafeCallDelegate(string text);

        //constructor de la clase form1 
        public Form1()
        {
            // se hace la inisializacion de componentes pertenecientes al formulario. 
            InitializeComponent();
            Traslado_controles.Visible = false;

        }
        // Boton encargado de crear la matriz mxn 

        private void btn_crear_matriz_Click(object sender, EventArgs e)
        {
            // se crea un nuevo Hilo encargado de pintar crear y ejecutar los calculos de la creacion de la matriz determinada por el usuario
            thread2 = new Thread(new ThreadStart(PintaMatriz));
            //se da inicio a la ejecucion del hilo 2.
            thread2.Start();
        }

        // Funcion encargada encargado de invocar el metodo de la clase Manejo de martizes tambien se encarga de hacer el set a las baribles de filas y columnas. Imprime el total de la columna 3. 
        private void PintaMatriz()
        {
            // manejo de errores por medio de un try catch. 
            try
            {
                // se le asigna valor al atribito filas del objeto matriz
                Matriz.setFilas(int.Parse(txt_filas.Text));
                // se le asigna valor al atributo columnas de objeto matriz.
                Matriz.setColumnas(int.Parse(txt_columnas.Text));
                // se ejecuta el metodo Crearmatrix encargado de modificar la interface grafica y llenar la matriz de elementos Texbox
                Matriz.Creamatrix(this);
                // obitene el valor del atributo Total el cual contiene la suma de la columna 3 inicial y lo asigna a la caja de texto correspondiente.
                imprimetotal(Matriz.getTotal().ToString());
            }
            catch (Exception)
            {
                // muestra el error 
                MessageBox.Show("Ingrese Un valor mayor a 0 en las filas y columnas");
            }
        }
        //  metodo encargado de validar la invocacion del elemento y ejecutarlo desde el hilo correcto por medio del delegado asignado. 
        private void imprimetotal(string text)
        {
            // verifica si la caja de texto requiere una invocacion. 
            if (txt_total_c3.InvokeRequired)
            { // realiza la invoacion desde el delegado correcto
                var d = new SafeCallDelegate(imprimetotal);
                txt_total_c3.Invoke(d, new object[] { text });
            }
            else
            {
                //modifica el control de forma normal. 
                txt_total_c3.Text = text;
            }
        }
        // Boton encargado de limpiar las barialbes utilizadas y de ejecutar el metodo destructor del objeto matriz. 
        private void btn_limpiarmatriz_Click(object sender, EventArgs e)
        {
            // crea un nuevo hilo para poder realizar limpiar la interface de usuario por medio del metodo limpiarmatriz
            thread3 = new Thread(new ThreadStart(limpiarmatriz));
            // se inicia la ejecucion del hilo 3
            thread3.Start();
        }
        private void limpiarmatriz()
        {
            // ejecuta el metodo destructor del objeto Matriz pasando como parametro el contexto actual.
            Matriz.desctrutor(this);
            // ejecuta la limpieza de los campos de texto que no fueron creados en el hilo 1 pero son modificados desde el hilo 3.  
            Limpiatotales("0");

        }
        // limpia todos los campos de texto utilizados
        void Limpiatotales(string text)
        {
            if (txt_total_c3.InvokeRequired)
            {
                var d = new SafeCallDelegate(Limpiatotales);
                txt_total_c3.Invoke(d, new object[] { text });
                txt_columnas.Invoke(d, new object[] { text });
                txt_filas.Invoke(d, new object[] { text });
                TOTAL_CALCULO2.Invoke(d, new object[] { text });
                coordenada_f_x.Invoke(d, new object[] { text });
                coordenada_f_y.Invoke(d, new object[] { text });
                coordenada_i_y.Invoke(d, new object[] { text });
                Coordenada_i_x.Invoke(d, new object[] { text });
            }
            else
            {
                txt_total_c3.Text = text;

                txt_columnas.Text = text;
                txt_filas.Text = text;
                TOTAL_CALCULO2.Text = text;
                coordenada_f_x.Text = text;
                coordenada_f_y.Text = text;
                coordenada_i_y.Text = text;
                Coordenada_i_x.Text = text;
            }
        }
        // boton que activa y redimencina las filas de la matriz creada
        private void button2_Click(object sender, EventArgs e)
        {
            Matriz.redimenciona_matriz(this, "fila");

        }
        // boton que activa y redimencina las columnas de la matriz creada
        private void button1_Click(object sender, EventArgs e)
        {
            Matriz.redimenciona_matriz(this, "columna");
        }

        //   muestra los controlles que se utilizan para el traslado. 
        private void Calculo1_Click(object sender, EventArgs e)
        {
            Traslado_controles.Visible = true;
        }

        // realiza el traslado y cambio de los valores de cada control dependiendo las coordenadas ingresadas
        private void Realizar_traslado_Click(object sender, EventArgs e)
        {
            Matriz.traslada_valores_de_las_celdas(this, int.Parse(Coordenada_i_x.Text), int.Parse(coordenada_i_y.Text), int.Parse(coordenada_f_x.Text), int.Parse(coordenada_f_y.Text));

        }
        // reliza la eliminacion de las celdas espesificas
        private void Calculo_3_Click(object sender, EventArgs e)
        {
            Matriz.Elimina_valores_de_las_celdas(this);
        }

        // realiza la suma de las celdas espesificas
        private void calculo2_Click(object sender, EventArgs e)
        {
            TOTAL_CALCULO2.Text = Matriz.calcula_suma(this).ToString();
            TOTAL_CALCULO2.BackColor = Color.Green;

        }
        // boton que realiza el calculo de la divicion del resultado anterior y lo coloca donde corresponde
        private void CALCULO_4_Click(object sender, EventArgs e)
        {
            Matriz.Calculo_de_la_divicion(this, int.Parse(TOTAL_CALCULO2.Text));

        }
        // actualiza con las sumas correspondientes la columna 3 y muestra el nuevo resultado 
        private void button5_Click(object sender, EventArgs e)
        {
            Matriz.actualiza_fila3(this);
            imprimetotal(Matriz.getTotal().ToString());
        }
    }
}