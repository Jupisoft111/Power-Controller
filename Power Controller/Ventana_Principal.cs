using Power_Controller.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Power_Controller
{
    public partial class Ventana_Principal : Form
    {
        public Ventana_Principal()
        {
            InitializeComponent();
        }

        internal readonly string Texto_Título = "Power Controller by Jupisoft for " + Program.Texto_Usuario;
        internal bool Variable_Excepción = false;
        internal bool Variable_Excepción_Imagen = false;
        internal int Variable_Excepción_Total = 0;
        //internal bool Variable_Memoria = false;
        //internal static Stopwatch FPS_Cronómetro = Stopwatch.StartNew();
        //internal long FPS_Segundo_Anterior = 0L;
        //internal long FPS_Temporal = 0L;
        //internal long FPS_Real = 0L;
        /// <summary>
        /// Variable that if it's true will always show the main window on top of others.
        /// </summary>
        internal static bool Variable_Siempre_Visible = false;
        internal static readonly string Ruta_Explorador_Windows = Environment.GetFolderPath(Environment.SpecialFolder.Windows) + "\\explorer.exe";

        private void Ventana_Principal_Load(object sender, EventArgs e)
        {
            try
            {
                if (Program.Icono_Jupisoft == null) Program.Icono_Jupisoft = this.Icon.Clone() as Icon;
                this.Text = Texto_Título;
                Menú_Contextual_Acerca.Text = "About " + Program.Texto_Programa + " " + Program.Texto_Versión + "...";

                bool Valor_Hibernar = PInvoke.Powrprof.IsPwrHibernateAllowed();
                Botón_Hibernar.Enabled = Valor_Hibernar;
                Botón_Hibernar_Forzado.Enabled = Valor_Hibernar;

                bool Valor_Suspender = PInvoke.Powrprof.IsPwrSuspendAllowed();
                Botón_Suspender.Enabled = Valor_Suspender;
                Botón_Suspender_Forzado.Enabled = Valor_Suspender;

                bool Valor_Apagar = PInvoke.Powrprof.IsPwrShutdownAllowed();
                Botón_Reiniciar.Enabled = Valor_Apagar;
                Botón_Apagar.Enabled = Valor_Apagar;
                Botón_Reiniciar_Forzado.Enabled = Valor_Apagar;
                Botón_Apagar_Forzado.Enabled = Valor_Apagar;
            }
            catch (Exception Excepción) { Depurador.Escribir_Excepción(Excepción != null ? Excepción.ToString() : null); Variable_Excepción_Total++; Variable_Excepción = true; }
        }

        private void Ventana_Principal_Shown(object sender, EventArgs e)
        {
            try
            {
                this.Activate();
            }
            catch (Exception Excepción) { Depurador.Escribir_Excepción(Excepción != null ? Excepción.ToString() : null); Variable_Excepción_Total++; Variable_Excepción = true; }
        }

        private void Ventana_Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {

            }
            catch (Exception Excepción) { Depurador.Escribir_Excepción(Excepción != null ? Excepción.ToString() : null); Variable_Excepción_Total++; Variable_Excepción = true; }
        }

        private void Ventana_Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {

            }
            catch (Exception Excepción) { Depurador.Escribir_Excepción(Excepción != null ? Excepción.ToString() : null); Variable_Excepción_Total++; Variable_Excepción = true; }
        }

        private void Ventana_Principal_SizeChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.WindowState == FormWindowState.Maximized) this.WindowState = FormWindowState.Normal;
            }
            catch (Exception Excepción) { Depurador.Escribir_Excepción(Excepción != null ? Excepción.ToString() : null); Variable_Excepción_Total++; Variable_Excepción = true; }
        }

        private void Ventana_Principal_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (!e.Alt && !e.Control && !e.Shift)
                {
                    if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Delete)
                    {
                        e.Handled = true;
                        e.SuppressKeyPress = true;
                        this.Close();
                    }
                }
            }
            catch (Exception Excepción) { Depurador.Escribir_Excepción(Excepción != null ? Excepción.ToString() : null); Variable_Excepción_Total++; Variable_Excepción = true; }
        }

        internal void Reiniciar_Explorador(bool Forzar)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                Process[] Matriz_Procesos = Process.GetProcesses();
                if (Matriz_Procesos != null && Matriz_Procesos.Length > 0)
                {
                    foreach (Process Proceso in Matriz_Procesos)
                    {
                        try
                        {
                            if (Proceso != null)
                            {
                                // This should be a Windows explorer process.
                                if (string.Compare(Path.GetFullPath(Proceso.MainModule.FileName), Ruta_Explorador_Windows, true) == 0)
                                {
                                    // Close or kill the current Windows explorer process.
                                    if (!Forzar)
                                    {
                                        Proceso.CloseMainWindow(); // Try to close the process.
                                        Proceso.WaitForExit(5000); // Wait 5 seconds for it to close.
                                    }
                                    if (!Proceso.HasExited) // Still didn't close.
                                    {
                                        Proceso.Kill(); // Force the termination of the process.
                                    }
                                    // Restart the Windows explorer in a new process.
                                    Program.Ejecutar_Ruta(Ruta_Explorador_Windows, ProcessWindowStyle.Normal);
                                }
                            }
                        }
                        catch (Exception Excepción) { Depurador.Escribir_Excepción(Excepción != null ? Excepción.ToString() : null); Variable_Excepción_Total++; Variable_Excepción = true; continue; }
                    }
                    Matriz_Procesos = null;
                }
            }
            catch (Exception Excepción) { Depurador.Escribir_Excepción(Excepción != null ? Excepción.ToString() : null); Variable_Excepción_Total++; Variable_Excepción = true; }
            finally { this.Cursor = Cursors.Default; }
        }

        private void Botón_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception Excepción) { Depurador.Escribir_Excepción(Excepción != null ? Excepción.ToString() : null); Variable_Excepción_Total++; Variable_Excepción = true; }
        }

        private void Botón_Reiniciar_Explorador_Click(object sender, EventArgs e)
        {
            try
            {
                Reiniciar_Explorador(false);
            }
            catch (Exception Excepción) { Depurador.Escribir_Excepción(Excepción != null ? Excepción.ToString() : null); Variable_Excepción_Total++; Variable_Excepción = true; }
        }

        private void Botón_Cambiar_Usuario_Click(object sender, EventArgs e)
        {
            try
            {
                PInvoke.User32.LockWorkStation();
            }
            catch (Exception Excepción) { Depurador.Escribir_Excepción(Excepción != null ? Excepción.ToString() : null); Variable_Excepción_Total++; Variable_Excepción = true; }
        }

        private void Botón_Cerrar_Sesión_Click(object sender, EventArgs e)
        {
            try
            {
                PInvoke.User32.ExitWindowsEx(PInvoke.User32.ExitWindows_Flags.LogOff, 1);
            }
            catch (Exception Excepción) { Depurador.Escribir_Excepción(Excepción != null ? Excepción.ToString() : null); Variable_Excepción_Total++; Variable_Excepción = true; }
        }

        private void Botón_Suspender_Click(object sender, EventArgs e)
        {
            try
            {
                Application.SetSuspendState(PowerState.Suspend, true, false);
            }
            catch (Exception Excepción) { Depurador.Escribir_Excepción(Excepción != null ? Excepción.ToString() : null); Variable_Excepción_Total++; Variable_Excepción = true; }
        }

        private void Botón_Hibernar_Click(object sender, EventArgs e)
        {
            try
            {
                Application.SetSuspendState(PowerState.Hibernate, true, false);
            }
            catch (Exception Excepción) { Depurador.Escribir_Excepción(Excepción != null ? Excepción.ToString() : null); Variable_Excepción_Total++; Variable_Excepción = true; }
        }

        private void Botón_Reiniciar_Click(object sender, EventArgs e)
        {
            try
            {
                PInvoke.User32.ExitWindowsEx(PInvoke.User32.ExitWindows_Flags.Reboot, 1);
            }
            catch (Exception Excepción) { Depurador.Escribir_Excepción(Excepción != null ? Excepción.ToString() : null); Variable_Excepción_Total++; Variable_Excepción = true; }
        }

        private void Botón_Apagar_Click(object sender, EventArgs e)
        {
            try
            {
                PInvoke.User32.ExitWindowsEx(PInvoke.User32.ExitWindows_Flags.Shutdown, 1);
            }
            catch (Exception Excepción) { Depurador.Escribir_Excepción(Excepción != null ? Excepción.ToString() : null); Variable_Excepción_Total++; Variable_Excepción = true; }
        }

        private void Botón_Reiniciar_Explorador_Forzado_Click(object sender, EventArgs e)
        {
            try
            {
                Reiniciar_Explorador(true);
            }
            catch (Exception Excepción) { Depurador.Escribir_Excepción(Excepción != null ? Excepción.ToString() : null); Variable_Excepción_Total++; Variable_Excepción = true; }
        }

        private void Botón_Cambiar_Usuario_Forzado_Click(object sender, EventArgs e)
        {
            try
            {
                PInvoke.User32.LockWorkStation();
            }
            catch (Exception Excepción) { Depurador.Escribir_Excepción(Excepción != null ? Excepción.ToString() : null); Variable_Excepción_Total++; Variable_Excepción = true; }
        }

        private void Botón_Cerrar_Sesión_Forzado_Click(object sender, EventArgs e)
        {
            try
            {
                PInvoke.User32.ExitWindowsEx(PInvoke.User32.ExitWindows_Flags.LogOff | PInvoke.User32.ExitWindows_Flags.Force, 1);
            }
            catch (Exception Excepción) { Depurador.Escribir_Excepción(Excepción != null ? Excepción.ToString() : null); Variable_Excepción_Total++; Variable_Excepción = true; }
        }

        private void Botón_Suspender_Forzado_Click(object sender, EventArgs e)
        {
            try
            {
                Application.SetSuspendState(PowerState.Suspend, true, false);
            }
            catch (Exception Excepción) { Depurador.Escribir_Excepción(Excepción != null ? Excepción.ToString() : null); Variable_Excepción_Total++; Variable_Excepción = true; }
        }

        private void Botón_Hibernar_Forzado_Click(object sender, EventArgs e)
        {
            try
            {
                Application.SetSuspendState(PowerState.Hibernate, true, false);
            }
            catch (Exception Excepción) { Depurador.Escribir_Excepción(Excepción != null ? Excepción.ToString() : null); Variable_Excepción_Total++; Variable_Excepción = true; }
        }

        private void Botón_Reiniciar_Forzado_Click(object sender, EventArgs e)
        {
            try
            {
                PInvoke.User32.ExitWindowsEx(PInvoke.User32.ExitWindows_Flags.Reboot | PInvoke.User32.ExitWindows_Flags.Force, 1);
            }
            catch (Exception Excepción) { Depurador.Escribir_Excepción(Excepción != null ? Excepción.ToString() : null); Variable_Excepción_Total++; Variable_Excepción = true; }
        }

        private void Botón_Apagar_Forzado_Click(object sender, EventArgs e)
        {
            try
            {
                PInvoke.User32.ExitWindowsEx(PInvoke.User32.ExitWindows_Flags.Shutdown | PInvoke.User32.ExitWindows_Flags.Force, 1);
            }
            catch (Exception Excepción) { Depurador.Escribir_Excepción(Excepción != null ? Excepción.ToString() : null); Variable_Excepción_Total++; Variable_Excepción = true; }
        }

        private void Menú_Contextual_Opening(object sender, CancelEventArgs e)
        {
            try
            {
                Menú_Contextual_Depurador_Excepciones.Text = "Exception debugger - [" + Program.Traducir_Número(Variable_Excepción_Total) + (Variable_Excepción_Total != 1 ? " exceptions" : " exception") + "]...";
            }
            catch (Exception Excepción) { Depurador.Escribir_Excepción(Excepción != null ? Excepción.ToString() : null); Variable_Excepción_Total++; Variable_Excepción = true; }
        }

        private void Menú_Contextual_Donar_Click(object sender, EventArgs e)
        {
            try
            {
                Program.Ejecutar_Ruta("https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=KSMZ3XNG2R9P6", ProcessWindowStyle.Normal);
            }
            catch (Exception Excepción) { Depurador.Escribir_Excepción(Excepción != null ? Excepción.ToString() : null); Variable_Excepción_Total++; Variable_Excepción = true; }
        }

        private void Menú_Contextual_Visor_Ayuda_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(this, "Sometimes Windows 10 (and other versions) take too much time to shutdown, sometimes more than half an hour, so this application was born to try to force it's shutdown, specially useful if you're in a hurry and can't wait for your PC to fully shutdown.\r\n\r\nThis application uses some Windows internal functions (that at least come from Windows XP), that can force the system shutdown, so be sure to save all your work before using this tool or it might be lost forever!", Program.Texto_Título_Versión, MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            catch (Exception Excepción) { Depurador.Escribir_Excepción(Excepción != null ? Excepción.ToString() : null); Variable_Excepción_Total++; Variable_Excepción = true; }
        }

        private void Menú_Contextual_Acerca_Click(object sender, EventArgs e)
        {
            try
            {
                Ventana_Acerca Ventana = new Ventana_Acerca();
                Ventana.ShowDialog(this);
                Ventana.Dispose();
                Ventana = null;
            }
            catch (Exception Excepción) { Depurador.Escribir_Excepción(Excepción != null ? Excepción.ToString() : null); Variable_Excepción_Total++; Variable_Excepción = true; }
        }

        private void Menú_Contextual_Depurador_Excepciones_Click(object sender, EventArgs e)
        {
            try
            {
                Variable_Excepción = false;
                Variable_Excepción_Imagen = false;
                Variable_Excepción_Total = 0;
                //Barra_Estado_Botón_Excepción.Visible = false;
                //Barra_Estado_Separador_1.Visible = false;
                //Barra_Estado_Botón_Excepción.Image = Resources.Excepción_Gris;
                //Barra_Estado_Botón_Excepción.ForeColor = Color.Black;
                //Barra_Estado_Botón_Excepción.Text = "Exceptions: 0";
                Ventana_Depurador_Excepciones Ventana = new Ventana_Depurador_Excepciones();
                Ventana.ShowDialog(this);
                Ventana.Dispose();
                Ventana = null;
            }
            catch (Exception Excepción) { Depurador.Escribir_Excepción(Excepción != null ? Excepción.ToString() : null); Variable_Excepción_Total++; Variable_Excepción = true; }
        }

        private void Menú_Contextual_Siempre_Visible_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                Variable_Siempre_Visible = Menú_Contextual_Siempre_Visible.Checked;
                this.TopMost = Variable_Siempre_Visible;
            }
            catch (Exception Excepción) { Depurador.Escribir_Excepción(Excepción != null ? Excepción.ToString() : null); Variable_Excepción_Total++; Variable_Excepción = true; }
        }

        private void Menú_Contextual_Actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Refresh();
            }
            catch (Exception Excepción) { Depurador.Escribir_Excepción(Excepción != null ? Excepción.ToString() : null); Variable_Excepción_Total++; Variable_Excepción = true; }
        }
    }
}
