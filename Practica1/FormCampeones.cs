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
    public partial class FormCampeones : Form
    {
        MySqlConnection connection = new MySqlConnection($"Server={"bf9zwbmdmtlptaymlaot-mysql.services.clever-cloud.com"};Database={"bf9zwbmdmtlptaymlaot"};User Id={"usjhj42ycmnv1wjk"};Password={"6aVyqZUKG2PdZoSfVL4f"}");
        public FormCampeones()
        {
            InitializeComponent();
        }

        public void establecerConexion(MySqlConnection connection)
        {

            try
            {
                connection.Open();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }finally { connection.Close(); }
        }


        public void mostrarTablaCampeones()
        {

            string tabla = "Select * from Campeones";

            MySqlCommand cmd = new MySqlCommand(tabla, connection);

            connection.Open();
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {

                while (reader.Read())
                {
                    string campeon = reader.GetString(0);
                    string posicion = reader.GetString(1);
                    string tipo = reader.GetString(2);
                    string skin = reader.GetString(3);


                    label1.Text = addToInputText("El campeon " + campeon + " juega en la posicion " + posicion + ", es de tipo " + tipo + " y tiene la skin de " + skin + "\n".ToString());

                }
                connection.Close();

            }

        }

        private string addToInputText(string filaCampeon)
        {
            return label1.Text + "\n" + filaCampeon;
        }

        private void mostrarTableCampeones_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            mostrarTablaCampeones();
        }
    }
}
