namespace ProyectoII_Tiquete_bus
{
    partial class CrudHorario
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
            this.txtIdruta = new System.Windows.Forms.TextBox();
            this.txtDia = new System.Windows.Forms.TextBox();
            this.txtHorasalida = new System.Windows.Forms.TextBox();
            this.txtHorallegada = new System.Windows.Forms.TextBox();
            this.cmbRuta1 = new System.Windows.Forms.ComboBox();
            this.dgLista = new System.Windows.Forms.DataGridView();
            this.cmbTerminal = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdruta
            // 
            this.txtIdruta.Location = new System.Drawing.Point(176, 75);
            this.txtIdruta.Name = "txtIdruta";
            this.txtIdruta.Size = new System.Drawing.Size(183, 22);
            this.txtIdruta.TabIndex = 19;
            // 
            // txtDia
            // 
            this.txtDia.Location = new System.Drawing.Point(176, 240);
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(183, 22);
            this.txtDia.TabIndex = 20;
            // 
            // txtHorasalida
            // 
            this.txtHorasalida.Location = new System.Drawing.Point(176, 298);
            this.txtHorasalida.Name = "txtHorasalida";
            this.txtHorasalida.Size = new System.Drawing.Size(183, 22);
            this.txtHorasalida.TabIndex = 21;
            // 
            // txtHorallegada
            // 
            this.txtHorallegada.Location = new System.Drawing.Point(176, 358);
            this.txtHorallegada.Name = "txtHorallegada";
            this.txtHorallegada.Size = new System.Drawing.Size(183, 22);
            this.txtHorallegada.TabIndex = 22;
            // 
            // cmbRuta1
            // 
            this.cmbRuta1.FormattingEnabled = true;
            this.cmbRuta1.Location = new System.Drawing.Point(176, 121);
            this.cmbRuta1.Name = "cmbRuta1";
            this.cmbRuta1.Size = new System.Drawing.Size(183, 24);
            this.cmbRuta1.TabIndex = 23;
            // 
            // dgLista
            // 
            this.dgLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLista.Location = new System.Drawing.Point(67, 405);
            this.dgLista.Name = "dgLista";
            this.dgLista.RowHeadersWidth = 51;
            this.dgLista.RowTemplate.Height = 24;
            this.dgLista.Size = new System.Drawing.Size(602, 189);
            this.dgLista.TabIndex = 25;
            // 
            // cmbTerminal
            // 
            this.cmbTerminal.FormattingEnabled = true;
            this.cmbTerminal.Location = new System.Drawing.Point(176, 184);
            this.cmbTerminal.Name = "cmbTerminal";
            this.cmbTerminal.Size = new System.Drawing.Size(183, 24);
            this.cmbTerminal.TabIndex = 27;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoII_Tiquete_bus.Properties.Resources.Schedule_Maker_55;
            this.pictureBox1.Location = new System.Drawing.Point(176, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 46);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Image = global::ProyectoII_Tiquete_bus.Properties.Resources.Captura_de_pantalla_2022_03_25_140036;
            this.label7.Location = new System.Drawing.Point(236, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(183, 29);
            this.label7.TabIndex = 26;
            this.label7.Text = "Gestor Horarios";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Image = global::ProyectoII_Tiquete_bus.Properties.Resources.Captura_de_pantalla_2022_03_25_140036;
            this.label6.Location = new System.Drawing.Point(40, 358);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Hora Llegada:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Image = global::ProyectoII_Tiquete_bus.Properties.Resources.Captura_de_pantalla_2022_03_25_140036;
            this.label5.Location = new System.Drawing.Point(89, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Dia:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Image = global::ProyectoII_Tiquete_bus.Properties.Resources.Captura_de_pantalla_2022_03_25_140036;
            this.label4.Location = new System.Drawing.Point(53, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Hora Salida:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Image = global::ProyectoII_Tiquete_bus.Properties.Resources.Captura_de_pantalla_2022_03_25_140036;
            this.label3.Location = new System.Drawing.Point(76, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Terminal:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Image = global::ProyectoII_Tiquete_bus.Properties.Resources.Captura_de_pantalla_2022_03_25_140036;
            this.label2.Location = new System.Drawing.Point(89, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Ruta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Image = global::ProyectoII_Tiquete_bus.Properties.Resources.Captura_de_pantalla_2022_03_25_140036;
            this.label1.Location = new System.Drawing.Point(89, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Codigo:";
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::ProyectoII_Tiquete_bus.Properties.Resources.exit1;
            this.btnSalir.Location = new System.Drawing.Point(532, 169);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(59, 52);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = global::ProyectoII_Tiquete_bus.Properties.Resources.eliminar1;
            this.btnEliminar.Location = new System.Drawing.Point(440, 251);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(59, 52);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Image = global::ProyectoII_Tiquete_bus.Properties.Resources.actualizar1;
            this.btnActualizar.Location = new System.Drawing.Point(440, 193);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(59, 52);
            this.btnActualizar.TabIndex = 10;
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Image = global::ProyectoII_Tiquete_bus.Properties.Resources.consultar1;
            this.btnConsultar.Location = new System.Drawing.Point(440, 135);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(59, 52);
            this.btnConsultar.TabIndex = 9;
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = global::ProyectoII_Tiquete_bus.Properties.Resources.agregar1;
            this.btnAgregar.Location = new System.Drawing.Point(440, 77);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(59, 52);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // CrudHorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoII_Tiquete_bus.Properties.Resources.Captura_de_pantalla_2022_03_25_140036;
            this.ClientSize = new System.Drawing.Size(821, 619);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmbTerminal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgLista);
            this.Controls.Add(this.cmbRuta1);
            this.Controls.Add(this.txtHorallegada);
            this.Controls.Add(this.txtHorasalida);
            this.Controls.Add(this.txtDia);
            this.Controls.Add(this.txtIdruta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnAgregar);
            this.Name = "CrudHorario";
            this.Text = "CrudHorario";
            this.Load += new System.EventHandler(this.CrudHorario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIdruta;
        private System.Windows.Forms.TextBox txtDia;
        private System.Windows.Forms.TextBox txtHorasalida;
        private System.Windows.Forms.TextBox txtHorallegada;
        private System.Windows.Forms.ComboBox cmbRuta1;
        private System.Windows.Forms.DataGridView dgLista;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbTerminal;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}