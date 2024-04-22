using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseCliquer
{
    static class Program
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        //Mouse actions
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;

        /// <summary>
        /// Faz o clique do mouse
        /// </summary>
        public static void DoMouseClick()
        {
            try
            {
                //Call the imported function with the cursor's current position
                uint X = (uint)Cursor.Position.X;
                uint Y = (uint)Cursor.Position.Y;
                mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            }
            catch (Exception) { }
        }

        /// <summary>
        /// Função para esperar Microsegundos
        /// </summary>
        /// 
        /// <param name="microseconds">Quantidade</param>
        private static void WaitMicroseconds(long microseconds)
        {
            long start = Stopwatch.GetTimestamp();
            long waitUntil = start + (Stopwatch.Frequency / 1000000L * microseconds);

            while (true)
            {
                long now = Stopwatch.GetTimestamp();
                if (now >= waitUntil)
                    break;
            }
        }

        // Tempo padrão
        static long tempoEmMicroSegundos = 3000;

        /// <summary>
        /// Função que fica clicando no mouse
        /// </summary>
        private static void FicarClicando()
        {
            while (true)
            {
                // Stopwatch
                //Stopwatch stopwatch = new Stopwatch();
                //stopwatch.Start();

                // Espere
                WaitMicroseconds(tempoEmMicroSegundos);

                // Faça o clique
                DoMouseClick();
            }
        }

        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                string[] args = Environment.GetCommandLineArgs();


                foreach (string arg in args)
                {
                    try
                    {
                        // Pegue a pasta para escanear
                        string p = arg.Split(new[] { "Tempo:" }, StringSplitOptions.None)[1];

                        tempoEmMicroSegundos = Int64.Parse(p);
                        FicarClicando();

                        // Não execute mais nada
                        return;
                    } catch (Exception)
                    {

                    }
                }

            }
            catch (Exception ex) {

                MessageBox.Show(ex.Message);
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        }


    }
}
