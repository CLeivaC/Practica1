using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;
using System.Drawing;
using iText.Layout.Properties;

namespace Practica1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            abrirFormHija(new FormInicio());
           
        }

      

        private void abrirFormHija(object formHija)
        {
            if(this.panelPrincipal.Controls.Count > 0)
            {
                this.panelPrincipal.Controls.RemoveAt(0);
            }

            Form fh = formHija as Form;

            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelPrincipal.Controls.Add(fh);
            this.panelPrincipal.Tag = fh;
            fh.Show();
        }

        private void btnCampeones_Click(object sender, EventArgs e)
        {
            abrirFormHija(new FormCampeones());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            abrirFormHija(new FormTablaHabilidades());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            abrirFormHija(new FormObtenerEnlace());
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            
            abrirFormHija(new FormInicio());
            panelPrincipal.Show();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           
            if(this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);


        private void TopPanel_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
