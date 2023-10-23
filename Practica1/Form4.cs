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
    public partial class Form4 : Form
    {
        //MySqlConnection connection = new MySqlConnection($"Server={"localhost"};Database={"lol"};User Id={"root"};Password={"admin"}");

        MySqlConnection connection = new MySqlConnection($"Server={"bf9zwbmdmtlptaymlaot-mysql.services.clever-cloud.com"};Database={"bf9zwbmdmtlptaymlaot"};User Id={"usjhj42ycmnv1wjk"};Password={"6aVyqZUKG2PdZoSfVL4f"}");
        public Form4()
        {
            InitializeComponent();
        }

        

       

        private void btnSend_Click_1(object sender, EventArgs e)
        {
            var user = new NRecuperarPassword();
            var result = user.recoverPasssword(textBox1.Text);
            MessageBox.Show(result);
            this.Close();
            connection.Close();
        }
    }
}
