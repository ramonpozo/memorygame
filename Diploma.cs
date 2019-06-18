using Microsoft.Reporting.WinForms;
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
    public partial class Diploma : Form
    {
        public string name;
        public Diploma(String name)
        {
            InitializeComponent();
            this.Load += Diploma_Load;

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            this.name = name;
        }

        private void Diploma_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();

            CargarReporte();
        }

        private void CargarReporte()
        {
            List<Jugador> Agregar = new List<Jugador>();
            DataTable dt = Datos();
            foreach (DataRow Lista in dt.Rows)
            {
                Agregar.Add(new Jugador
                {
                    Name = Lista[0].ToString(),
                    Puntuacion = System.Convert.ToInt32(Lista[1].ToString()),
                    Nivel = parseNivel(System.Convert.ToInt32(Lista[1].ToString())),
                });
            }

            ///Mostrar datos en el reporte
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Memory.Diploma.rdlc";
            ReportDataSource rds1 = new ReportDataSource("DataSetJugador", Agregar);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds1);
            this.reportViewer1.RefreshReport();
        }

        public DataTable Datos()
        {
            // Fragmento de código para
            //Para conexión al SQLSERVER
            DataTable Retornar = new DataTable();
            MySqlConnection con = new MySqlConnection(@"Server=localhost;Database=memory;UID=root;");
            con.Open();
            //Se ejecuta el procedimiento almacenado
            DataTable dt = new DataTable();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT nombre, SUM(puntuacion) FROM jugadores WHERE nombre='" + name + "'";
            MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
            adap.Fill(dt);

            return dt;
        }

        public string parseNivel (int puntuacion)
        {
            string nivel = "Aprendiz";

            if (puntuacion > 10000)
            {
                nivel = "Profesor";
            }
            else if (puntuacion > 8000)
            {
                nivel = "Empollon";
            }
            else if (puntuacion > 5000)
            {
                nivel = "Listillo";
            }
            else if (puntuacion > 2000)
            {
                nivel = "Novato";
            }

            return nivel;
        }

        private void buttonTerminar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
