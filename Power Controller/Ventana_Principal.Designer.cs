namespace Power_Controller
{
    partial class Ventana_Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventana_Principal));
            this.Grupo_Opciones = new System.Windows.Forms.GroupBox();
            this.Botón_Apagar = new System.Windows.Forms.Button();
            this.Botón_Reiniciar = new System.Windows.Forms.Button();
            this.Botón_Suspender = new System.Windows.Forms.Button();
            this.Botón_Hibernar = new System.Windows.Forms.Button();
            this.Botón_Cerrar_Sesión = new System.Windows.Forms.Button();
            this.Botón_Cambiar_Usuario = new System.Windows.Forms.Button();
            this.Botón_Reiniciar_Explorador = new System.Windows.Forms.Button();
            this.Grupo_Opciones_Forzadas = new System.Windows.Forms.GroupBox();
            this.Botón_Apagar_Forzado = new System.Windows.Forms.Button();
            this.Botón_Reiniciar_Forzado = new System.Windows.Forms.Button();
            this.Botón_Suspender_Forzado = new System.Windows.Forms.Button();
            this.Botón_Hibernar_Forzado = new System.Windows.Forms.Button();
            this.Botón_Cerrar_Sesión_Forzado = new System.Windows.Forms.Button();
            this.Botón_Cambiar_Usuario_Forzado = new System.Windows.Forms.Button();
            this.Botón_Reiniciar_Explorador_Forzado = new System.Windows.Forms.Button();
            this.Menú_Contextual = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Menú_Contextual_Donar = new System.Windows.Forms.ToolStripMenuItem();
            this.Menú_Contextual_Separador_1 = new System.Windows.Forms.ToolStripSeparator();
            this.Menú_Contextual_Visor_Ayuda = new System.Windows.Forms.ToolStripMenuItem();
            this.Menú_Contextual_Acerca = new System.Windows.Forms.ToolStripMenuItem();
            this.Menú_Contextual_Depurador_Excepciones = new System.Windows.Forms.ToolStripMenuItem();
            this.Menú_Contextual_Siempre_Visible = new System.Windows.Forms.ToolStripMenuItem();
            this.Menú_Contextual_Separador_2 = new System.Windows.Forms.ToolStripSeparator();
            this.Menú_Contextual_Actualizar = new System.Windows.Forms.ToolStripMenuItem();
            this.Grupo_Salir = new System.Windows.Forms.GroupBox();
            this.Botón_Salir = new System.Windows.Forms.Button();
            this.Grupo_Opciones.SuspendLayout();
            this.Grupo_Opciones_Forzadas.SuspendLayout();
            this.Menú_Contextual.SuspendLayout();
            this.Grupo_Salir.SuspendLayout();
            this.SuspendLayout();
            // 
            // Grupo_Opciones
            // 
            this.Grupo_Opciones.Controls.Add(this.Botón_Apagar);
            this.Grupo_Opciones.Controls.Add(this.Botón_Reiniciar);
            this.Grupo_Opciones.Controls.Add(this.Botón_Suspender);
            this.Grupo_Opciones.Controls.Add(this.Botón_Hibernar);
            this.Grupo_Opciones.Controls.Add(this.Botón_Cerrar_Sesión);
            this.Grupo_Opciones.Controls.Add(this.Botón_Cambiar_Usuario);
            this.Grupo_Opciones.Controls.Add(this.Botón_Reiniciar_Explorador);
            this.Grupo_Opciones.Location = new System.Drawing.Point(12, 60);
            this.Grupo_Opciones.Name = "Grupo_Opciones";
            this.Grupo_Opciones.Size = new System.Drawing.Size(162, 201);
            this.Grupo_Opciones.TabIndex = 1;
            this.Grupo_Opciones.TabStop = false;
            this.Grupo_Opciones.Text = "Default power options";
            // 
            // Botón_Apagar
            // 
            this.Botón_Apagar.Image = global::Power_Controller.Properties.Resources.Windows_Apagar;
            this.Botón_Apagar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Botón_Apagar.Location = new System.Drawing.Point(6, 173);
            this.Botón_Apagar.Name = "Botón_Apagar";
            this.Botón_Apagar.Size = new System.Drawing.Size(150, 24);
            this.Botón_Apagar.TabIndex = 6;
            this.Botón_Apagar.Text = " Shutdown ";
            this.Botón_Apagar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Botón_Apagar.UseVisualStyleBackColor = true;
            this.Botón_Apagar.Click += new System.EventHandler(this.Botón_Apagar_Click);
            // 
            // Botón_Reiniciar
            // 
            this.Botón_Reiniciar.Image = global::Power_Controller.Properties.Resources.Windows_Reiniciar;
            this.Botón_Reiniciar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Botón_Reiniciar.Location = new System.Drawing.Point(6, 147);
            this.Botón_Reiniciar.Name = "Botón_Reiniciar";
            this.Botón_Reiniciar.Size = new System.Drawing.Size(150, 24);
            this.Botón_Reiniciar.TabIndex = 5;
            this.Botón_Reiniciar.Text = " Reboot ";
            this.Botón_Reiniciar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Botón_Reiniciar.UseVisualStyleBackColor = true;
            this.Botón_Reiniciar.Click += new System.EventHandler(this.Botón_Reiniciar_Click);
            // 
            // Botón_Suspender
            // 
            this.Botón_Suspender.Image = global::Power_Controller.Properties.Resources.Windows_Suspender;
            this.Botón_Suspender.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Botón_Suspender.Location = new System.Drawing.Point(6, 95);
            this.Botón_Suspender.Name = "Botón_Suspender";
            this.Botón_Suspender.Size = new System.Drawing.Size(150, 24);
            this.Botón_Suspender.TabIndex = 3;
            this.Botón_Suspender.Text = " Suspend ";
            this.Botón_Suspender.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Botón_Suspender.UseVisualStyleBackColor = true;
            this.Botón_Suspender.Click += new System.EventHandler(this.Botón_Suspender_Click);
            // 
            // Botón_Hibernar
            // 
            this.Botón_Hibernar.Image = global::Power_Controller.Properties.Resources.Windows_Hibernar;
            this.Botón_Hibernar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Botón_Hibernar.Location = new System.Drawing.Point(6, 121);
            this.Botón_Hibernar.Name = "Botón_Hibernar";
            this.Botón_Hibernar.Size = new System.Drawing.Size(150, 24);
            this.Botón_Hibernar.TabIndex = 4;
            this.Botón_Hibernar.Text = " Hibernate ";
            this.Botón_Hibernar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Botón_Hibernar.UseVisualStyleBackColor = true;
            this.Botón_Hibernar.Click += new System.EventHandler(this.Botón_Hibernar_Click);
            // 
            // Botón_Cerrar_Sesión
            // 
            this.Botón_Cerrar_Sesión.Image = global::Power_Controller.Properties.Resources.Windows_Cerrar_Sesión;
            this.Botón_Cerrar_Sesión.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Botón_Cerrar_Sesión.Location = new System.Drawing.Point(6, 69);
            this.Botón_Cerrar_Sesión.Name = "Botón_Cerrar_Sesión";
            this.Botón_Cerrar_Sesión.Size = new System.Drawing.Size(150, 24);
            this.Botón_Cerrar_Sesión.TabIndex = 2;
            this.Botón_Cerrar_Sesión.Text = " Close session ";
            this.Botón_Cerrar_Sesión.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Botón_Cerrar_Sesión.UseVisualStyleBackColor = true;
            this.Botón_Cerrar_Sesión.Click += new System.EventHandler(this.Botón_Cerrar_Sesión_Click);
            // 
            // Botón_Cambiar_Usuario
            // 
            this.Botón_Cambiar_Usuario.Image = global::Power_Controller.Properties.Resources.Windows_Cambiar_Usuario;
            this.Botón_Cambiar_Usuario.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Botón_Cambiar_Usuario.Location = new System.Drawing.Point(6, 43);
            this.Botón_Cambiar_Usuario.Name = "Botón_Cambiar_Usuario";
            this.Botón_Cambiar_Usuario.Size = new System.Drawing.Size(150, 24);
            this.Botón_Cambiar_Usuario.TabIndex = 1;
            this.Botón_Cambiar_Usuario.Text = " Change user ";
            this.Botón_Cambiar_Usuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Botón_Cambiar_Usuario.UseVisualStyleBackColor = true;
            this.Botón_Cambiar_Usuario.Click += new System.EventHandler(this.Botón_Cambiar_Usuario_Click);
            // 
            // Botón_Reiniciar_Explorador
            // 
            this.Botón_Reiniciar_Explorador.Image = global::Power_Controller.Properties.Resources.Windows_Explorador;
            this.Botón_Reiniciar_Explorador.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Botón_Reiniciar_Explorador.Location = new System.Drawing.Point(6, 17);
            this.Botón_Reiniciar_Explorador.Name = "Botón_Reiniciar_Explorador";
            this.Botón_Reiniciar_Explorador.Size = new System.Drawing.Size(150, 24);
            this.Botón_Reiniciar_Explorador.TabIndex = 0;
            this.Botón_Reiniciar_Explorador.Text = " Restart explorer ";
            this.Botón_Reiniciar_Explorador.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Botón_Reiniciar_Explorador.UseVisualStyleBackColor = true;
            this.Botón_Reiniciar_Explorador.Click += new System.EventHandler(this.Botón_Reiniciar_Explorador_Click);
            // 
            // Grupo_Opciones_Forzadas
            // 
            this.Grupo_Opciones_Forzadas.Controls.Add(this.Botón_Apagar_Forzado);
            this.Grupo_Opciones_Forzadas.Controls.Add(this.Botón_Reiniciar_Forzado);
            this.Grupo_Opciones_Forzadas.Controls.Add(this.Botón_Suspender_Forzado);
            this.Grupo_Opciones_Forzadas.Controls.Add(this.Botón_Hibernar_Forzado);
            this.Grupo_Opciones_Forzadas.Controls.Add(this.Botón_Cerrar_Sesión_Forzado);
            this.Grupo_Opciones_Forzadas.Controls.Add(this.Botón_Cambiar_Usuario_Forzado);
            this.Grupo_Opciones_Forzadas.Controls.Add(this.Botón_Reiniciar_Explorador_Forzado);
            this.Grupo_Opciones_Forzadas.Location = new System.Drawing.Point(180, 60);
            this.Grupo_Opciones_Forzadas.Name = "Grupo_Opciones_Forzadas";
            this.Grupo_Opciones_Forzadas.Size = new System.Drawing.Size(162, 201);
            this.Grupo_Opciones_Forzadas.TabIndex = 2;
            this.Grupo_Opciones_Forzadas.TabStop = false;
            this.Grupo_Opciones_Forzadas.Text = "Forced power options";
            // 
            // Botón_Apagar_Forzado
            // 
            this.Botón_Apagar_Forzado.Image = global::Power_Controller.Properties.Resources.Windows_Apagar;
            this.Botón_Apagar_Forzado.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Botón_Apagar_Forzado.Location = new System.Drawing.Point(6, 173);
            this.Botón_Apagar_Forzado.Name = "Botón_Apagar_Forzado";
            this.Botón_Apagar_Forzado.Size = new System.Drawing.Size(150, 24);
            this.Botón_Apagar_Forzado.TabIndex = 6;
            this.Botón_Apagar_Forzado.Text = " Shutdown ";
            this.Botón_Apagar_Forzado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Botón_Apagar_Forzado.UseVisualStyleBackColor = true;
            this.Botón_Apagar_Forzado.Click += new System.EventHandler(this.Botón_Apagar_Forzado_Click);
            // 
            // Botón_Reiniciar_Forzado
            // 
            this.Botón_Reiniciar_Forzado.Image = global::Power_Controller.Properties.Resources.Windows_Reiniciar;
            this.Botón_Reiniciar_Forzado.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Botón_Reiniciar_Forzado.Location = new System.Drawing.Point(6, 147);
            this.Botón_Reiniciar_Forzado.Name = "Botón_Reiniciar_Forzado";
            this.Botón_Reiniciar_Forzado.Size = new System.Drawing.Size(150, 24);
            this.Botón_Reiniciar_Forzado.TabIndex = 5;
            this.Botón_Reiniciar_Forzado.Text = " Reboot ";
            this.Botón_Reiniciar_Forzado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Botón_Reiniciar_Forzado.UseVisualStyleBackColor = true;
            this.Botón_Reiniciar_Forzado.Click += new System.EventHandler(this.Botón_Reiniciar_Forzado_Click);
            // 
            // Botón_Suspender_Forzado
            // 
            this.Botón_Suspender_Forzado.Image = global::Power_Controller.Properties.Resources.Windows_Suspender;
            this.Botón_Suspender_Forzado.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Botón_Suspender_Forzado.Location = new System.Drawing.Point(6, 95);
            this.Botón_Suspender_Forzado.Name = "Botón_Suspender_Forzado";
            this.Botón_Suspender_Forzado.Size = new System.Drawing.Size(150, 24);
            this.Botón_Suspender_Forzado.TabIndex = 3;
            this.Botón_Suspender_Forzado.Text = " Suspend ";
            this.Botón_Suspender_Forzado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Botón_Suspender_Forzado.UseVisualStyleBackColor = true;
            this.Botón_Suspender_Forzado.Click += new System.EventHandler(this.Botón_Suspender_Forzado_Click);
            // 
            // Botón_Hibernar_Forzado
            // 
            this.Botón_Hibernar_Forzado.Image = global::Power_Controller.Properties.Resources.Windows_Hibernar;
            this.Botón_Hibernar_Forzado.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Botón_Hibernar_Forzado.Location = new System.Drawing.Point(6, 121);
            this.Botón_Hibernar_Forzado.Name = "Botón_Hibernar_Forzado";
            this.Botón_Hibernar_Forzado.Size = new System.Drawing.Size(150, 24);
            this.Botón_Hibernar_Forzado.TabIndex = 4;
            this.Botón_Hibernar_Forzado.Text = " Hibernate ";
            this.Botón_Hibernar_Forzado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Botón_Hibernar_Forzado.UseVisualStyleBackColor = true;
            this.Botón_Hibernar_Forzado.Click += new System.EventHandler(this.Botón_Hibernar_Forzado_Click);
            // 
            // Botón_Cerrar_Sesión_Forzado
            // 
            this.Botón_Cerrar_Sesión_Forzado.Image = global::Power_Controller.Properties.Resources.Windows_Cerrar_Sesión;
            this.Botón_Cerrar_Sesión_Forzado.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Botón_Cerrar_Sesión_Forzado.Location = new System.Drawing.Point(6, 69);
            this.Botón_Cerrar_Sesión_Forzado.Name = "Botón_Cerrar_Sesión_Forzado";
            this.Botón_Cerrar_Sesión_Forzado.Size = new System.Drawing.Size(150, 24);
            this.Botón_Cerrar_Sesión_Forzado.TabIndex = 2;
            this.Botón_Cerrar_Sesión_Forzado.Text = " Close session ";
            this.Botón_Cerrar_Sesión_Forzado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Botón_Cerrar_Sesión_Forzado.UseVisualStyleBackColor = true;
            this.Botón_Cerrar_Sesión_Forzado.Click += new System.EventHandler(this.Botón_Cerrar_Sesión_Forzado_Click);
            // 
            // Botón_Cambiar_Usuario_Forzado
            // 
            this.Botón_Cambiar_Usuario_Forzado.Image = global::Power_Controller.Properties.Resources.Windows_Cambiar_Usuario;
            this.Botón_Cambiar_Usuario_Forzado.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Botón_Cambiar_Usuario_Forzado.Location = new System.Drawing.Point(6, 43);
            this.Botón_Cambiar_Usuario_Forzado.Name = "Botón_Cambiar_Usuario_Forzado";
            this.Botón_Cambiar_Usuario_Forzado.Size = new System.Drawing.Size(150, 24);
            this.Botón_Cambiar_Usuario_Forzado.TabIndex = 1;
            this.Botón_Cambiar_Usuario_Forzado.Text = " Change user ";
            this.Botón_Cambiar_Usuario_Forzado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Botón_Cambiar_Usuario_Forzado.UseVisualStyleBackColor = true;
            this.Botón_Cambiar_Usuario_Forzado.Click += new System.EventHandler(this.Botón_Cambiar_Usuario_Forzado_Click);
            // 
            // Botón_Reiniciar_Explorador_Forzado
            // 
            this.Botón_Reiniciar_Explorador_Forzado.Image = global::Power_Controller.Properties.Resources.Windows_Explorador;
            this.Botón_Reiniciar_Explorador_Forzado.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Botón_Reiniciar_Explorador_Forzado.Location = new System.Drawing.Point(6, 17);
            this.Botón_Reiniciar_Explorador_Forzado.Name = "Botón_Reiniciar_Explorador_Forzado";
            this.Botón_Reiniciar_Explorador_Forzado.Size = new System.Drawing.Size(150, 24);
            this.Botón_Reiniciar_Explorador_Forzado.TabIndex = 0;
            this.Botón_Reiniciar_Explorador_Forzado.Text = " Restart explorer ";
            this.Botón_Reiniciar_Explorador_Forzado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Botón_Reiniciar_Explorador_Forzado.UseVisualStyleBackColor = true;
            this.Botón_Reiniciar_Explorador_Forzado.Click += new System.EventHandler(this.Botón_Reiniciar_Explorador_Forzado_Click);
            // 
            // Menú_Contextual
            // 
            this.Menú_Contextual.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menú_Contextual_Donar,
            this.Menú_Contextual_Separador_1,
            this.Menú_Contextual_Visor_Ayuda,
            this.Menú_Contextual_Acerca,
            this.Menú_Contextual_Depurador_Excepciones,
            this.Menú_Contextual_Siempre_Visible,
            this.Menú_Contextual_Separador_2,
            this.Menú_Contextual_Actualizar});
            this.Menú_Contextual.Name = "Menú_Contextual";
            this.Menú_Contextual.Size = new System.Drawing.Size(268, 170);
            this.Menú_Contextual.Opening += new System.ComponentModel.CancelEventHandler(this.Menú_Contextual_Opening);
            // 
            // Menú_Contextual_Donar
            // 
            this.Menú_Contextual_Donar.Image = global::Power_Controller.Properties.Resources.Donar;
            this.Menú_Contextual_Donar.Name = "Menú_Contextual_Donar";
            this.Menú_Contextual_Donar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.Menú_Contextual_Donar.Size = new System.Drawing.Size(267, 22);
            this.Menú_Contextual_Donar.Text = "Donate to Jupisoft (PayPal)...";
            this.Menú_Contextual_Donar.Click += new System.EventHandler(this.Menú_Contextual_Donar_Click);
            // 
            // Menú_Contextual_Separador_1
            // 
            this.Menú_Contextual_Separador_1.Name = "Menú_Contextual_Separador_1";
            this.Menú_Contextual_Separador_1.Size = new System.Drawing.Size(264, 6);
            // 
            // Menú_Contextual_Visor_Ayuda
            // 
            this.Menú_Contextual_Visor_Ayuda.Image = global::Power_Controller.Properties.Resources.Ayuda;
            this.Menú_Contextual_Visor_Ayuda.Name = "Menú_Contextual_Visor_Ayuda";
            this.Menú_Contextual_Visor_Ayuda.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.Menú_Contextual_Visor_Ayuda.Size = new System.Drawing.Size(267, 22);
            this.Menú_Contextual_Visor_Ayuda.Text = "Help viewer...";
            this.Menú_Contextual_Visor_Ayuda.Click += new System.EventHandler(this.Menú_Contextual_Visor_Ayuda_Click);
            // 
            // Menú_Contextual_Acerca
            // 
            this.Menú_Contextual_Acerca.Image = global::Power_Controller.Properties.Resources.Jupisoft_16;
            this.Menú_Contextual_Acerca.Name = "Menú_Contextual_Acerca";
            this.Menú_Contextual_Acerca.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.Menú_Contextual_Acerca.Size = new System.Drawing.Size(267, 22);
            this.Menú_Contextual_Acerca.Text = "About...";
            this.Menú_Contextual_Acerca.Click += new System.EventHandler(this.Menú_Contextual_Acerca_Click);
            // 
            // Menú_Contextual_Depurador_Excepciones
            // 
            this.Menú_Contextual_Depurador_Excepciones.Image = global::Power_Controller.Properties.Resources.Excepción;
            this.Menú_Contextual_Depurador_Excepciones.Name = "Menú_Contextual_Depurador_Excepciones";
            this.Menú_Contextual_Depurador_Excepciones.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.Menú_Contextual_Depurador_Excepciones.Size = new System.Drawing.Size(267, 22);
            this.Menú_Contextual_Depurador_Excepciones.Text = "Exception debugger...";
            this.Menú_Contextual_Depurador_Excepciones.Click += new System.EventHandler(this.Menú_Contextual_Depurador_Excepciones_Click);
            // 
            // Menú_Contextual_Siempre_Visible
            // 
            this.Menú_Contextual_Siempre_Visible.CheckOnClick = true;
            this.Menú_Contextual_Siempre_Visible.Name = "Menú_Contextual_Siempre_Visible";
            this.Menú_Contextual_Siempre_Visible.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.Menú_Contextual_Siempre_Visible.Size = new System.Drawing.Size(267, 22);
            this.Menú_Contextual_Siempre_Visible.Text = "Always on top";
            this.Menú_Contextual_Siempre_Visible.CheckedChanged += new System.EventHandler(this.Menú_Contextual_Siempre_Visible_CheckedChanged);
            // 
            // Menú_Contextual_Separador_2
            // 
            this.Menú_Contextual_Separador_2.Name = "Menú_Contextual_Separador_2";
            this.Menú_Contextual_Separador_2.Size = new System.Drawing.Size(264, 6);
            // 
            // Menú_Contextual_Actualizar
            // 
            this.Menú_Contextual_Actualizar.Image = global::Power_Controller.Properties.Resources.Actualizar;
            this.Menú_Contextual_Actualizar.Name = "Menú_Contextual_Actualizar";
            this.Menú_Contextual_Actualizar.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.Menú_Contextual_Actualizar.Size = new System.Drawing.Size(267, 22);
            this.Menú_Contextual_Actualizar.Text = "Refresh";
            this.Menú_Contextual_Actualizar.Click += new System.EventHandler(this.Menú_Contextual_Actualizar_Click);
            // 
            // Grupo_Salir
            // 
            this.Grupo_Salir.Controls.Add(this.Botón_Salir);
            this.Grupo_Salir.Location = new System.Drawing.Point(12, 9);
            this.Grupo_Salir.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.Grupo_Salir.Name = "Grupo_Salir";
            this.Grupo_Salir.Size = new System.Drawing.Size(330, 45);
            this.Grupo_Salir.TabIndex = 0;
            this.Grupo_Salir.TabStop = false;
            this.Grupo_Salir.Text = "Warning: use all the enabled options below at your own risk!";
            // 
            // Botón_Salir
            // 
            this.Botón_Salir.Image = global::Power_Controller.Properties.Resources.Salir;
            this.Botón_Salir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Botón_Salir.Location = new System.Drawing.Point(6, 17);
            this.Botón_Salir.Name = "Botón_Salir";
            this.Botón_Salir.Size = new System.Drawing.Size(318, 24);
            this.Botón_Salir.TabIndex = 0;
            this.Botón_Salir.Text = " Exit ";
            this.Botón_Salir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Botón_Salir.UseVisualStyleBackColor = true;
            this.Botón_Salir.Click += new System.EventHandler(this.Botón_Salir_Click);
            this.Botón_Salir.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Ventana_Principal_KeyDown);
            // 
            // Ventana_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 273);
            this.ContextMenuStrip = this.Menú_Contextual;
            this.Controls.Add(this.Grupo_Salir);
            this.Controls.Add(this.Grupo_Opciones_Forzadas);
            this.Controls.Add(this.Grupo_Opciones);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ventana_Principal";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Power Controller by Jupisoft";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Ventana_Principal_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Ventana_Principal_FormClosed);
            this.Load += new System.EventHandler(this.Ventana_Principal_Load);
            this.Shown += new System.EventHandler(this.Ventana_Principal_Shown);
            this.SizeChanged += new System.EventHandler(this.Ventana_Principal_SizeChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Ventana_Principal_KeyDown);
            this.Grupo_Opciones.ResumeLayout(false);
            this.Grupo_Opciones_Forzadas.ResumeLayout(false);
            this.Menú_Contextual.ResumeLayout(false);
            this.Grupo_Salir.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox Grupo_Opciones;
        private System.Windows.Forms.Button Botón_Reiniciar_Explorador;
        private System.Windows.Forms.Button Botón_Reiniciar;
        private System.Windows.Forms.Button Botón_Suspender;
        private System.Windows.Forms.Button Botón_Hibernar;
        private System.Windows.Forms.Button Botón_Cerrar_Sesión;
        private System.Windows.Forms.Button Botón_Cambiar_Usuario;
        private System.Windows.Forms.Button Botón_Apagar;
        private System.Windows.Forms.GroupBox Grupo_Opciones_Forzadas;
        private System.Windows.Forms.Button Botón_Apagar_Forzado;
        private System.Windows.Forms.Button Botón_Reiniciar_Forzado;
        private System.Windows.Forms.Button Botón_Suspender_Forzado;
        private System.Windows.Forms.Button Botón_Hibernar_Forzado;
        private System.Windows.Forms.Button Botón_Cerrar_Sesión_Forzado;
        private System.Windows.Forms.Button Botón_Cambiar_Usuario_Forzado;
        private System.Windows.Forms.Button Botón_Reiniciar_Explorador_Forzado;
        private System.Windows.Forms.ContextMenuStrip Menú_Contextual;
        private System.Windows.Forms.ToolStripMenuItem Menú_Contextual_Donar;
        private System.Windows.Forms.ToolStripSeparator Menú_Contextual_Separador_1;
        private System.Windows.Forms.ToolStripSeparator Menú_Contextual_Separador_2;
        private System.Windows.Forms.ToolStripMenuItem Menú_Contextual_Visor_Ayuda;
        private System.Windows.Forms.ToolStripMenuItem Menú_Contextual_Acerca;
        private System.Windows.Forms.ToolStripMenuItem Menú_Contextual_Depurador_Excepciones;
        private System.Windows.Forms.ToolStripMenuItem Menú_Contextual_Siempre_Visible;
        private System.Windows.Forms.ToolStripMenuItem Menú_Contextual_Actualizar;
        private System.Windows.Forms.GroupBox Grupo_Salir;
        private System.Windows.Forms.Button Botón_Salir;
    }
}

