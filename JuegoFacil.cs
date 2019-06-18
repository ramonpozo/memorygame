using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory
{
    public partial class JuegoFacil : Form
    {
        int[] posiciones; // Almacena las posiciones aleatorias del 1 al 16
        PictureBox[] casillas;
        System.Collections.ArrayList aciertos;

        int numCartas = 3 * 4;

        bool primerClick;
        int pos1, pos2;

        string name;
        int tiempo;
        int parejas;

        int pistas = 3;

        string[] palabras = { "Red", "Purple", "Blue", "Green", "Yellow", "Brown"};

        public JuegoFacil(string name)
        {
            InitializeComponent();

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            posiciones = new int[numCartas];
            casillas = new PictureBox[numCartas];
            aciertos = new System.Collections.ArrayList();
            randomImages();

            this.name = name;
            labelNombre.Text = name;

            tiempo = 0;
            parejas = 0;
            primerClick = true;

            casillas[0] = pictureBox1;
            casillas[1] = pictureBox2;
            casillas[2] = pictureBox3;
            casillas[3] = pictureBox4;
            casillas[4] = pictureBox5;
            casillas[5] = pictureBox6;
            casillas[6] = pictureBox7;
            casillas[7] = pictureBox8;
            casillas[8] = pictureBox9;
            casillas[9] = pictureBox10;
            casillas[10] = pictureBox11;
            casillas[11] = pictureBox12;

            for (int i = 0; i < casillas.Length; i++)
            {
                casillas[i].ImageLocation = @"../../Cartas/PD.png";
            }

            timerCronometro.Start();

            labelPistas.Text = "Tienes " + pistas + " pistas";
            pictureBoxPista.ImageLocation = @"../../lupa.png";
        }

        public void emparejar (int pos)
        {
            if (!aciertos.Contains(pos))
            {
                if (casillas[pos].ImageLocation != @"../../Cartas/PD.png")
                {
                    if (primerClick)
                    {
                        Console.WriteLine("primer click");
                        pos1 = pos;
                        primerClick = false;
                    }
                    else if (pos != pos1)
                    {
                        Console.WriteLine("segundo click");
                        pos2 = pos;
                        primerClick = true;

                        int pareja1, pareja2;

                        if (posiciones[pos1] > numCartas / 2)
                        {
                            pareja1 = posiciones[pos1] - numCartas / 2;
                        }
                        else
                        {
                            pareja1 = posiciones[pos1];
                        }

                        if (posiciones[pos2] > numCartas / 2)
                        {
                            pareja2 = posiciones[pos2] - numCartas / 2;
                        }
                        else
                        {
                            pareja2 = posiciones[pos2];
                        }

                        if (pareja1 == pareja2)
                        {
                            Console.WriteLine("Pareja");

                            aciertos.Add(pos1);
                            aciertos.Add(pos2);

                            parejas++;

                            if (parejas >= numCartas / 2)
                            {
                                timerCronometro.Stop();
                                ganar();
                                labelCronometro.Text = "GANASTE";
                            }
                        }
                        else
                        {
                            timerCartas.Interval = 1000;
                            timerCartas.Enabled = true;

                            tableLayoutPanelJuegoNormal.Enabled = false;
                        }
                    }
                }
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            casillas[pos1].ImageLocation = @"../../Cartas/PD.png";
            casillas[pos2].ImageLocation = @"../../Cartas/PD.png";

            timerCartas.Enabled = false;

            tableLayoutPanelJuegoNormal.Enabled = true;
        }

        private void timerCronometro_Tick(object sender, EventArgs e)
        {
            tiempo++;
            int tEnSeg = tiempo;
            labelCronometro.Text = parseTime(tEnSeg);
        }

        public string parseTime(int tiempo)
        {
            string tiempoString;

            if (tiempo < 60)
            {
                if (tiempo < 10)
                {
                    tiempoString = "00:0" + tiempo;
                }
                else
                {
                    tiempoString = "00:" + tiempo;
                }
            }
            else
            {
                int minutos = tiempo / 60;
                int segundos = tiempo % 60;

                if (minutos < 10)
                {
                    if (segundos < 10)
                    {
                        tiempoString = "0" + minutos + ":0" + segundos;
                    }
                    else
                    {
                        tiempoString = "0" + minutos + ":" + segundos;
                    }
                }
                else
                {
                    if (segundos < 10)
                    {
                        tiempoString = minutos + ":0" + segundos;
                    }
                    else
                    {
                        tiempoString = minutos + ":" + segundos;
                    }
                }
            }

            return tiempoString;
        }

        public void randomImages ()
        {
            Random random = new Random();

            int numero;

            for (int i = 0; i < posiciones.Length; i++)
            {
                do
                {
                    numero = random.Next(1, numCartas + 1);
                } while (posiciones.Contains(numero));

                posiciones[i] = numero;
                Console.WriteLine(numero);
            }
        }

        public void writeOnImage (PictureBox pb, string text)
        {
            pb.ImageLocation = null;

            int ajusteHorizontal = (text.Length * 36) / 2;
            int ajusteVertical = 60 / 2;

            Bitmap image = new Bitmap(pb.Width, pb.Height);
            Font font = new Font("Segoe Print", 60, FontStyle.Bold, GraphicsUnit.Pixel);
            Graphics graphics = Graphics.FromImage(image);
            graphics.DrawString(text, font, Brushes.Purple, new Point (pb.Width / 2 - ajusteHorizontal, pb.Height / 2 - ajusteVertical));

            pb.Image = image;
        }

        public void ganar()
        {
            int puntuacion = tiempo + pistas * 100;

            this.Hide();

            Ranking juego = new Ranking(name, tiempo, pistas, 1);
            juego.ShowDialog();

            this.Close();
        }

        //private void buttonStartStop_Click(object sender, EventArgs e)
        //{
        //    if (estadoCrono)
        //    {
        //        timer.Stop();
        //        tiempo = 0;
        //        estadoCrono = false;
        //        buttonStartStop.Text = "Iniciar";
        //    }
        //    else
        //    {
        //        timer.Start();
        //        buttonStartStop.Text = "Parar";
        //        estadoCrono = true;
        //    }

        //}

        //private void timer_Tick(object sender, EventArgs e)
        //{
        //    tiempo++;
        //    int tEnSeg = tiempo;
        //    labelTime.Text = tEnSeg.ToString();
        //}

        // Botones para el nivel Normal

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            int casilla = 0;

            if (posiciones[casilla] <= numCartas / 2)
            {
                casillas[casilla].ImageLocation = @"../../Cartas/Colores/" + posiciones[casilla] + ".png";
            }
            else
            {
                System.Console.WriteLine("Posiciones en la casilla " + casilla + " = " + posiciones[casilla]);
                writeOnImage(casillas[casilla], palabras[posiciones[casilla] - (numCartas / 2 + 1)]);
            }
        	
        	emparejar(casilla);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            int casilla = 1;

            if (posiciones[casilla] <= numCartas / 2)
            {
                casillas[casilla].ImageLocation = @"../../Cartas/Colores/" + posiciones[casilla] + ".png";
            }
            else
            {
                System.Console.WriteLine("Posiciones en la casilla " + casilla + " = " + posiciones[casilla]);
                writeOnImage(casillas[casilla], palabras[posiciones[casilla] - (numCartas / 2 + 1)]);
            }

            emparejar(casilla);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            int casilla = 2;

            if (posiciones[casilla] <= numCartas / 2)
            {
                casillas[casilla].ImageLocation = @"../../Cartas/Colores/" + posiciones[casilla] + ".png";
            }
            else
            {
                System.Console.WriteLine("Posiciones en la casilla " + casilla + " = " + posiciones[casilla]);
                writeOnImage(casillas[casilla], palabras[posiciones[casilla] - (numCartas / 2 + 1)]);
            }

            emparejar(casilla);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            int casilla = 3;

            if (posiciones[casilla] <= numCartas / 2)
            {
                casillas[casilla].ImageLocation = @"../../Cartas/Colores/" + posiciones[casilla] + ".png";
            }
            else
            {
                System.Console.WriteLine("Posiciones en la casilla " + casilla + " = " + posiciones[casilla]);
                writeOnImage(casillas[casilla], palabras[posiciones[casilla] - (numCartas / 2 + 1)]);
            }

            emparejar(casilla);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            int casilla = 4;

            if (posiciones[casilla] <= numCartas / 2)
            {
                casillas[casilla].ImageLocation = @"../../Cartas/Colores/" + posiciones[casilla] + ".png";
            }
            else
            {
                System.Console.WriteLine("Posiciones en la casilla " + casilla + " = " + posiciones[casilla]);
                writeOnImage(casillas[casilla], palabras[posiciones[casilla] - (numCartas / 2 + 1)]);
            }

            emparejar(casilla);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            int casilla = 5;

            if (posiciones[casilla] <= numCartas / 2)
            {
                casillas[casilla].ImageLocation = @"../../Cartas/Colores/" + posiciones[casilla] + ".png";
            }
            else
            {
                System.Console.WriteLine("Posiciones en la casilla " + casilla + " = " + posiciones[casilla]);
                writeOnImage(casillas[casilla], palabras[posiciones[casilla] - (numCartas / 2 + 1)]);
            }

            emparejar(casilla);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            int casilla = 6;

            if (posiciones[casilla] <= numCartas / 2)
            {
                casillas[casilla].ImageLocation = @"../../Cartas/Colores/" + posiciones[casilla] + ".png";
            }
            else
            {
                System.Console.WriteLine("Posiciones en la casilla " + casilla + " = " + posiciones[casilla]);
                writeOnImage(casillas[casilla], palabras[posiciones[casilla] - (numCartas / 2 + 1)]);
            }

            emparejar(casilla);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            int casilla = 7;

            if (posiciones[casilla] <= numCartas / 2)
            {
                casillas[casilla].ImageLocation = @"../../Cartas/Colores/" + posiciones[casilla] + ".png";
            }
            else
            {
                System.Console.WriteLine("Posiciones en la casilla " + casilla + " = " + posiciones[casilla]);
                writeOnImage(casillas[casilla], palabras[posiciones[casilla] - (numCartas / 2 + 1)]);
            }

            emparejar(casilla);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            int casilla = 8;

            if (posiciones[casilla] <= numCartas / 2)
            {
                casillas[casilla].ImageLocation = @"../../Cartas/Colores/" + posiciones[casilla] + ".png";
            }
            else
            {
                System.Console.WriteLine("Posiciones en la casilla " + casilla + " = " + posiciones[casilla]);
                writeOnImage(casillas[casilla], palabras[posiciones[casilla] - (numCartas / 2 + 1)]);
            }

            emparejar(casilla);
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            int casilla = 9;

            if (posiciones[casilla] <= numCartas / 2)
            {
                casillas[casilla].ImageLocation = @"../../Cartas/Colores/" + posiciones[casilla] + ".png";
            }
            else
            {
                System.Console.WriteLine("Posiciones en la casilla " + casilla + " = " + posiciones[casilla]);
                writeOnImage(casillas[casilla], palabras[posiciones[casilla] - (numCartas / 2 + 1)]);
            }

            emparejar(casilla);
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            int casilla = 10;

            if (posiciones[casilla] <= numCartas / 2)
            {
                casillas[casilla].ImageLocation = @"../../Cartas/Colores/" + posiciones[casilla] + ".png";
            }
            else
            {
                System.Console.WriteLine("Posiciones en la casilla " + casilla + " = " + posiciones[casilla]);
                writeOnImage(casillas[casilla], palabras[posiciones[casilla] - (numCartas / 2 + 1)]);
            }

            emparejar(casilla);
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            int casilla = 11;

            if (posiciones[casilla] <= numCartas / 2)
            {
                casillas[casilla].ImageLocation = @"../../Cartas/Colores/" + posiciones[casilla] + ".png";
            }
            else
            {
                System.Console.WriteLine("Posiciones en la casilla " + casilla + " = " + posiciones[casilla]);
                writeOnImage(casillas[casilla], palabras[posiciones[casilla] - (numCartas / 2 + 1)]);
            }

            emparejar(casilla);
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            int casilla = 12;

            if (posiciones[casilla] <= numCartas / 2)
            {
                casillas[casilla].ImageLocation = @"../../Cartas/Colores/" + posiciones[casilla] + ".png";
            }
            else
            {
                System.Console.WriteLine("Posiciones en la casilla " + casilla + " = " + posiciones[casilla]);
                writeOnImage(casillas[casilla], palabras[posiciones[casilla] - (numCartas / 2 + 1)]);
            }

            emparejar(casilla);
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            int casilla = 13;

            if (posiciones[casilla] <= numCartas / 2)
            {
                casillas[casilla].ImageLocation = @"../../Cartas/Colores/" + posiciones[casilla] + ".png";
            }
            else
            {
                System.Console.WriteLine("Posiciones en la casilla " + casilla + " = " + posiciones[casilla]);
                writeOnImage(casillas[casilla], palabras[posiciones[casilla] - (numCartas / 2 + 1)]);
            }

            emparejar(casilla);
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            int casilla = 14;

            if (posiciones[casilla] <= numCartas / 2)
            {
                casillas[casilla].ImageLocation = @"../../Cartas/Colores/" + posiciones[casilla] + ".png";
            }
            else
            {
                System.Console.WriteLine("Posiciones en la casilla " + casilla + " = " + posiciones[casilla]);
                writeOnImage(casillas[casilla], palabras[posiciones[casilla] - (numCartas / 2 + 1)]);
            }

            emparejar(casilla);
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            int casilla = 15;

            if (posiciones[casilla] <= numCartas / 2)
            {
                casillas[casilla].ImageLocation = @"../../Cartas/Colores/" + posiciones[casilla] + ".png";
            }
            else
            {
                System.Console.WriteLine("Posiciones en la casilla " + casilla + " = " + posiciones[casilla]);
                writeOnImage(casillas[casilla], palabras[posiciones[casilla] - (numCartas / 2 + 1)]);
            }

            emparejar(casilla);
        }

        private void pictureBoxPista_Click(object sender, EventArgs e)
        {
            if (!primerClick && pistas > 0)
            {
                int cartaSeleccionada;

                if (posiciones[pos1] > numCartas / 2)
                {
                    cartaSeleccionada = posiciones[pos1] - numCartas / 2;
                }
                else
                {
                    cartaSeleccionada = posiciones[pos1];
                }

                int posSegundaCarta = 0;

                for (int i = 0; i < posiciones.Length; i++)
                {
                    int busqueda;

                    if (posiciones[i] <= numCartas / 2)
                    {
                        busqueda = posiciones[i];
                    }
                    else
                    {
                        busqueda = posiciones[i] - numCartas / 2;
                    }

                    if (busqueda == cartaSeleccionada && i != pos1)
                    {
                        if (posiciones[i] <= numCartas / 2)
                        {
                            casillas[i].ImageLocation = @"../../Cartas/Colores/" + posiciones[i] + ".png";
                        }
                        else
                        {
                            writeOnImage(casillas[i], palabras[busqueda - 1]);
                        }

                        posSegundaCarta = i;
                    }
                }

                aciertos.Add(pos1);
                aciertos.Add(posSegundaCarta);

                pistas--;

                if (pistas > 0)
                {
                    labelPistas.Text = "Tienes " + pistas + " pistas";
                }
                else
                {
                    labelPistas.Text = "No te quedan mas pistas";
                    pictureBoxPista.Enabled = false;
                }

                parejas++;

                if (parejas >= numCartas / 2)
                {
                    timerCronometro.Stop();
                    ganar();
                    labelCronometro.Text = "GANASTE";
                }

                primerClick = true;
            }
        }
    }
}
