using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MouseCliquer
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Estrutura necessária
        /// </summary>
        public class KeyHandler
        {
            [DllImport("user32.dll")]
            private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);

            [DllImport("user32.dll")]
            private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

            private int key;
            private IntPtr hWnd;
            private int id;

            public KeyHandler(Keys key, Form form)
            {
                this.key = (int)key;
                this.hWnd = form.Handle;
                id = this.GetHashCode();
            }

            public override int GetHashCode()
            {
                return key ^ hWnd.ToInt32();
            }

            public bool Register()
            {
                return RegisterHotKey(hWnd, id, 0, key);
            }

            public bool Unregiser()
            {
                return UnregisterHotKey(hWnd, id);
            }
        }
        
        // Tecla global
        private KeyHandler ghk;

        List<Process> processos = new List<Process>();
        static string local = Assembly.GetEntryAssembly().Location;

        long microsegundos = 3000;

        /// <summary>
        /// Inicia o processo para iniciar os cliques
        /// </summary>
        /// 
        /// <param name="tempo">Tempo de intervalo</param>
        /// <param name="quantos">Quantos processos abrir</param>
        private void IniciarProcessos(Int64 tempo, int quantos)
        {
            processos.Clear();

            for (int i = 0; i < quantos; i++)
            {
                Process processo = new Process();
                processo.StartInfo.FileName = local;
                processo.StartInfo.Arguments = "Tempo:" + microsegundos.ToString();
                processo.StartInfo.UseShellExecute = false;
                processo.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                processos.Add(processo);

                processo.Start();
                processo.PriorityClass = ProcessPriorityClass.RealTime;
            }
        }

        /// <summary>
        /// Uma tecla foi pressionada, vamos chamar a função
        /// </summary>
        private void TeclaPressionada()
        {
            if (label3.Text == "Não rodando")
            {
                label3.Text = "Rodando";
                label3.ForeColor = Color.Green;

                IniciarProcessos(Int64.Parse(tempo.Text), int.Parse(quantidadeClicks.Text));
            }
            else
            {
                label3.Text = "Não rodando";
                label3.ForeColor = Color.Red;

                foreach (Process proc in processos)
                {
                    proc.Kill();
                }
            }

        }

        /// <summary>
        /// Quando uma tecla for pressionada
        /// </summary>
        /// 
        /// <param name="m">Mensagem</param>
        protected override void WndProc(ref Message m)
        {
            // Se for uma tecla pressionada
            if (m.Msg == 0x0312)
                TeclaPressionada();

            //
            base.WndProc(ref m);
        }

        /// <summary>
        /// Quando iniciar
        /// </summary>
        public Form1()
        {
            InitializeComponent();

            try
            {

                if (File.Exists("Config.txt"))
                {
                    string teclaSv = File.ReadAllLines("Config.txt")[0];
                    string tempoSv = File.ReadAllLines("Config.txt")[1];
                    string quantSv = File.ReadAllLines("Config.txt")[2];

                    teclaEspecifica.Text = teclaSv;
                    tempo.Text = tempoSv;
                    quantidadeClicks.Text = quantSv;

                    label6.Visible = false;
                }
            } catch (Exception) { }

            //
            Keys teclaEnum = (Keys)Enum.Parse(typeof(Keys), teclaEspecifica.Text);
            ghk = new KeyHandler(teclaEnum, this);

            // Registrar
            ghk.Register();

            try
            {
                microsegundos = Int64.Parse(tempo.Text);
            } catch (Exception ex)
            {
                MessageBoxShow(ex.Message + "\r\nApague o arquivo Config.txt", MessageBoxIcon.Error);
                Environment.Exit(0);
            }

            ConverterTempoParaOutros();
        }

        private static void MessageBoxShow(string msg, MessageBoxIcon info)
        {
            MessageBox.Show(msg, "Luna2xLuna", MessageBoxButtons.OK, info);
        }

        private void definir_Click(object sender, EventArgs e)
        {
            try
            {
                microsegundos = Int64.Parse(tempo.Text);
                label6.Visible = false;
                MessageBoxShow("OK", MessageBoxIcon.Information);
            } catch (Exception ex) {

                MessageBoxShow(ex.Message, MessageBoxIcon.Error);
            }
        }

        private void SalvarDados(string arquivo, string msg)
        {
            try
            {
                File.WriteAllText(arquivo, msg);
            } catch (Exception) { }
        }

        /// <summary>
        /// Quando a FORM fechar
        /// </summary>
        /// 
        /// <param name="sender">s</param>
        /// <param name="e">e</param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SalvarDados("Config.txt", 
                teclaEspecifica.Text + "\r\n" +
                tempo.Text + "\r\n" +
                quantidadeClicks.Text + "\r\n"
            );

            Environment.Exit(0);
        }

        private void ConverterTempoParaOutros()
        {
            try
            {
                long milisegundos = Int64.Parse(tempo.Text) / 1000;
                long segundos = milisegundos / 1000;
                long minutos = segundos / 60;
                long horas = minutos / 60;
                //long dias = horas / 24;
                //long meses = dias / 30;
                //long anos = meses / 12;

                label1.Text = $"" +
                    $"Milisegundos: {milisegundos}\nSegundos: {segundos}\nMinutos: {minutos}\nHoras: {horas}";
            }
            catch (Exception)
            {
                label1.Text = $"Milisegundos: 0\nSegundos: 0\nMinutos: 0\nHoras: 0";
            }
        }

        /// <summary>
        /// Quanto alterar o tempo
        /// </summary>
        /// 
        /// <param name="sender">s</param>
        /// <param name="e">e</param>
        private void tempo_TextChanged(object sender, EventArgs e)
        {
            ConverterTempoParaOutros();
            label6.Visible = true;
        }

        private void teclaEspecifica_KeyDown(object sender, KeyEventArgs e)
        {
            teclaEspecifica.Text = e.KeyCode.ToString();
            label7.Visible = false;

            ghk.Unregiser();

            //
            ghk = new KeyHandler(e.KeyCode, this);

            // Registrar
            ghk.Register();

        }

        private void teclaEspecifica_Enter(object sender, EventArgs e)
        {
            label7.Visible = true;
        }

        private void teclaEspecifica_Leave(object sender, EventArgs e)
        {
            label7.Visible = false;
        }
    }
}
