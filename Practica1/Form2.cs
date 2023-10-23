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
    public partial class VentanaLogin : Form
    {

        //MySqlConnection connection = new MySqlConnection($"Server={"localhost"};Database={"lol"};User Id={"root"};Password={"admin"}");

        MySqlConnection connection = new MySqlConnection($"Server={"bf9zwbmdmtlptaymlaot-mysql.services.clever-cloud.com"};Database={"bf9zwbmdmtlptaymlaot"};User Id={"usjhj42ycmnv1wjk"};Password={"6aVyqZUKG2PdZoSfVL4f"}");

        public VentanaLogin()
        {
            InitializeComponent();
        }


        private Boolean comprobarInicioSesion()
        {
            Boolean comprobar = false;

            try
            {


                connection.Open();
                string usuario = inputUser.Text;
                string password = inputPassword.Text;
                string tabla = "Select * from login";
                MySqlCommand command = new MySqlCommand(tabla, connection);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (usuario.Equals(reader.GetString("username")) && password.Equals(reader.GetString("password")))
                        {
                            comprobar = true;
                            break;

                        }
                    }
                }
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return comprobar;




        }


        


        private void inputUser_Enter(object sender, EventArgs e)
        {
            if (inputUser.Text == "Usuario")
            {
                inputUser.Text = "";
                inputUser.ForeColor = Color.LightGray;
            }
        }

        private void inputUser_Leave_1(object sender, EventArgs e)
        {

            if (inputUser.Text == "")
            {
                inputUser.Text = "Usuario";
                inputUser.ForeColor = Color.Silver;
            }
        }

        private void inputPassword_Enter(object sender, EventArgs e)
        {
            if (inputPassword.Text == "Password")
            {
                inputPassword.PasswordChar = '*';
                inputPassword.Text = "";
                inputPassword.ForeColor = Color.LightGray;
            }

        }

        private void inputPassword_Leave(object sender, EventArgs e)
        {
            if (inputPassword.Text == "")
            {
                inputPassword.PasswordChar = '\0';
                inputPassword.Text = "Password";
                inputPassword.ForeColor = Color.Silver;
            }

        }

        private void openSesion_Click_1(object sender, EventArgs e)
        {
            if (comprobarInicioSesion() == true)
            {
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
                this.Close();
            }
            else
            {
                MessageBox.Show("Datos Erroneos.");
            }
        }

        private void registration_Click_1(object sender, EventArgs e)
        {
            VentanaRegistro ventanaRegistro = new VentanaRegistro();
            ventanaRegistro.Show();
            this.Hide();
            this.Close();
        }

        private void olvPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var recoverPassword = new Form4();
            recoverPassword.ShowDialog();
        }

        private void mostrarPassword_Click_1(object sender, EventArgs e)
        {
            if (inputPassword.PasswordChar == '*')
            {
                inputPassword.PasswordChar = '\0';

            }
            else
            {
                inputPassword.PasswordChar = '*';
            }
        }
    }       
}
