using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica1
{
    public partial class VentanaRegistro : Form
    {
        //MySqlConnection connection = new MySqlConnection($"Server={"localhost"};Database={"lol"};User Id={"root"};Password={"admin"}");

        MySqlConnection connection = new MySqlConnection($"Server={"bf9zwbmdmtlptaymlaot-mysql.services.clever-cloud.com"};Database={"bf9zwbmdmtlptaymlaot"};User Id={"usjhj42ycmnv1wjk"};Password={"6aVyqZUKG2PdZoSfVL4f"}");
        public VentanaRegistro()
        {
            InitializeComponent();

            for (int i = 18; i < 99; i++)
            {

                inputAge.Items.Add(i.ToString());
            }

        }

       


        private void registro()
        {
            string username, password, email, nombre, apellidos;
            int edad;

            

                try
                {
                    connection.Open();

                if (inputUserReg.Text != "" && inputPasswordReg.Text != "" && inputEmail.Text != "" && inputName.Text != "" && inputSecondName.Text != "" && inputAge.SelectedItem != null)
                {

                    username = inputUserReg.Text;
                    password = inputPasswordReg.Text;
                    email = inputEmail.Text;
                    nombre = inputName.Text;
                    apellidos = inputSecondName.Text;
                    edad = int.Parse(inputAge.SelectedItem.ToString());

                    string crearRegistro = "INSERT INTO login(nombre,apellidos,email,username,password,edad) VALUES ('" + nombre + "','" + apellidos + "','" + email + "','" + username + "','" + password + "','" + edad + "')";
                    MySqlCommand comando = new MySqlCommand(crearRegistro, connection);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Los datos se guardaron correctamente");
                    MessageBox.Show(crearRegistro);
                    

                }
                else
                {
                    MessageBox.Show("Rellena todos los campos.");
                }
                connection.Close();

            }
            catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            
        }

        private void btnRegistration_Click_1(object sender, EventArgs e)
        {
            registro();
        }

        private void volverAPagAnt_Click_1(object sender, EventArgs e)
        {

            VentanaLogin ventanaLogin = new VentanaLogin();
            ventanaLogin.Show();
            this.Hide();
            this.Close();
        }

        private void inputName_Enter(object sender, EventArgs e)
        {
            if (inputName.Text == "Nombre")
            {
                inputName.Text = "";
                inputName.ForeColor = Color.DimGray;
            }
        }

        private void inputName_Leave(object sender, EventArgs e)
        {
            if (inputName.Text == "")
            {
                inputName.Text = "Nombre";
                inputName.ForeColor = Color.DimGray;
            }
        }

        private void inputSecondName_Enter(object sender, EventArgs e)
        {
            if (inputSecondName.Text == "Apellidos")
            {
                inputSecondName.Text = "";
                inputSecondName.ForeColor = Color.DimGray;
            }
        }

        private void inputSecondName_Leave(object sender, EventArgs e)
        {
            if (inputSecondName.Text == "")
            {
                inputSecondName.Text = "Apellidos";
                inputSecondName.ForeColor = Color.DimGray;
            }
        }

        private void inputEmail_Enter(object sender, EventArgs e)
        {
            if (inputEmail.Text == "Email")
            {
                inputEmail.Text = "";
                inputEmail.ForeColor = Color.DimGray;
            }
        }

        private void inputEmail_Leave(object sender, EventArgs e)
        {
            if (inputEmail.Text == "")
            {
                inputEmail.Text = "Email";
                inputEmail.ForeColor = Color.DimGray;
            }
        }

        private void inputUserReg_Enter(object sender, EventArgs e)
        {
            if (inputUserReg.Text == "Usuario")
            {
                inputUserReg.Text = "";
                inputUserReg.ForeColor = Color.DimGray;
            }
        }

        private void inputUserReg_Leave(object sender, EventArgs e)
        {
            if (inputUserReg.Text == "")
            {
                inputUserReg.Text = "Usuario";
                inputUserReg.ForeColor = Color.DimGray;
            }
        }


        private void inputPasswordReg_Enter(object sender, EventArgs e)
        {
            if (inputPasswordReg.Text == "Password")
            {
                inputPasswordReg.PasswordChar = '*';
                inputPasswordReg.Text = "";
                inputPasswordReg.ForeColor = Color.DimGray;
            }
        }

        private void inputPasswordReg_Leave(object sender, EventArgs e)
        {
            if (inputPasswordReg.Text == "")
            {
                inputPasswordReg.PasswordChar = '\0';
                inputPasswordReg.Text = "Password";
                inputPasswordReg.ForeColor = Color.DimGray;
            }
        }
    }
}
