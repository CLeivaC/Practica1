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

namespace Practica1
{
    public partial class FormTablaHabilidades : Form
    {
        MySqlConnection connection = new MySqlConnection($"Server={"bf9zwbmdmtlptaymlaot-mysql.services.clever-cloud.com"};Database={"bf9zwbmdmtlptaymlaot"};User Id={"usjhj42ycmnv1wjk"};Password={"6aVyqZUKG2PdZoSfVL4f"}");
        public FormTablaHabilidades()
        {
            InitializeComponent();
        }

        public void mostrarTablaHabilidades()
        {

           string tabla = "Select * from Habilidades";
           connection.Open();

           MySqlCommand cmd = new MySqlCommand(tabla, connection);

           using (MySqlDataReader reader = cmd.ExecuteReader())
           {

               while (reader.Read())
               {

                   string q = reader.GetString(0);
                   string w = reader.GetString(1);
                   string e = reader.GetString(2);
                   string r = reader.GetString(3);
                   string campeon = reader.GetString(4);
                   int n = dataGridView1.Rows.Add();
                   dataGridView1.Rows[n].Cells[0].Value = campeon;
                   dataGridView1.Rows[n].Cells[1].Value = q;
                   dataGridView1.Rows[n].Cells[2].Value = w;
                   dataGridView1.Rows[n].Cells[3].Value = e;
                   dataGridView1.Rows[n].Cells[4].Value = r;



               }
               connection.Close();

           }

        }

        private void btnMostrarTabla_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            mostrarTablaHabilidades();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string texto = textBoxBuscar.Text;
            texto = texto.ToUpper();
            dataGridView1.Rows.Clear();
          
            connection.Open();


            string tabla = "Select * from Habilidades";

            MySqlCommand cmd = new MySqlCommand(tabla, connection);

            using (MySqlDataReader reader = cmd.ExecuteReader())
            {

                while (reader.Read())
                {

                    string q = reader.GetString(0);
                    string w = reader.GetString(1);
                    string habE = reader.GetString(2);
                    string r = reader.GetString(3);
                    string campeon = reader.GetString(4);


                    if (q.Contains(texto) || w.Contains(texto) || habE.Contains(texto) || r.Contains(texto))
                    {
                        int n = dataGridView1.Rows.Add();
                        dataGridView1.Rows[n].Cells[0].Value = campeon;
                        dataGridView1.Rows[n].Cells[1].Value = q;
                        dataGridView1.Rows[n].Cells[2].Value = w;
                        dataGridView1.Rows[n].Cells[3].Value = habE;
                        dataGridView1.Rows[n].Cells[4].Value = r;

                    }



                }
                connection.Close();

            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            textBoxBuscar.ResetText();
        }
    }
}
