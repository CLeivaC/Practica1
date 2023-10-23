namespace Practica1
{
    partial class VentanaLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaLogin));
            this.inputUser = new System.Windows.Forms.TextBox();
            this.inputPassword = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.registration = new Practica1.RJButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.openSesion = new Practica1.RJButton();
            this.olvPassword = new System.Windows.Forms.LinkLabel();
            this.mostrarPassword = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // inputUser
            // 
            this.inputUser.BackColor = System.Drawing.Color.LightSlateGray;
            this.inputUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputUser.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputUser.ForeColor = System.Drawing.Color.Silver;
            this.inputUser.Location = new System.Drawing.Point(441, 174);
            this.inputUser.Name = "inputUser";
            this.inputUser.Size = new System.Drawing.Size(197, 24);
            this.inputUser.TabIndex = 2;
            this.inputUser.Text = "Usuario";
            this.inputUser.Enter += new System.EventHandler(this.inputUser_Enter);
            this.inputUser.Leave += new System.EventHandler(this.inputUser_Leave_1);
            // 
            // inputPassword
            // 
            this.inputPassword.BackColor = System.Drawing.Color.LightSlateGray;
            this.inputPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputPassword.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputPassword.ForeColor = System.Drawing.Color.Silver;
            this.inputPassword.Location = new System.Drawing.Point(441, 244);
            this.inputPassword.Name = "inputPassword";
            this.inputPassword.Size = new System.Drawing.Size(197, 24);
            this.inputPassword.TabIndex = 4;
            this.inputPassword.Text = "Password";
            this.inputPassword.Enter += new System.EventHandler(this.inputPassword_Enter);
            this.inputPassword.Leave += new System.EventHandler(this.inputPassword_Leave);
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.registration);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(329, 450);
            this.panel1.TabIndex = 7;
            // 
            // registration
            // 
            this.registration.BackColor = System.Drawing.Color.Cornsilk;
            this.registration.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.registration.BorderRadius = 15;
            this.registration.BorderSize = 0;
            this.registration.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.registration.FlatAppearance.BorderSize = 0;
            this.registration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registration.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registration.ForeColor = System.Drawing.Color.Black;
            this.registration.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.registration.Location = new System.Drawing.Point(123, 361);
            this.registration.Name = "registration";
            this.registration.Size = new System.Drawing.Size(123, 45);
            this.registration.TabIndex = 19;
            this.registration.Text = "Registrate";
            this.registration.UseVisualStyleBackColor = false;
            this.registration.Click += new System.EventHandler(this.registration_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(47, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(272, 243);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Location = new System.Drawing.Point(441, 196);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(199, 2);
            this.panel2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Location = new System.Drawing.Point(441, 266);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(199, 2);
            this.panel3.TabIndex = 9;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(418, 174);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(17, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(418, 244);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(17, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(418, 28);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(222, 121);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // openSesion
            // 
            this.openSesion.BackColor = System.Drawing.Color.Khaki;
            this.openSesion.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.openSesion.BorderRadius = 15;
            this.openSesion.BorderSize = 0;
            this.openSesion.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.openSesion.FlatAppearance.BorderSize = 0;
            this.openSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openSesion.ForeColor = System.Drawing.Color.Black;
            this.openSesion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.openSesion.Location = new System.Drawing.Point(441, 296);
            this.openSesion.Name = "openSesion";
            this.openSesion.Size = new System.Drawing.Size(175, 45);
            this.openSesion.TabIndex = 18;
            this.openSesion.Text = "Iniciar Sesion";
            this.openSesion.UseVisualStyleBackColor = false;
            this.openSesion.Click += new System.EventHandler(this.openSesion_Click_1);
            // 
            // olvPassword
            // 
            this.olvPassword.AutoSize = true;
            this.olvPassword.Location = new System.Drawing.Point(456, 361);
            this.olvPassword.Name = "olvPassword";
            this.olvPassword.Size = new System.Drawing.Size(149, 13);
            this.olvPassword.TabIndex = 21;
            this.olvPassword.TabStop = true;
            this.olvPassword.Text = "¿Has olvidado tu contraseña?";
            this.olvPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.olvPassword_LinkClicked);
            // 
            // mostrarPassword
            // 
            this.mostrarPassword.BackColor = System.Drawing.Color.Transparent;
            this.mostrarPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mostrarPassword.BackgroundImage")));
            this.mostrarPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mostrarPassword.Location = new System.Drawing.Point(606, 242);
            this.mostrarPassword.Name = "mostrarPassword";
            this.mostrarPassword.Size = new System.Drawing.Size(34, 23);
            this.mostrarPassword.TabIndex = 22;
            this.mostrarPassword.TabStop = false;
            this.mostrarPassword.Click += new System.EventHandler(this.mostrarPassword_Click_1);
            // 
            // VentanaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mostrarPassword);
            this.Controls.Add(this.olvPassword);
            this.Controls.Add(this.openSesion);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.inputPassword);
            this.Controls.Add(this.inputUser);
            this.Name = "VentanaLogin";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox inputUser;
        private System.Windows.Forms.TextBox inputPassword;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private RJButton openSesion;
        private RJButton registration;
        private System.Windows.Forms.LinkLabel olvPassword;
        private System.Windows.Forms.PictureBox mostrarPassword;
    }
}