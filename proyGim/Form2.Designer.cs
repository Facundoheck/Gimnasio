namespace proyGim
{
    partial class Form2
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
            this.btn_socios = new System.Windows.Forms.Button();
            this.btn_rutinas = new System.Windows.Forms.Button();
            this.btn_ctacte = new System.Windows.Forms.Button();
            this.btn_profesores = new System.Windows.Forms.Button();
            this.btn_st = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_socios
            // 
            this.btn_socios.Location = new System.Drawing.Point(33, 75);
            this.btn_socios.Name = "btn_socios";
            this.btn_socios.Size = new System.Drawing.Size(181, 58);
            this.btn_socios.TabIndex = 0;
            this.btn_socios.Text = "Socios";
            this.btn_socios.UseVisualStyleBackColor = true;
            this.btn_socios.Click += new System.EventHandler(this.btn_socios_Click);
            // 
            // btn_rutinas
            // 
            this.btn_rutinas.Location = new System.Drawing.Point(33, 139);
            this.btn_rutinas.Name = "btn_rutinas";
            this.btn_rutinas.Size = new System.Drawing.Size(181, 58);
            this.btn_rutinas.TabIndex = 1;
            this.btn_rutinas.Text = "Rutinas";
            this.btn_rutinas.UseVisualStyleBackColor = true;
            // 
            // btn_ctacte
            // 
            this.btn_ctacte.Location = new System.Drawing.Point(33, 203);
            this.btn_ctacte.Name = "btn_ctacte";
            this.btn_ctacte.Size = new System.Drawing.Size(182, 58);
            this.btn_ctacte.TabIndex = 2;
            this.btn_ctacte.Text = "Cuentas Corrientes";
            this.btn_ctacte.UseVisualStyleBackColor = true;
            // 
            // btn_profesores
            // 
            this.btn_profesores.Location = new System.Drawing.Point(33, 267);
            this.btn_profesores.Name = "btn_profesores";
            this.btn_profesores.Size = new System.Drawing.Size(182, 58);
            this.btn_profesores.TabIndex = 3;
            this.btn_profesores.Text = "Profesores";
            this.btn_profesores.UseVisualStyleBackColor = true;
            // 
            // btn_st
            // 
            this.btn_st.Location = new System.Drawing.Point(33, 331);
            this.btn_st.Name = "btn_st";
            this.btn_st.Size = new System.Drawing.Size(181, 57);
            this.btn_st.TabIndex = 4;
            this.btn_st.Text = "Solicitar ayuda a soporte técnico";
            this.btn_st.UseVisualStyleBackColor = true;
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(632, 425);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(86, 44);
            this.btn_salir.TabIndex = 6;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::proyGim.Properties.Resources.gimnasio;
            this.pictureBox1.Location = new System.Drawing.Point(243, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(475, 344);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 497);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_st);
            this.Controls.Add(this.btn_profesores);
            this.Controls.Add(this.btn_ctacte);
            this.Controls.Add(this.btn_rutinas);
            this.Controls.Add(this.btn_socios);
            this.Name = "Form2";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_socios;
        private System.Windows.Forms.Button btn_rutinas;
        private System.Windows.Forms.Button btn_ctacte;
        private System.Windows.Forms.Button btn_profesores;
        private System.Windows.Forms.Button btn_st;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}