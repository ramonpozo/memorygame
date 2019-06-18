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
    public partial class Dificultad : Form
    {
        string name;

        public Dificultad(String name)
        {
            InitializeComponent();
            pictureBoxIzq.ImageLocation = @"../../decoracionInicio.png";
            //            pictureBoxDer.ImageLocation = @"../../decoracionInicioReves.png";

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            this.name = name;

            label1.Text = "Bienvenido " + name;
        }

        private void buttonJugar_Click(object sender, EventArgs e)
        {

            this.Hide();
            
            if (radioButtonColores.Checked)
            {
                JuegoFacil juego = new JuegoFacil(name);
                juego.ShowDialog();
            } 
            else if (radioButtonAnimales.Checked)
            {
                JuegoNormal juego = new JuegoNormal(name);
                juego.ShowDialog();
            }
            else if (radioButtonNumeros.Checked)
            {
                JuegoDificil juego = new JuegoDificil(name);
                juego.ShowDialog();
            }

            this.Close();
        }
    }
}
