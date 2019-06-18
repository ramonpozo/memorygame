using MySql.Data.MySqlClient;
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
    public partial class Ranking : Form
    {
        string name;
        static MySqlConnection con = new MySqlConnection(@"Server=localhost;Database=memory;UID=root;");
        public Ranking(String nombre, int tiempo, int numPistas, int dificultad)
        {
            InitializeComponent();

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            this.name = nombre;
            pictureBoxIzq.ImageLocation = @"../../decoracionInicio.png";
            labelFelicitacion.Text = "¡Muy bien " + nombre + "!";
            labelInfo.Text = "Has tardado " + parseTime(tiempo) + " en resolver el juego de los " + parseDificultad(dificultad) + " y has usado " + (3 - numPistas) + " pistas. Tienes:";
            labelPuntos.Text = calcularPuntos(tiempo, numPistas, dificultad) + " puntos";

            try
            {
                con.Open();
                Console.WriteLine("Conexion bien");
            }
            catch (MySqlException e)
            {
                Console.WriteLine("Conexion mal");
            }

            nuevaPuntuacion(nombre, calcularPuntos(tiempo, numPistas, dificultad));
            CargarDataGridView();
        }

        private void CargarDataGridView()
        {
            DataTable dt = new DataTable();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM jugadores ORDER BY puntuacion DESC";
            MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
            adap.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void nuevaPuntuacion(String nombre, int puntuacion)
        {
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "INSERT INTO `jugadores`(`nombre`, `puntuacion`) VALUES ('" + nombre + "'," + puntuacion + ")";
            cmd.ExecuteNonQuery();
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

        public string parseDificultad (int dificultad)
        {
            string difString = "";

            if (dificultad == 1)
            {
                difString = "colores";
            }
            else if (dificultad == 2)
            {
                difString = "animales";
            }
            else if (dificultad == 3)
            {
                difString = "numeros";
            }

            return difString;
        }

        public int calcularPuntos (int tiempo, int pistas, int dificultad)
        {
            int puntos = 10000 / ((((3 - pistas) * (dificultad + 1)) + tiempo) / dificultad);

            return puntos;
        }

        private void buttonJugar_Click(object sender, EventArgs e)
        {
            this.Hide();

            con.Close();
            Dificultad juego = new Dificultad(name);
            juego.ShowDialog();

            this.Close();
        }

        private void buttonTerminar_Click(object sender, EventArgs e)
        {
            this.Hide();

            con.Close();
            Diploma juego = new Diploma(name);
            juego.ShowDialog();

            this.Close();
        }
    }
}
