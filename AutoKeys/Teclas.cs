using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows;

namespace AutoKeys
{
    class Teclas
    {
        [DllImport("user32.dll")]
        static extern bool PostMessage(IntPtr hWnd, UInt32 Msg, int wParam, int lParam);
        const UInt32 WM_KEYDOWN = 0x0100;
        const UInt32 WM_KEYUP = 0x0101;

        #region Funciones
        public const int VK_F1 = 0x70;
        public const int VK_F2 = 0x71;
        public const int VK_F3 = 0x72;
        public const int VK_F4 = 0x73;
        public const int VK_F5 = 0x74;
        public const int VK_F6 = 0x75;
        public const int VK_F7 = 0x76;
        public const int VK_F8 = 0x77;
        public const int VK_F9 = 0x78;
        public const int VK_F10 = 0x79;
        public const int VK_F11 = 0x7A;
        public const int VK_F12 = 0x7B;
        #endregion
        #region TecladoNumerico
        public const int VkNum00 = 0x60;
        public const int VkNum01 = 0x61;
        public const int VkNum02 = 0x62;
        public const int VkNum03 = 0x63;
        public const int VkNum04 = 0x64;
        public const int VkNum05 = 0x65;
        public const int VkNum06 = 0x66;
        public const int VkNum07 = 0x67;
        public const int VkNum08 = 0x68;
        public const int VkNum09 = 0x69;
        #endregion
        #region AlfaNumerico
        public const int NumPad00 = 0x30;
        public const int NumPad01 = 0x31;
        public const int NumPad02 = 0x32;
        public const int NumPad03 = 0x33;
        public const int NumPad04 = 0x34;
        public const int NumPad05 = 0x35;
        public const int NumPad06 = 0x36;
        public const int NumPad07 = 0x37;
        public const int NumPad08 = 0x38;
        public const int NumPad09 = 0x39;
        #endregion
        #region Alfabeto
        public const int LetraA = 0x41;
        public const int LetraB = 0x42;
        public const int LetraC = 0x43;
        public const int LetraD = 0x44;
        public const int LetraE = 0x45;
        public const int LetraF = 0x46;
        public const int LetraG = 0x47;
        public const int LetraH = 0x48;
        public const int LetraI = 0x49;
        public const int LetraJ = 0x4A;
        public const int LetraK = 0x4B;
        public const int LetraL = 0x4C;
        public const int LetraM = 0x4D;
        public const int LetraN = 0x4E;
        public const int LetraO = 0x4F;
        public const int LetraP = 0x50;
        public const int LetraQ = 0x51;
        public const int LetraR = 0x52;
        public const int LetraS = 0x53;
        public const int LetraT = 0x54;
        public const int LetraU = 0x55;
        public const int LetraV = 0x56;
        public const int LetraW = 0x57;
        public const int LetraX = 0x58;
        public const int LetraY = 0x59;
        public const int LetraZ = 0x5A;
        #endregion
        #region Especiales
        public const int Divisor = 0x6F;
        public const int Multiplicar = 0x6A;
        public const int Menos = 0x6D;
        public const int Suma = 0x6B;
        public const int FlechaUp = 0x26;
        public const int FlechaDown = 0x28;
        public const int FlechaLeft = 0x25;
        public const int FlechaRight = 0x27;
        #endregion
        #region Sistema
        public const int VK_CONTROL = 0x11;
        public const int VK_BACK = 0x08;
        public const int VK_TAB = 0x09;
        public const int VK_ENTER = 0x0D;
        public const int VK_SHIFT = 0x10;
        public const int VK_ALT = 0x12;
        public const int VK_SPACE = 0x20;
        #endregion

        [STAThread]
        public static void accionTecla(int tecla, int Id)
        {
            try
            {
                Process processes = Process.GetProcessById(Id);
                PostMessage(processes.MainWindowHandle, WM_KEYDOWN, tecla, 0);
                PostMessage(processes.MainWindowHandle, WM_KEYUP, tecla, 0);
            }
            catch
            {
                MessageBox.Show("No es posible ejecutar la acción, el proceso no esta disponible");
            }
        }

        public static void pulsarTecla(int tecla, int Id)
        {
            try
            {
                Process processes = Process.GetProcessById(Id);
                PostMessage(processes.MainWindowHandle, WM_KEYDOWN, tecla, 0);
            }
            catch
            {
                MessageBox.Show("No es posible ejecutar la acción, el proceso no esta disponible");
            }
       
        }
        public static void soltarTecla(int tecla, int Id)
        {
            try
            {
                Process processes = Process.GetProcessById(Id);
                PostMessage(processes.MainWindowHandle, WM_KEYUP, tecla, 0);
            }
            catch
            {
                MessageBox.Show("No es posible ejecutar la acción, el proceso no esta disponible");
            }
           
        }
    }
}
