using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica1
{
    public partial class FormObtenerEnlace : Form
    {
        MySqlConnection connection = new MySqlConnection($"Server={"bf9zwbmdmtlptaymlaot-mysql.services.clever-cloud.com"};Database={"bf9zwbmdmtlptaymlaot"};User Id={"usjhj42ycmnv1wjk"};Password={"6aVyqZUKG2PdZoSfVL4f"}");
        public FormObtenerEnlace()
        {
            InitializeComponent();
            agregarItems();
        }

        private void agregarItems()
        {
            cbHabilidad.Items.Add("Q");
            cbHabilidad.Items.Add("W");
            cbHabilidad.Items.Add("E");
            cbHabilidad.Items.Add("R");

            cbHabilidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCampeon.DropDownStyle = ComboBoxStyle.DropDownList;

            
            connection.Open();
            string tabla = "Select * from Campeones";

            MySqlCommand cmd = new MySqlCommand(tabla, connection);

            using (MySqlDataReader reader = cmd.ExecuteReader())
            {

                while (reader.Read())
                {
                    string campeon = reader.GetString(0);

                    cbCampeon.Items.Add(campeon);



                }
                connection.Close();

            }


        }

        private void btnEnlace_Click(object sender, EventArgs e)
        {
            try
            {

                connection.Open();
                string campeon = cbCampeon.SelectedItem.ToString();
                string habilidad = cbHabilidad.SelectedItem.ToString();






                string tabla = "Select * from Enlaces";

                MySqlCommand cmd = new MySqlCommand(tabla, connection);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {

                    while (reader.Read())
                    {

                        if (campeon.Equals(reader.GetString("Campeon")) && habilidad.Equals(reader.GetString("Habilidad")))
                        {
                            DireccionEnlace.Text = reader.GetString("Enlace");
                            DireccionEnlace.Visible = true;
                            break;
                        }




                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("No has seleccionado correctamente." + ex);

            }

            if (connection != null)
            {
                connection.Close();
            }
        }

        private void DireccionEnlace_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(DireccionEnlace.Text);
        }
    }
}
