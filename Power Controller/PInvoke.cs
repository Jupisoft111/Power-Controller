using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Power_Controller
{
    internal static class PInvoke
    {
        internal static class Advapi32
        {
            internal const int SE_Privilege_Enabled = 0x00000002;
            internal const int Token_Query = 0x00000008;
            internal const int Token_Adjust_Privileges = 0x00000020;
            internal const string SE_Shutdown_Name = "SeShutdownPrivilege";
            //internal const string SE_TIME_ZONE_NAMETEXT = "SeTimeZonePrivilege";
            //http://msdn.microsoft.com/en-us/library/bb530716(VS.85).aspx

            [StructLayout(LayoutKind.Sequential, Pack = 1)]
            internal struct Token_Privilege //TokPriv1Luid
            {
                public int Count;
                public long Luid;
                public int Attr;
            }

            [DllImport("Advapi32.dll", ExactSpelling = true, SetLastError = true)]
            //[return: MarshalAs(UnmanagedType.Bool)] static extern bool AdjustTokenPrivileges(IntPtr TokenHandle, [MarshalAs(UnmanagedType.Bool)]bool DisableAllPrivileges, ref TOKEN_PRIVILEGES NewState, UInt32 BufferLengthInBytes, ref TOKEN_PRIVILEGES PreviousState, out UInt32 ReturnLengthInBytes); // Devuelve el estado anterior
            //[return: MarshalAs(UnmanagedType.Bool)] static extern bool AdjustTokenPrivileges(IntPtr TokenHandle, [MarshalAs(UnmanagedType.Bool)]bool DisableAllPrivileges, ref TOKEN_PRIVILEGES NewState, UInt32 Zero, IntPtr Null1, IntPtr Null2); // No devuelve el estado anterior
            internal static extern bool AdjustTokenPrivileges(IntPtr htpk, bool disall, ref Token_Privilege newst, int len, IntPtr prev, IntPtr relen);

            [DllImport("Advapi32.dll")]
            public static extern bool InitiateSystemShutdown(string MachineName, string Message, uint Timeout, bool AppsClosed, bool Restart);

            [DllImport("Advapi32.dll", ExactSpelling = true, SetLastError = true)]
            internal static extern bool OpenProcessToken(IntPtr h, int acc, ref IntPtr phtok);

            [DllImport("Advapi32.dll", SetLastError = true)]
            internal static extern bool LookupPrivilegeValue(string host, string name, ref long pluid);
        }

        internal static class Kernel32
        {
            [DllImport("Kernel32.dll"/*, ExactSpelling = true*/)]
            internal static extern IntPtr GetCurrentProcess();
        }

        internal static class Powrprof
        {
            [DllImport("Powrprof.dll", CharSet = CharSet.Auto, SetLastError = true)]
            internal static extern bool IsPwrHibernateAllowed();

            [DllImport("Powrprof.dll", CharSet = CharSet.Auto, SetLastError = true)]
            internal static extern bool IsPwrShutdownAllowed();

            [DllImport("Powrprof.dll", CharSet = CharSet.Auto, SetLastError = true)]
            internal static extern bool IsPwrSuspendAllowed();
        }

        internal static class Shell32
        {
            /// <summary>
            /// this enum used on conjunction with getobjectproperties
            /// </summary>
            public enum SHObjectPropertiesFlags
            {
                PrinterName = 1, // lpObject points to a printer friendly name
                FilePath = 2, // lpObject points to a fully qualified path + file name
                VolumeGuid = 4 // lpObject points to a Volume GUID
            }

            /// <summary>
            /// This function invokes the Properties context menu command on a Shell object.
            /// Ejemplo: "CallPropDialog(this.Handle, GetProperties.SHOP_FILEPATH, Ruta, null)";
            /// </summary>
            /// <param name="hwnd">[in] The HWND of the window that will be the parent of the dialog box.</param>
            /// <param name="dwType">enum to what to call</param>
            /// <param name="szObject">[in] A NULL-terminated Unicode string that contains the object name.
            /// The contents of the string are determinated by which of
            /// the first three flags are set in dwType.</param>
            /// <param name="szPage">[in] A NULL-terminated Unicode string that contains the name of
            /// the property sheet page to be initally opened.
            /// Set this parameter to NULL to specifiy the default page.
            /// General, Summary, Security, etc. Pero en Español: "Resumen" (09-01-2010)...</param>
            /// <returns>Returns TRUE if the Properties command is successfully invoked, or FALSE otherwise.</returns>
            [DllImport("shell32.dll", CharSet = CharSet.Auto, SetLastError = true)]
            internal static extern bool SHObjectProperties(IntPtr Handle_Ventana, SHObjectPropertiesFlags Flags, string Ruta, string Página);
        }

        internal static class User32
        {
            [Flags]
            internal enum ExitWindows_Flags : uint
            {
                LogOff = 0,
                Shutdown = 1,
                Reboot = 2,
                Force = 4,
                PowerOff = 8,
                ForceIfHung = 16,
                RestartApps = 64
            }

            [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
            internal static extern bool ExitWindowsEx(ExitWindows_Flags Flags, uint Valor_Uno);

            [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
            internal static extern bool LockWorkStation();
        }
    }
}
