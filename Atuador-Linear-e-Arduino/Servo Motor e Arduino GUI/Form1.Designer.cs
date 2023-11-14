namespace Servo_Motor_e_Arduino_GUI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Parâmetros_Motor = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.PosAtualizada = new System.Windows.Forms.Button();
            this.textoPosicao = new System.Windows.Forms.TextBox();
            this.Enviar = new System.Windows.Forms.Button();
            this.Velocity = new System.Windows.Forms.Button();
            this.Direction2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.PulseQntd = new System.Windows.Forms.Button();
            this.Direction = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SemAcelerar = new System.Windows.Forms.Button();
            this.En_Button = new System.Windows.Forms.Button();
            this.onButton = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ModoCalibracao = new System.Windows.Forms.Button();
            this.ModoMovimentacao = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.Parâmetros_Motor.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Parâmetros_Motor
            // 
            resources.ApplyResources(this.Parâmetros_Motor, "Parâmetros_Motor");
            this.Parâmetros_Motor.Controls.Add(this.textBox3);
            this.Parâmetros_Motor.Controls.Add(this.textBox5);
            this.Parâmetros_Motor.Controls.Add(this.PosAtualizada);
            this.Parâmetros_Motor.Controls.Add(this.textoPosicao);
            this.Parâmetros_Motor.Controls.Add(this.Enviar);
            this.Parâmetros_Motor.Controls.Add(this.Velocity);
            this.Parâmetros_Motor.Controls.Add(this.Direction2);
            this.Parâmetros_Motor.Controls.Add(this.textBox1);
            this.Parâmetros_Motor.Controls.Add(this.PulseQntd);
            this.Parâmetros_Motor.Controls.Add(this.Direction);
            this.Parâmetros_Motor.Controls.Add(this.textBox2);
            this.Parâmetros_Motor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Parâmetros_Motor.Name = "Parâmetros_Motor";
            this.Parâmetros_Motor.TabStop = false;
            // 
            // textBox3
            // 
            this.textBox3.AcceptsReturn = true;
            resources.ApplyResources(this.textBox3, "textBox3");
            this.textBox3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.textBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            // 
            // textBox5
            // 
            this.textBox5.AcceptsReturn = true;
            resources.ApplyResources(this.textBox5, "textBox5");
            this.textBox5.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.textBox5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // PosAtualizada
            // 
            resources.ApplyResources(this.PosAtualizada, "PosAtualizada");
            this.PosAtualizada.Name = "PosAtualizada";
            this.PosAtualizada.UseVisualStyleBackColor = true;
            this.PosAtualizada.Click += new System.EventHandler(this.PosAtualizada_Click_1);
            // 
            // textoPosicao
            // 
            resources.ApplyResources(this.textoPosicao, "textoPosicao");
            this.textoPosicao.Name = "textoPosicao";
            // 
            // Enviar
            // 
            resources.ApplyResources(this.Enviar, "Enviar");
            this.Enviar.Name = "Enviar";
            this.Enviar.UseVisualStyleBackColor = true;
            this.Enviar.Click += new System.EventHandler(this.Enviar_Click_1);
            // 
            // Velocity
            // 
            resources.ApplyResources(this.Velocity, "Velocity");
            this.Velocity.Name = "Velocity";
            this.Velocity.UseVisualStyleBackColor = true;
            this.Velocity.Click += new System.EventHandler(this.Velocity_Click_1);
            // 
            // Direction2
            // 
            resources.ApplyResources(this.Direction2, "Direction2");
            this.Direction2.Name = "Direction2";
            this.Direction2.UseVisualStyleBackColor = true;
            this.Direction2.Click += new System.EventHandler(this.Direction2_Click_1);
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // PulseQntd
            // 
            resources.ApplyResources(this.PulseQntd, "PulseQntd");
            this.PulseQntd.Name = "PulseQntd";
            this.PulseQntd.UseVisualStyleBackColor = true;
            this.PulseQntd.Click += new System.EventHandler(this.PulseQntd_Click_1);
            // 
            // Direction
            // 
            resources.ApplyResources(this.Direction, "Direction");
            this.Direction.Name = "Direction";
            this.Direction.UseVisualStyleBackColor = true;
            this.Direction.Click += new System.EventHandler(this.Direction_Click_1);
            // 
            // textBox2
            // 
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.Name = "textBox2";
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.SemAcelerar);
            this.groupBox1.Controls.Add(this.En_Button);
            this.groupBox1.Controls.Add(this.onButton);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.StopButton);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // SemAcelerar
            // 
            resources.ApplyResources(this.SemAcelerar, "SemAcelerar");
            this.SemAcelerar.Name = "SemAcelerar";
            this.SemAcelerar.UseVisualStyleBackColor = true;
            this.SemAcelerar.Click += new System.EventHandler(this.SemAcelerar_Click_1);
            // 
            // En_Button
            // 
            resources.ApplyResources(this.En_Button, "En_Button");
            this.En_Button.Name = "En_Button";
            this.En_Button.UseVisualStyleBackColor = true;
            this.En_Button.Click += new System.EventHandler(this.En_Button_Click);
            // 
            // onButton
            // 
            resources.ApplyResources(this.onButton, "onButton");
            this.onButton.Name = "onButton";
            this.onButton.UseVisualStyleBackColor = true;
            this.onButton.Click += new System.EventHandler(this.onButton_Click_1);
            // 
            // textBox4
            // 
            this.textBox4.AcceptsReturn = true;
            resources.ApplyResources(this.textBox4, "textBox4");
            this.textBox4.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.textBox4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // StopButton
            // 
            resources.ApplyResources(this.StopButton, "StopButton");
            this.StopButton.Name = "StopButton";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click_1);
            // 
            // serialPort2
            // 
            this.serialPort2.PortName = "COM10";
            this.serialPort2.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort2_DataReceived);
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox2.Image = global::Servo_Motor_e_Arduino_GUI.Properties.Resources.LM2C_Retina__1_downsise;
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.Parâmetros_Motor);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Controls.Add(this.ModoCalibracao);
            this.groupBox3.Controls.Add(this.ModoMovimentacao);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // ModoCalibracao
            // 
            resources.ApplyResources(this.ModoCalibracao, "ModoCalibracao");
            this.ModoCalibracao.Name = "ModoCalibracao";
            this.ModoCalibracao.UseVisualStyleBackColor = true;
            this.ModoCalibracao.Click += new System.EventHandler(this.ModoCalibracao_Click);
            // 
            // ModoMovimentacao
            // 
            resources.ApplyResources(this.ModoMovimentacao, "ModoMovimentacao");
            this.ModoMovimentacao.Name = "ModoMovimentacao";
            this.ModoMovimentacao.UseVisualStyleBackColor = true;
            this.ModoMovimentacao.Click += new System.EventHandler(this.ModoMovimentacao_Click);
            // 
            // groupBox4
            // 
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Controls.Add(this.textBox7);
            this.groupBox4.Controls.Add(this.textBox6);
            this.groupBox4.Controls.Add(this.button5);
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // textBox6
            // 
            resources.ApplyResources(this.textBox6, "textBox6");
            this.textBox6.Name = "textBox6";
            // 
            // button5
            // 
            resources.ApplyResources(this.button5, "button5");
            this.button5.Name = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            resources.ApplyResources(this.button4, "button4");
            this.button4.Name = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // textBox7
            // 
            resources.ApplyResources(this.textBox7, "textBox7");
            this.textBox7.Name = "textBox7";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Name = "Form1";
            this.Parâmetros_Motor.ResumeLayout(false);
            this.Parâmetros_Motor.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox Parâmetros_Motor;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button PosAtualizada;
        private System.Windows.Forms.TextBox textoPosicao;
        private System.Windows.Forms.Button Enviar;
        private System.Windows.Forms.Button Velocity;
        private System.Windows.Forms.Button Direction2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button PulseQntd;
        private System.Windows.Forms.Button Direction;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button SemAcelerar;
        private System.Windows.Forms.Button En_Button;
        private System.Windows.Forms.Button onButton;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button StopButton;
        private System.IO.Ports.SerialPort serialPort2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button ModoCalibracao;
        private System.Windows.Forms.Button ModoMovimentacao;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox7;
    }
}

