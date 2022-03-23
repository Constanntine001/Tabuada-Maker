using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabuadaMaker
{
    public partial class Form1 : Form
    {
        int answer = 0;
        int answerPosition = 0;
        int points = 0;

        public Form1()
        {
            InitializeComponent();

            //Starting point

            GerarTabuada();
        }

        public void GerarTabuada()
        {
            int number1 = RetornaTabuada();
            int number2 = RetornaTabuada();

            // Idk if this is going to have a good use for it
            answer = number1 * number2;

            label1.Text = number1.ToString() + " * " + number2.ToString() + " = ?";

            GerarFalsos();

            Random temp = new Random();
            switch(temp.Next(1,5))
            {
                case 1:
                    button1.Text = answer.ToString();
                    answerPosition = 1;
                    break;
                case 2:
                    button2.Text = answer.ToString();
                    answerPosition = 2;
                    break;
                case 3:
                    button3.Text = answer.ToString();
                    answerPosition = 3;
                    break;
                case 4:
                    button4.Text = answer.ToString();
                    answerPosition = 4;
                    break;
            }

            label2.Text = "Points: " + points.ToString();
        }

        public void GerarFalsos()
        {
            Button[] respostas = new Button[4];

            respostas[0] = button1;
            respostas[1] = button2;
            respostas[2] = button3;
            respostas[3] = button4;

            for(int i = 0; i < 4; i++)
            {
                while(true)
                {
                    int randomAnswer = RetornaTabuada() * RetornaTabuada();
                    if(randomAnswer != answer)
                    {
                        respostas[i].Text = randomAnswer.ToString();
                        break;
                    }
                }
            }
        }

        public int RetornaTabuada()
        {
            Random rnd = new Random();

            //Generates number 1~9
            return rnd.Next(1, 10);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(answerPosition == 1)
            {
                points++;
                img_right.Visible = true;
            }
            else
            {
                img_wrong.Visible = true;
            }
            HideAllElements();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (answerPosition == 2)
            {
                points++;
                img_right.Visible = true;
            }
            else
            {
                img_wrong.Visible = true;
            }
            HideAllElements();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (answerPosition == 3)
            {
                points++;
                img_right.Visible = true;
            }
            else
            {
                img_wrong.Visible = true;
            }
            HideAllElements();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (answerPosition == 4)
            {
                points++;
                img_right.Visible = true;
            }
            else
            {
                img_wrong.Visible = true;
            }
            HideAllElements();
        }

        public void HideAllElements()
        {
            label1.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GerarTabuada();

            img_right.Visible = false;
            img_wrong.Visible = false;
            label1.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;

            timer1.Stop();
        }
    }
}
