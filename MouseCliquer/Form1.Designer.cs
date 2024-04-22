
namespace MouseCliquer
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tempo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.definir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.teclaEspecifica = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.quantidadeClicks = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.quantidadeClicks)).BeginInit();
            this.SuspendLayout();
            // 
            // tempo
            // 
            this.tempo.Location = new System.Drawing.Point(33, 43);
            this.tempo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tempo.MaxLength = 17;
            this.tempo.Name = "tempo";
            this.tempo.Size = new System.Drawing.Size(119, 23);
            this.tempo.TabIndex = 2;
            this.tempo.Text = "3000";
            this.tempo.TextChanged += new System.EventHandler(this.tempo_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Timer (microsegundos)";
            // 
            // definir
            // 
            this.definir.Location = new System.Drawing.Point(162, 40);
            this.definir.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.definir.Name = "definir";
            this.definir.Size = new System.Drawing.Size(125, 28);
            this.definir.TabIndex = 4;
            this.definir.Text = "definir";
            this.definir.UseVisualStyleBackColor = true;
            this.definir.Click += new System.EventHandler(this.definir_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(178, 318);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Não rodando";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 105);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 64);
            this.label1.TabIndex = 6;
            this.label1.Text = "Milisegundos: 3\r\nSegundos: 0\r\nMinutos: 0\r\nHoras: 0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(18, 90);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tempo convertido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 185);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tecla pressionada:";
            // 
            // teclaEspecifica
            // 
            this.teclaEspecifica.Location = new System.Drawing.Point(218, 179);
            this.teclaEspecifica.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.teclaEspecifica.Name = "teclaEspecifica";
            this.teclaEspecifica.Size = new System.Drawing.Size(69, 28);
            this.teclaEspecifica.TabIndex = 10;
            this.teclaEspecifica.Text = "F3";
            this.teclaEspecifica.UseVisualStyleBackColor = true;
            this.teclaEspecifica.Enter += new System.EventHandler(this.teclaEspecifica_Enter);
            this.teclaEspecifica.KeyDown += new System.Windows.Forms.KeyEventHandler(this.teclaEspecifica_KeyDown);
            this.teclaEspecifica.Leave += new System.EventHandler(this.teclaEspecifica_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(35, 70);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "Não definido";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(43, 211);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(244, 30);
            this.label7.TabIndex = 12;
            this.label7.Text = "Pressione a nova tecla para habilitar/desabilitar";
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 260);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(208, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Quantidade de clicks";
            // 
            // quantidadeClicks
            // 
            this.quantidadeClicks.Location = new System.Drawing.Point(33, 279);
            this.quantidadeClicks.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quantidadeClicks.Name = "quantidadeClicks";
            this.quantidadeClicks.Size = new System.Drawing.Size(120, 23);
            this.quantidadeClicks.TabIndex = 15;
            this.quantidadeClicks.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 343);
            this.Controls.Add(this.quantidadeClicks);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.teclaEspecifica);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.definir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tempo);
            this.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Luna2xLuna Clicker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.quantidadeClicks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tempo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button definir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button teclaEspecifica;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown quantidadeClicks;
    }
}

