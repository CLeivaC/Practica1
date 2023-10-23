namespace Practica1
{
    partial class FormObtenerEnlace
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
            this.cbCampeon = new System.Windows.Forms.ComboBox();
            this.cbHabilidad = new System.Windows.Forms.ComboBox();
            this.DireccionEnlace = new System.Windows.Forms.LinkLabel();
            this.btnEnlace = new Practica1.RJButton();
            this.SuspendLayout();
            // 
            // cbCampeon
            // 
            this.cbCampeon.FormattingEnabled = true;
            this.cbCampeon.Location = new System.Drawing.Point(95, 35);
            this.cbCampeon.Name = "cbCampeon";
            this.cbCampeon.Size = new System.Drawing.Size(135, 21);
            this.cbCampeon.TabIndex = 0;
            // 
            // cbHabilidad
            // 
            this.cbHabilidad.FormattingEnabled = true;
            this.cbHabilidad.Location = new System.Drawing.Point(326, 35);
            this.cbHabilidad.Name = "cbHabilidad";
            this.cbHabilidad.Size = new System.Drawing.Size(135, 21);
            this.cbHabilidad.TabIndex = 1;
            // 
            // DireccionEnlace
            // 
            this.DireccionEnlace.AutoSize = true;
            this.DireccionEnlace.Location = new System.Drawing.Point(245, 110);
            this.DireccionEnlace.Name = "DireccionEnlace";
            this.DireccionEnlace.Size = new System.Drawing.Size(55, 13);
            this.DireccionEnlace.TabIndex = 2;
            this.DireccionEnlace.TabStop = true;
            this.DireccionEnlace.Text = "linkLabel1";
            this.DireccionEnlace.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DireccionEnlace_LinkClicked);
            // 
            // btnEnlace
            // 
            this.btnEnlace.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnEnlace.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnEnlace.BorderRadius = 0;
            this.btnEnlace.BorderSize = 0;
            this.btnEnlace.FlatAppearance.BorderSize = 0;
            this.btnEnlace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnlace.ForeColor = System.Drawing.Color.White;
            this.btnEnlace.Location = new System.Drawing.Point(102, 176);
            this.btnEnlace.Name = "btnEnlace";
            this.btnEnlace.Size = new System.Drawing.Size(448, 118);
            this.btnEnlace.TabIndex = 3;
            this.btnEnlace.Text = "Obtener enlace";
            this.btnEnlace.UseVisualStyleBackColor = false;
            this.btnEnlace.Click += new System.EventHandler(this.btnEnlace_Click);
            // 
            // FormObtenerEnlace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 529);
            this.Controls.Add(this.btnEnlace);
            this.Controls.Add(this.DireccionEnlace);
            this.Controls.Add(this.cbHabilidad);
            this.Controls.Add(this.cbCampeon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormObtenerEnlace";
            this.Text = "FormObtenerEnlace";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCampeon;
        private System.Windows.Forms.ComboBox cbHabilidad;
        private System.Windows.Forms.LinkLabel DireccionEnlace;
        private RJButton btnEnlace;
    }
}