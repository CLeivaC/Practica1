namespace Practica1
{
    partial class FormCampeones
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
            this.mostrarTableCampeones = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mostrarTableCampeones
            // 
            this.mostrarTableCampeones.Location = new System.Drawing.Point(65, 62);
            this.mostrarTableCampeones.Name = "mostrarTableCampeones";
            this.mostrarTableCampeones.Size = new System.Drawing.Size(157, 38);
            this.mostrarTableCampeones.TabIndex = 1;
            this.mostrarTableCampeones.Text = "MostrarCamposCampeones";
            this.mostrarTableCampeones.UseVisualStyleBackColor = true;
            this.mostrarTableCampeones.Click += new System.EventHandler(this.mostrarTableCampeones_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "label1";
            // 
            // FormCampeones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 529);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mostrarTableCampeones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCampeones";
            this.Text = "FormCampeones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mostrarTableCampeones;
        private System.Windows.Forms.Label label1;
    }
}