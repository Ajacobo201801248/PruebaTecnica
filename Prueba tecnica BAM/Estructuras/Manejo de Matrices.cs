using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_tecnica_BAM.Estructuras
{
    internal class Manejo_de_Matrices
    {
        // se crea un delegado para poder manejar el formulario por medio de Hilos.

        private delegate void SafeCallDelegate(Form form);

        // constructor de la case manejo de matrices
        public Manejo_de_Matrices()
        {

            filas = 0;
            total = 0;
            columnas = 0;
        }

        //destructor de la clase manejo de matrices
        public void desctrutor(Form form)
        {

            EliminarMatriz(form);
            ArrTextbox = Resize2D(ArrTextbox, 0, 0);
            filas = 0;
            columnas = 0;
            total = 0;
        }


        // metodo encargado de crear la matriz con las filas y columnas determinadas por el usuario. tambien calcula el total de la columna 3 y la suma de la fila 1 con la fila 2 y muestra los resultados respectivos en la fila 3¡
        public void Creamatrix(Form form)
        {


            if (ArrTextbox.Length != 0)
            {
                EliminarMatriz(form);

            }
            ArrTextbox = Resize2D(ArrTextbox, filas, columnas);
            Random rnd = new Random();
            total = 0;
            if (form.InvokeRequired)
            {
                var d = new SafeCallDelegate(Creamatrix);
                form.Invoke(d, new object[] { form });
            }
            else
            {
                try
                {
                    int valorinicialX = 15;
                    int valorinicialY = 259;

                    for (int i = 0; i < filas; i++)
                    {
                        for (int j = 0; j < columnas; j++)
                        {
                            TextBox objtextbo = new TextBox();
                            objtextbo.Name = "txt_C_" + j.ToString() + "_F_" + i.ToString();
                            objtextbo.Location = new System.Drawing.Point(valorinicialX, valorinicialY);
                            if (j < 3 && i < 10)
                            {
                                objtextbo.Text = rnd.Next(50).ToString();
                            }
                            else
                            {
                                objtextbo.Text = "0";

                            }


                            ArrTextbox[i, j] = objtextbo;
                            form.Controls.Add(ArrTextbox[i, j]);
                            valorinicialX = valorinicialX + 106;

                            if (j == 2)
                            {
                                if (ArrTextbox[i, j - 2].Text != "" && ArrTextbox[i, j - 1].Text != "")
                                {
                                    total = total + int.Parse(ArrTextbox[i, j - 2].Text) + int.Parse(ArrTextbox[i, j - 1].Text);

                                    objtextbo.Text = (int.Parse(ArrTextbox[i, j - 2].Text) + int.Parse(ArrTextbox[i, j - 1].Text)).ToString();
                                }



                            }
                        }

                        valorinicialX = 15;
                        valorinicialY = valorinicialY + 29;
                    }      // El primer índice recorre las filas.
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        //Metodo encargado de la redimencion de la matriz para agrega n cantidad de columnas o filas. Con cada clic en el boton agregar columna o fila esta agrega una columna o fila
        public void redimenciona_matriz(Form form, string tipo)
        {
            if (tipo == "fila")
            {

                if (ArrTextbox.Length != 0)
                {
                    EliminarMatriz(form);

                }
                int filasiniciales = ArrTextbox.GetLength(0);
                ArrTextbox = Resize2D(ArrTextbox, ArrTextbox.GetLength(0) + 1, ArrTextbox.GetLength(1));
                if (form.InvokeRequired)
                {
                    var d = new SafeCallDelegate(Creamatrix);
                    form.Invoke(d, new object[] { form });
                }
                else
                {
                    try
                    {
                        int valorinicialX = 15;
                        int valorinicialY = 259;


                        for (int i = 0; i < ArrTextbox.GetLength(0); i++)
                        {
                            for (int j = 0; j < ArrTextbox.GetLength(1); j++)
                            {
                                TextBox objtextbo = new TextBox();
                                objtextbo.Name = "txt_C_" + j.ToString() + "_F_" + i.ToString();
                                objtextbo.Location = new System.Drawing.Point(valorinicialX, valorinicialY);

                                if (i > filasiniciales - 1)
                                {
                                    objtextbo.Text = "0";
                                    ArrTextbox[i, j] = objtextbo;


                                }
                                form.Controls.Add(ArrTextbox[i, j]);

                                valorinicialX = valorinicialX + 106;
                            }
                            valorinicialX = 15;
                            valorinicialY = valorinicialY + 29;
                        }      // El primer índice recorre las filas.
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }



                }

            }
            else if (tipo == "columna")
            {

                if (ArrTextbox.Length != 0)
                {
                    EliminarMatriz(form);

                }
                int columnasiniciales = ArrTextbox.GetLength(1);
                ArrTextbox = Resize2D(ArrTextbox, ArrTextbox.GetLength(0), ArrTextbox.GetLength(1) + 1);
                if (form.InvokeRequired)
                {
                    var d = new SafeCallDelegate(Creamatrix);
                    form.Invoke(d, new object[] { form });
                }
                else
                {
                    try
                    {
                        int valorinicialX = 15;
                        int valorinicialY = 259;


                        for (int i = 0; i < ArrTextbox.GetLength(0); i++)
                        {
                            for (int j = 0; j < ArrTextbox.GetLength(1); j++)
                            {
                                TextBox objtextbo = new TextBox();
                                objtextbo.Name = "txt_C_" + j.ToString() + "_F_" + i.ToString();
                                objtextbo.Location = new System.Drawing.Point(valorinicialX, valorinicialY);

                                if (j > columnasiniciales - 1)
                                {
                                    objtextbo.Text = "0";
                                    ArrTextbox[i, j] = objtextbo;


                                }
                                form.Controls.Add(ArrTextbox[i, j]);

                                valorinicialX = valorinicialX + 106;
                            }
                            valorinicialX = 15;
                            valorinicialY = valorinicialY + 29;
                        }      // El primer índice recorre las filas.
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }



                }
            }
        }
        //Metodo que Elimina la matriz creada
        private void EliminarMatriz(Form form)
        {
            if (form.InvokeRequired)
            {
                var d = new SafeCallDelegate(EliminarMatriz);
                form.Invoke(d, new object[] { form });
            }
            else
            {
                try
                {
                    int valorinicialX = 15;
                    int valorinicialY = 259;


                    for (int i = 0; i < ArrTextbox.GetLength(0); i++)
                    {
                        for (int j = 0; j < ArrTextbox.GetLength(1); j++)
                        {
                            form.Controls.Remove(ArrTextbox[i, j]);
                            valorinicialX = valorinicialX + 106;
                        }
                        valorinicialX = 15;
                        valorinicialY = valorinicialY + 29;
                    }      // El primer índice recorre las filas.
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        // metodo que Realiza el traslado de datos desde cualquier posicion dentro de la martiz solo seleccinando las coordenadas iniciales y las coordenadas finales
        public void traslada_valores_de_las_celdas(Form form, int coordenada_i_x, int coordenada_i_y, int coordenada_f_x, int coordenada_f_y)
        {
            try
            {
                // se guarda el valor inicial dependiendo de las coordenadas iniciales ingresadas
                int valorcoordenadainicial = 0;
                // se recorre la matriz
                for (int i = 0; i < ArrTextbox.GetLength(0); i++)
                {
                    for (int j = 0; j < ArrTextbox.GetLength(1); j++)
                    {

                        // buscamos coordenada inicial 

                        if (i == coordenada_i_x)
                        {
                            if (j == coordenada_i_y)
                            {
                                // se asigna el valor de la coordenada inicial a la variable auxiliar
                                valorcoordenadainicial = int.Parse(ArrTextbox[i, j].Text);
                                // se intercambia el valor de la coordenada destino a la coordenada inicial
                                ArrTextbox[i, j].Text = ArrTextbox[coordenada_f_x, coordenada_f_y].Text;
                                // se identifica al cambio por medio de la asignacion de color
                                ArrTextbox[i, j].BackColor = Color.Red;
                            }

                        }
                        // se busca la coordenada destino 
                        if (i == coordenada_f_x)
                        {
                            if (j == coordenada_f_y)
                            {
                                // se asigna el valor a la coordenada destino 
                                ArrTextbox[i, j].Text = valorcoordenadainicial.ToString();
                                // se identifica el cambio por medio de la asignacion de color. 
                                ArrTextbox[i, j].BackColor = Color.Green;
                            }

                        }


                    }
                }
            }
            catch (Exception ex)
            {
                // manejo de errores 
                MessageBox.Show(ex.Message.ToString());
            }
        }


        // Metodo que elimina los valores de las celdas espesificadas en el documento
        public void Elimina_valores_de_las_celdas(Form form)
        {

            for (int i = 0; i < ArrTextbox.GetLength(0); i++)
            {
                for (int j = 0; j < ArrTextbox.GetLength(1); j++)
                {

                    // se busca la coordenada espesifica y se coloca el valor del componente en 0
                    if (i == 0)
                    {
                        if (j == 1)
                        {


                            ArrTextbox[i, j].Text = "0";
                            ArrTextbox[i, j].BackColor = Color.Red;
                        }

                    }
                    // se busca la coordenada espesifica y se coloca el valor del componente en 0
                    if (i == 1)
                    {
                        if (j == 1)
                        {


                            ArrTextbox[i, j].Text = "0";
                            ArrTextbox[i, j].BackColor = Color.Red;
                        }

                    }

                }
            }
        }

        // calcula la suma de las columnas espesificadas
        public int calcula_suma(Form form)
        {
            // se declaran las variables auxiliares a utilizar
            int valortotal = 0;
            int valor1 = 0;
            int valor2 = 0;
            // se recorre la matriz
            for (int i = 0; i < ArrTextbox.GetLength(0); i++)
            {
                for (int j = 0; j < ArrTextbox.GetLength(1); j++)
                {
                    // se busca la coordenada espesifica 1 
                    if (i == 0)
                    {
                        if (j == 1)
                        {
                            valor1 = int.Parse(ArrTextbox[i, j].Text);
                        }

                    }
                    // se buca la coordenada espesifica 2 
                    if (i == 1)
                    {
                        if (j == 1)
                        {
                            valor2 = int.Parse(ArrTextbox[i, j].Text);

                        }

                    }

                }
            }
            // se suman los parciales y se retorna un valor
            valortotal = valor1 + valor2;
            return valortotal;
        }

        // calcula la divicion mencionada en el documento
        public void Calculo_de_la_divicion(Form form, int valor)
        {
            // se generan los valores dividiendo el resultado anterior dentro de 5
            int valoracolocar = valor / 5;



            for (int i = 0; i < ArrTextbox.GetLength(0); i++)
            {
                for (int j = 0; j < ArrTextbox.GetLength(1); j++)
                {

                    // se coloca el mismo valor en el rango de 3 a 7 de la columna 4

                    if (i >= 2 && i <= 6)
                    {
                        if (j == 3)
                        {


                            ArrTextbox[i, j].Text = valoracolocar.ToString();
                            ArrTextbox[i, j].BackColor = Color.Yellow;
                        }

                    }

                }
            }
        }

        // Realiza la suma de la columna 1 2 y 4 dentro de la columna 3
        public void actualiza_fila3(Form form)
        {

            total = 0;
            for (int i = 0; i < ArrTextbox.GetLength(0); i++)
            {
                for (int j = 0; j < ArrTextbox.GetLength(1); j++)
                {

                    if (j == 2)
                    {


                        if (ArrTextbox[i, j - 2].Text != "" && ArrTextbox[i, j - 1].Text != "")
                        {
                            total = total + int.Parse(ArrTextbox[i, j - 2].Text) + int.Parse(ArrTextbox[i, j - 1].Text) + int.Parse(ArrTextbox[i, j + 1].Text);

                            ArrTextbox[i, j].Text = (int.Parse(ArrTextbox[i, j - 2].Text) + int.Parse(ArrTextbox[i, j - 1].Text) + int.Parse(ArrTextbox[i, j + 1].Text)).ToString();


                            ArrTextbox[i, j].BackColor = Color.Orange;
                        }


                    }



                }
            }
        }

        // Funciones Auxiliares
        //funcion encargada de redimencionar la matriz se toma como balse el resize par auna matriz unidimencional ya establecida en el lenguaje pero se modifica para que funcione con matrices bidimencionales
        public TextBox[,] Resize2D(TextBox[,] original, int m, int n)
        {

            TextBox[,] newArray = new TextBox[m, n]; // se crea una matriz auxiliar
            int mMin = Math.Min(original.GetLength(0), newArray.GetLength(0));// se obtienen las dimenciones y se le asigna a la matriz auxiliar
            int nMin = Math.Min(original.GetLength(1), newArray.GetLength(1));

            // se realiza la copia y a expancion de la matriz. 
            for (int i = 0; i < mMin; i++)
                Array.Copy(original, i * original.GetLength(1), newArray, i * newArray.GetLength(1), nMin);

            return newArray;
        }
        // parte de acceso a los datos. 
        // funcion que regresa el valor de la matriz de objetos
        public TextBox[,] getArrTextbox()
        {
            return ArrTextbox;
        }
        // asigna el valor de las filas
        public void setFilas(int fila)
        {
            this.filas = fila;

        }
        // asigna el valor de las columnas
        public void setColumnas(int columna)
        {
            this.columnas = columna;

        }
        // obtiene el total de la columna 3 
        public int getTotal()
        {
            return total;
        }

        // atributos de la case Manejo de matrices. 

        static TextBox[,] ArrTextbox = new TextBox[0, 0];
        int filas { get; set; }
        int columnas { get; set; }

        int total { get; set; }
    }


}
