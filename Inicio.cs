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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            pictureBoxIzq.ImageLocation = @"../../decoracionInicio.png";
            //            pictureBoxDer.ImageLocation = @"../../decoracionInicioReves.png";
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        private void buttonJugar_Click_1(object sender, EventArgs e)
        {
            string name = "Invitado";

            this.Hide();

            if (textBoxNombre.Text != "")
            {
                name = textBoxNombre.Text;
            }

            Dificultad juego = new Dificultad(name);
            juego.ShowDialog();

            this.Close();
        }
    }
}
