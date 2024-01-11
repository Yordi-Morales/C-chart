namespace ProyectoII_Tiquete_bus
{
    partial class MenuPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcionesstp = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarUsuariosTS1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crudsstp = new System.Windows.Forms.ToolStripMenuItem();
            this.terminalstp = new System.Windows.Forms.ToolStripMenuItem();
            this.horariosstp = new System.Windows.Forms.ToolStripMenuItem();
            this.rutasstp = new System.Windows.Forms.ToolStripMenuItem();
            this.unidadesstp = new System.Windows.Forms.ToolStripMenuItem();
            this.tiquetesstp = new System.Windows.Forms.ToolStripMenuItem();
            this.ventaNacionalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventaInternacionalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.corteCajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cierreCajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encomiendasstp = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesstp = new System.Windows.Forms.ToolStripMenuItem();
            this.laCantidadDeTiquetesVendidoPorRutasPorDíaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cualEsLaRutaQueMásTiquetesVendePorMesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cualEsLaRutaEnLaQueSeEnvíaMásEncomiendasPorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarEnQueMesSeRegistranMásSalidasHaciaPanamáToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarCuantasReservacionesSeHanHechoParaUnDíaDeterminadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarCuántoDineroSeHaGeneradoPorLaVentaDeTiquetesEnUnDíaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostarLasUnidadesQueTienenElPermisoDeTransitarVigenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarLasUnidadesQueNoTienenPermisoDeTransitarYCuandoSeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesstp,
            this.crudsstp,
            this.tiquetesstp,
            this.encomiendasstp,
            this.reportesstp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(743, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcionesstp
            // 
            this.opcionesstp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarUsuariosTS1,
            this.cerrarSesionToolStripMenuItem});
            this.opcionesstp.Name = "opcionesstp";
            this.opcionesstp.Size = new System.Drawing.Size(69, 20);
            this.opcionesstp.Text = "Opciones";
            this.opcionesstp.Click += new System.EventHandler(this.opcionesstp_Click);
            // 
            // registrarUsuariosTS1
            // 
            this.registrarUsuariosTS1.Name = "registrarUsuariosTS1";
            this.registrarUsuariosTS1.Size = new System.Drawing.Size(180, 22);
            this.registrarUsuariosTS1.Text = "Registrar Usuarios";
            this.registrarUsuariosTS1.Click += new System.EventHandler(this.registrarUsuariosToolStripMenuItem1_Click);
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click);
            // 
            // crudsstp
            // 
            this.crudsstp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.terminalstp,
            this.horariosstp,
            this.rutasstp,
            this.unidadesstp});
            this.crudsstp.Name = "crudsstp";
            this.crudsstp.Size = new System.Drawing.Size(50, 20);
            this.crudsstp.Text = "Cruds";
            this.crudsstp.Click += new System.EventHandler(this.crudsstp_Click);
            // 
            // terminalstp
            // 
            this.terminalstp.Name = "terminalstp";
            this.terminalstp.Size = new System.Drawing.Size(180, 22);
            this.terminalstp.Text = "Terminales";
            this.terminalstp.Click += new System.EventHandler(this.terminalesToolStripMenuItem_Click);
            // 
            // horariosstp
            // 
            this.horariosstp.Name = "horariosstp";
            this.horariosstp.Size = new System.Drawing.Size(180, 22);
            this.horariosstp.Text = "Horarios";
            this.horariosstp.Click += new System.EventHandler(this.horariosToolStripMenuItem_Click);
            // 
            // rutasstp
            // 
            this.rutasstp.Name = "rutasstp";
            this.rutasstp.Size = new System.Drawing.Size(180, 22);
            this.rutasstp.Text = "Rutas";
            this.rutasstp.Click += new System.EventHandler(this.rutasToolStripMenuItem_Click);
            // 
            // unidadesstp
            // 
            this.unidadesstp.Name = "unidadesstp";
            this.unidadesstp.Size = new System.Drawing.Size(180, 22);
            this.unidadesstp.Text = "Unidades";
            this.unidadesstp.Click += new System.EventHandler(this.unidadesToolStripMenuItem_Click);
            // 
            // tiquetesstp
            // 
            this.tiquetesstp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventaNacionalToolStripMenuItem,
            this.ventaInternacionalToolStripMenuItem,
            this.corteCajaToolStripMenuItem,
            this.cierreCajaToolStripMenuItem});
            this.tiquetesstp.Name = "tiquetesstp";
            this.tiquetesstp.Size = new System.Drawing.Size(63, 20);
            this.tiquetesstp.Text = "Tiquetes";
            this.tiquetesstp.Click += new System.EventHandler(this.tiquetesToolStripMenuItem_Click);
            // 
            // ventaNacionalToolStripMenuItem
            // 
            this.ventaNacionalToolStripMenuItem.Name = "ventaNacionalToolStripMenuItem";
            this.ventaNacionalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ventaNacionalToolStripMenuItem.Text = "Venta Nacional";
            this.ventaNacionalToolStripMenuItem.Click += new System.EventHandler(this.ventaNacionalToolStripMenuItem_Click);
            // 
            // ventaInternacionalToolStripMenuItem
            // 
            this.ventaInternacionalToolStripMenuItem.Name = "ventaInternacionalToolStripMenuItem";
            this.ventaInternacionalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ventaInternacionalToolStripMenuItem.Text = "Venta Internacional";
            this.ventaInternacionalToolStripMenuItem.Click += new System.EventHandler(this.ventaInternacionalToolStripMenuItem_Click);
            // 
            // corteCajaToolStripMenuItem
            // 
            this.corteCajaToolStripMenuItem.Name = "corteCajaToolStripMenuItem";
            this.corteCajaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.corteCajaToolStripMenuItem.Text = "Corte Caja";
            // 
            // cierreCajaToolStripMenuItem
            // 
            this.cierreCajaToolStripMenuItem.Name = "cierreCajaToolStripMenuItem";
            this.cierreCajaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cierreCajaToolStripMenuItem.Text = "Cierre Caja";
            // 
            // encomiendasstp
            // 
            this.encomiendasstp.Name = "encomiendasstp";
            this.encomiendasstp.Size = new System.Drawing.Size(90, 20);
            this.encomiendasstp.Text = "Encomiendas";
            this.encomiendasstp.Click += new System.EventHandler(this.encomiendasToolStripMenuItem_Click);
            // 
            // reportesstp
            // 
            this.reportesstp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.laCantidadDeTiquetesVendidoPorRutasPorDíaToolStripMenuItem,
            this.cualEsLaRutaQueMásTiquetesVendePorMesToolStripMenuItem,
            this.cualEsLaRutaEnLaQueSeEnvíaMásEncomiendasPorToolStripMenuItem,
            this.mostrarEnQueMesSeRegistranMásSalidasHaciaPanamáToolStripMenuItem,
            this.mostrarCuantasReservacionesSeHanHechoParaUnDíaDeterminadoToolStripMenuItem,
            this.mostrarCuántoDineroSeHaGeneradoPorLaVentaDeTiquetesEnUnDíaToolStripMenuItem,
            this.mostarLasUnidadesQueTienenElPermisoDeTransitarVigenteToolStripMenuItem,
            this.mostrarLasUnidadesQueNoTienenPermisoDeTransitarYCuandoSeToolStripMenuItem});
            this.reportesstp.Name = "reportesstp";
            this.reportesstp.Size = new System.Drawing.Size(65, 20);
            this.reportesstp.Text = "Reportes";
            // 
            // laCantidadDeTiquetesVendidoPorRutasPorDíaToolStripMenuItem
            // 
            this.laCantidadDeTiquetesVendidoPorRutasPorDíaToolStripMenuItem.Name = "laCantidadDeTiquetesVendidoPorRutasPorDíaToolStripMenuItem";
            this.laCantidadDeTiquetesVendidoPorRutasPorDíaToolStripMenuItem.Size = new System.Drawing.Size(695, 22);
            this.laCantidadDeTiquetesVendidoPorRutasPorDíaToolStripMenuItem.Text = " La cantidad de tiquetes vendido por rutas por día";
            // 
            // cualEsLaRutaQueMásTiquetesVendePorMesToolStripMenuItem
            // 
            this.cualEsLaRutaQueMásTiquetesVendePorMesToolStripMenuItem.Name = "cualEsLaRutaQueMásTiquetesVendePorMesToolStripMenuItem";
            this.cualEsLaRutaQueMásTiquetesVendePorMesToolStripMenuItem.Size = new System.Drawing.Size(695, 22);
            this.cualEsLaRutaQueMásTiquetesVendePorMesToolStripMenuItem.Text = "Cual es la ruta que más tiquetes vende por mes";
            // 
            // cualEsLaRutaEnLaQueSeEnvíaMásEncomiendasPorToolStripMenuItem
            // 
            this.cualEsLaRutaEnLaQueSeEnvíaMásEncomiendasPorToolStripMenuItem.Name = "cualEsLaRutaEnLaQueSeEnvíaMásEncomiendasPorToolStripMenuItem";
            this.cualEsLaRutaEnLaQueSeEnvíaMásEncomiendasPorToolStripMenuItem.Size = new System.Drawing.Size(695, 22);
            this.cualEsLaRutaEnLaQueSeEnvíaMásEncomiendasPorToolStripMenuItem.Text = "Cual es la ruta en la que se envía más encomiendas por semana y cuál es la que en" +
    "vía menos encomienda por semana";
            this.cualEsLaRutaEnLaQueSeEnvíaMásEncomiendasPorToolStripMenuItem.Click += new System.EventHandler(this.cualEsLaRutaEnLaQueSeEnvíaMásEncomiendasPorToolStripMenuItem_Click);
            // 
            // mostrarEnQueMesSeRegistranMásSalidasHaciaPanamáToolStripMenuItem
            // 
            this.mostrarEnQueMesSeRegistranMásSalidasHaciaPanamáToolStripMenuItem.Name = "mostrarEnQueMesSeRegistranMásSalidasHaciaPanamáToolStripMenuItem";
            this.mostrarEnQueMesSeRegistranMásSalidasHaciaPanamáToolStripMenuItem.Size = new System.Drawing.Size(695, 22);
            this.mostrarEnQueMesSeRegistranMásSalidasHaciaPanamáToolStripMenuItem.Text = "Mostrar en que mes se registran más salidas hacia Panamá";
            // 
            // mostrarCuantasReservacionesSeHanHechoParaUnDíaDeterminadoToolStripMenuItem
            // 
            this.mostrarCuantasReservacionesSeHanHechoParaUnDíaDeterminadoToolStripMenuItem.Name = "mostrarCuantasReservacionesSeHanHechoParaUnDíaDeterminadoToolStripMenuItem";
            this.mostrarCuantasReservacionesSeHanHechoParaUnDíaDeterminadoToolStripMenuItem.Size = new System.Drawing.Size(695, 22);
            this.mostrarCuantasReservacionesSeHanHechoParaUnDíaDeterminadoToolStripMenuItem.Text = "Mostrar cuantas reservaciones se han hecho para un día determinado ";
            // 
            // mostrarCuántoDineroSeHaGeneradoPorLaVentaDeTiquetesEnUnDíaToolStripMenuItem
            // 
            this.mostrarCuántoDineroSeHaGeneradoPorLaVentaDeTiquetesEnUnDíaToolStripMenuItem.Name = "mostrarCuántoDineroSeHaGeneradoPorLaVentaDeTiquetesEnUnDíaToolStripMenuItem";
            this.mostrarCuántoDineroSeHaGeneradoPorLaVentaDeTiquetesEnUnDíaToolStripMenuItem.Size = new System.Drawing.Size(695, 22);
            this.mostrarCuántoDineroSeHaGeneradoPorLaVentaDeTiquetesEnUnDíaToolStripMenuItem.Text = "Mostrar cuánto dinero se ha generado por la venta de tiquetes en un día ";
            // 
            // mostarLasUnidadesQueTienenElPermisoDeTransitarVigenteToolStripMenuItem
            // 
            this.mostarLasUnidadesQueTienenElPermisoDeTransitarVigenteToolStripMenuItem.Name = "mostarLasUnidadesQueTienenElPermisoDeTransitarVigenteToolStripMenuItem";
            this.mostarLasUnidadesQueTienenElPermisoDeTransitarVigenteToolStripMenuItem.Size = new System.Drawing.Size(695, 22);
            this.mostarLasUnidadesQueTienenElPermisoDeTransitarVigenteToolStripMenuItem.Text = "Mostar las unidades que tienen el permiso de transitar vigente";
            // 
            // mostrarLasUnidadesQueNoTienenPermisoDeTransitarYCuandoSeToolStripMenuItem
            // 
            this.mostrarLasUnidadesQueNoTienenPermisoDeTransitarYCuandoSeToolStripMenuItem.Name = "mostrarLasUnidadesQueNoTienenPermisoDeTransitarYCuandoSeToolStripMenuItem";
            this.mostrarLasUnidadesQueNoTienenPermisoDeTransitarYCuandoSeToolStripMenuItem.Size = new System.Drawing.Size(695, 22);
            this.mostrarLasUnidadesQueNoTienenPermisoDeTransitarYCuandoSeToolStripMenuItem.Text = "Mostrar las unidades que no tienen permiso de transitar y cuando se venció el per" +
    "miso";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Image = global::ProyectoII_Tiquete_bus.Properties.Resources.Captura_de_pantalla_2022_03_25_140036;
            this.label1.Location = new System.Drawing.Point(140, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(449, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Software para Venta Tiquetes Autobuses";
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoII_Tiquete_bus.Properties.Resources.Captura_de_pantalla_2022_03_25_140036;
            this.ClientSize = new System.Drawing.Size(743, 402);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcionesstp;
        private System.Windows.Forms.ToolStripMenuItem registrarUsuariosTS1;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crudsstp;
        private System.Windows.Forms.ToolStripMenuItem terminalstp;
        private System.Windows.Forms.ToolStripMenuItem horariosstp;
        private System.Windows.Forms.ToolStripMenuItem rutasstp;
        private System.Windows.Forms.ToolStripMenuItem unidadesstp;
        private System.Windows.Forms.ToolStripMenuItem tiquetesstp;
        private System.Windows.Forms.ToolStripMenuItem encomiendasstp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem reportesstp;
        private System.Windows.Forms.ToolStripMenuItem laCantidadDeTiquetesVendidoPorRutasPorDíaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cualEsLaRutaQueMásTiquetesVendePorMesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cualEsLaRutaEnLaQueSeEnvíaMásEncomiendasPorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarEnQueMesSeRegistranMásSalidasHaciaPanamáToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarCuantasReservacionesSeHanHechoParaUnDíaDeterminadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarCuántoDineroSeHaGeneradoPorLaVentaDeTiquetesEnUnDíaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostarLasUnidadesQueTienenElPermisoDeTransitarVigenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarLasUnidadesQueNoTienenPermisoDeTransitarYCuandoSeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventaNacionalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventaInternacionalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem corteCajaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cierreCajaToolStripMenuItem;
    }
}