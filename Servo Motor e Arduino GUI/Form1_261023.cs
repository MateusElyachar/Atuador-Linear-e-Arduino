﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Threading;
using System.Xml.Linq;
using System.Data.SqlTypes;

namespace Servo_Motor_e_Arduino_GUI
{
    public partial class Form1 : Form
    {
        private delegate void d1(string indata);
        private static int counter;
        string m1;  // posição
        string m2;  // velocidade
        string m3;  // direção
        string m10; // Envia comando para mover o motor com ou sem aceleração
        float posAnterior; // posição anterior
        float posFinal; //posicão final 
        float posVar = 0; //Variação da posição
        float deslocamento_por_pulso; //variação de posição total / numero de pulsos enviados
        


        public Form1()
        {
            InitializeComponent();
            serialPort2.Open();

        }

        private void onButton_Click_1(object sender, EventArgs e)
        {
            // Send command to the arduino to rotate the motor with acceleration
            serialPort2.Write("G");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Send command to the arduino to turn off the enable function of the driver deenergizing the motor
            serialPort2.Write("a");
        }

        private void PulseQntd_Click_1(object sender, EventArgs e)
        {
            // Send velocity qntd to driver
            m1 = "P" + textBox1.Text;
        }

        private void Velocity_Click_1(object sender, EventArgs e)
        {
            // Send velocity qntd to driver
            m2 = "V" + textBox2.Text;
        }

        private void Direction_Click_1(object sender, EventArgs e)
        {
            // Send Send direction(CW or CCW) to driver  
            m3 = "C";
        }

        private void Direction2_Click_1(object sender, EventArgs e)
        {
            // Send direction(CW or CCW) to driver
            m3 = "B";
        }

        private void StopButton_Click_1(object sender, EventArgs e)
        {
            // Send pulse qntd to driver
            string m4 = "n";
            serialPort2.Write(m4);
        }



        private void serialPort2_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            string indata = serialPort2.ReadLine();
            d1 writeit = new d1(Write2Form);
            Invoke(writeit, indata);

        }

        public void Write2Form(String indata)
        {
            // This function handles data sent from the arduino

            char g = indata[0];
            if (g == 'p')
            {
                textBox3.Text = "";
                textBox3.AppendText(Convert.ToString(indata).Substring(1) + "mm");
            }
            else if(g == 'l')
            {
                textBox10.Text = "";
                textBox10.AppendText(Convert.ToString(indata).Substring(1) + "mm");
            }
            else
            {
                textBox4.AppendText(Convert.ToString(indata) + "\r\n");
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void En_Button_Click(object sender, EventArgs e)
        {
            // Send command to the arduino to turn on the enable function of the driver energizing the motor
            string m4 = "A";
            serialPort2.Write(m4);
        }

        private void Enviar_Click_1(object sender, EventArgs e)
        {
            //Envia os parâmetros do motor para o arduino
            serialPort2.Write(m3);
            Thread.Sleep(1000);
            serialPort2.Write(m1);
            Thread.Sleep(1000);
            serialPort2.Write(m2);
            
        }

        private void SemAcelerar_Click_1(object sender, EventArgs e)
        {
            // Send command to the arduino to rotate the motor with acceleration
            serialPort2.Write("H");
        }

        private void PosAtualizada_Click_1(object sender, EventArgs e)
        {
            // Send actual position to arduindo
            string m6 = "O" + textoPosicao.Text;
            serialPort2.Write(m6);
            textoPosicao.Text = "";
        }

       
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void ModoMovimentacao_Click(object sender, EventArgs e)
        {
            groupBox4.Hide();
            groupBox2.Show();
        }

        private void ModoCalibracao_Click(object sender, EventArgs e)
        {
            groupBox4.Show();
            groupBox2.Hide();
        }

        private void A_laser_Click(object sender, EventArgs e)
        {
            // Send velocity qntd to driver
            m2 = "J" + textBox6.Text;
            serialPort2.Write(m2);
        }
        private void Aceleracao_calibracao_Click(object sender, EventArgs e)
        {
            m10 = "G";
        }

        private void Sem_Aceleracao_calibracao_Click(object sender, EventArgs e)
        {
            m10 = "H";
        }

        private void calibrar_Click(object sender, EventArgs e)
        {
            serialPort2.Write("B");
            Thread.Sleep(1000);
            serialPort2.Write("P" + 1000);
            Thread.Sleep(1000);
            serialPort2.Write("V" + textBox7.Text);
            Thread.Sleep(1000);

            serialPort2.Write("I");

            //for (int i = 0; i == 4;)
            //{

            //    posAnterior += float.Parse(textBox4.Text);
            //    serialPort2.Write(m10);
            //    Thread.Sleep(5000);
            //    posFinal += float.Parse(textBox4.Text);
            //    posVar += Math.Abs(posFinal - posAnterior);
            //}

            //deslocamento_por_pulso = posVar / (4 * 1000);




        }
            


        

    }
}
