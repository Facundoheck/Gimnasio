namespace proyGim
{
    partial class Form_socios
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_socios));
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.txt_dni = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_tel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.gimnasioDataSet = new proyGim.GimnasioDataSet();
            this.sociosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sociosTableAdapter = new proyGim.GimnasioDataSetTableAdapters.sociosTableAdapter();
            this.txt_direc = new System.Windows.Forms.TextBox();
            this.txt_sexo = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dtp_fecha_nac = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sociosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirPlanillaDeSociosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactarASoporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label8 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.button8 = new System.Windows.Forms.Button();
            this.dgv_socios = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gimnasioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sociosBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_socios)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(101, 173);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(221, 20);
            this.txt_nombre.TabIndex = 0;
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(101, 199);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(221, 20);
            this.txt_apellido.TabIndex = 1;
            // 
            // txt_dni
            // 
            this.txt_dni.Location = new System.Drawing.Point(101, 225);
            this.txt_dni.Name = "txt_dni";
            this.txt_dni.Size = new System.Drawing.Size(221, 20);
            this.txt_dni.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Apellido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Documento:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(211, 444);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 34);
            this.button1.TabIndex = 10;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Teléfono:";
            // 
            // txt_tel
            // 
            this.txt_tel.Location = new System.Drawing.Point(101, 251);
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.Size = new System.Drawing.Size(221, 20);
            this.txt_tel.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Correo:";
            // 
            // txt_correo
            // 
            this.txt_correo.Location = new System.Drawing.Point(101, 277);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(221, 20);
            this.txt_correo.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 362);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Fecha inscripción:";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(101, 386);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(221, 20);
            this.txt_descripcion.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 389);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Descripción:";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(655, 48);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(366, 20);
            this.textBox8.TabIndex = 17;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(525, 47);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 18;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1027, 45);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1350, 121);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 34);
            this.button3.TabIndex = 20;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1221, 655);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(110, 34);
            this.button5.TabIndex = 23;
            this.button5.Text = "Salir";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // gimnasioDataSet
            // 
            this.gimnasioDataSet.DataSetName = "GimnasioDataSet";
            this.gimnasioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sociosBindingSource
            // 
            this.sociosBindingSource.DataMember = "socios";
            this.sociosBindingSource.DataSource = this.gimnasioDataSet;
            // 
            // sociosTableAdapter
            // 
            this.sociosTableAdapter.ClearBeforeFill = true;
            // 
            // txt_direc
            // 
            this.txt_direc.Location = new System.Drawing.Point(101, 304);
            this.txt_direc.Name = "txt_direc";
            this.txt_direc.Size = new System.Drawing.Size(221, 20);
            this.txt_direc.TabIndex = 5;
            // 
            // txt_sexo
            // 
            this.txt_sexo.Location = new System.Drawing.Point(101, 331);
            this.txt_sexo.Name = "txt_sexo";
            this.txt_sexo.Size = new System.Drawing.Size(221, 20);
            this.txt_sexo.TabIndex = 6;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(47, 307);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 13);
            this.label14.TabIndex = 33;
            this.label14.Text = "Domicilio:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(64, 334);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 13);
            this.label15.TabIndex = 34;
            this.label15.Text = "Sexo:";
            // 
            // dtp_fecha_nac
            // 
            this.dtp_fecha_nac.Location = new System.Drawing.Point(101, 359);
            this.dtp_fecha_nac.Name = "dtp_fecha_nac";
            this.dtp_fecha_nac.Size = new System.Drawing.Size(221, 20);
            this.dtp_fecha_nac.TabIndex = 8;
            this.dtp_fecha_nac.Value = new System.DateTime(2023, 9, 19, 16, 20, 37, 0);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sociosToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1493, 24);
            this.menuStrip1.TabIndex = 35;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sociosToolStripMenuItem
            // 
            this.sociosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imprimirPlanillaDeSociosToolStripMenuItem});
            this.sociosToolStripMenuItem.Name = "sociosToolStripMenuItem";
            this.sociosToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.sociosToolStripMenuItem.Text = "Herramientas";
            this.sociosToolStripMenuItem.Click += new System.EventHandler(this.sociosToolStripMenuItem_Click);
            // 
            // imprimirPlanillaDeSociosToolStripMenuItem
            // 
            this.imprimirPlanillaDeSociosToolStripMenuItem.Name = "imprimirPlanillaDeSociosToolStripMenuItem";
            this.imprimirPlanillaDeSociosToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.imprimirPlanillaDeSociosToolStripMenuItem.Text = "Imprimir planilla de socios";
            this.imprimirPlanillaDeSociosToolStripMenuItem.Click += new System.EventHandler(this.imprimirPlanillaDeSociosToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contactarASoporteToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            this.ayudaToolStripMenuItem.Click += new System.EventHandler(this.ayudaToolStripMenuItem_Click);
            // 
            // contactarASoporteToolStripMenuItem
            // 
            this.contactarASoporteToolStripMenuItem.Name = "contactarASoporteToolStripMenuItem";
            this.contactarASoporteToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.contactarASoporteToolStripMenuItem.Text = "Contactar a soporte";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(112, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(196, 21);
            this.label8.TabIndex = 37;
            this.label8.Text = "Registrar nuevo socio";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1350, 191);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(110, 34);
            this.button6.TabIndex = 38;
            this.button6.Text = "Imprimir";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(67, 444);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(111, 34);
            this.button8.TabIndex = 40;
            this.button8.Text = "Limpiar";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // dgv_socios
            // 
            this.dgv_socios.AllowUserToAddRows = false;
            this.dgv_socios.AllowUserToDeleteRows = false;
            this.dgv_socios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_socios.Location = new System.Drawing.Point(364, 86);
            this.dgv_socios.Name = "dgv_socios";
            this.dgv_socios.Size = new System.Drawing.Size(955, 442);
            this.dgv_socios.TabIndex = 41;
            this.dgv_socios.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DataGridView_CellFormatting);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1350, 263);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 34);
            this.button4.TabIndex = 42;
            this.button4.Text = "Exportar Excel";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form_socios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1493, 712);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dgv_socios);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtp_fecha_nac);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txt_sexo);
            this.Controls.Add(this.txt_direc);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_correo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_tel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_dni);
            this.Controls.Add(this.txt_apellido);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_socios";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Socios";
            this.Load += new System.EventHandler(this.Form_socios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gimnasioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sociosBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_socios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.TextBox txt_dni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_tel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_correo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private GimnasioDataSet gimnasioDataSet;
        private System.Windows.Forms.BindingSource sociosBindingSource;
        private GimnasioDataSetTableAdapters.sociosTableAdapter sociosTableAdapter;
        private System.Windows.Forms.TextBox txt_direc;
        private System.Windows.Forms.TextBox txt_sexo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dtp_fecha_nac;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactarASoporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sociosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirPlanillaDeSociosToolStripMenuItem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.DataGridView dgv_socios;
        private System.Windows.Forms.Button button4;
    }
}