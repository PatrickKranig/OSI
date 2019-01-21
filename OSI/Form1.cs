using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OSI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            radioButton4.Visible = false;
            radioButton5.Visible = false;
            radioButton6.Visible = false;
            radioButton7.Visible = false;
            label3.Visible = false;
            textBox1.Visible = true;
            button2.Visible = true;
            label7.Visible = true;
           
            if (radioButton1.Checked)
            {
                label1.Text = "Wie ist heisst die 1. Schicht?";
            }
            if (radioButton2.Checked)
            {
                label1.Text = "Wie ist heisst die 2. Schicht?";
            }
            if (radioButton3.Checked)
            {
                label1.Text = "Wie ist heisst die 3. Schicht?";
            }
            if (radioButton4.Checked)
            {
                label1.Text = "Wie ist heisst die 4. Schicht?";
            }
            if (radioButton5.Checked)
            {
                label1.Text = "Wie ist heisst die 5. Schicht?";
            }
            if (radioButton6.Checked)
            {
                label1.Text = "Wie ist heisst die 6. Schicht?";
            }
            if (radioButton7.Checked)
            {
                label1.Text = "Wie ist heisst die 7. Schicht?";
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            radioButton1.Visible = true;
            radioButton2.Visible = true;
            radioButton3.Visible = true;
            radioButton4.Visible = true;
            radioButton5.Visible = true;
            radioButton6.Visible = true;
            radioButton7.Visible = true;
            label3.Visible = true;
           
            if (radioButton1.Checked)
            {
                  if (textBox1.Text == "Bitübertragungsschicht")
                  {
                     label3.Text = "RICHTIG!";
                  }
                  else
                  {
                        label3.Text = "FALSCH! es ist die\r Bitübertragungsschicht";
                  }
            }
            if (radioButton2.Checked)
            {
                if (textBox1.Text == "Sicherungsschicht")
                {
                    label3.Text = "RICHTIG!";
                }
                else
                {
                    label3.Text = "FALSCH! es ist die\r Sicherungsschicht";
                }
            }
            if (radioButton3.Checked)
            {
                if (textBox1.Text == "Netzwerkschicht")
                {
                    label3.Text = "RICHTIG!";
                }
                else
                {
                    label3.Text = "FALSCH! es ist die\r Netzwerkschicht";
                }
            }
            if (radioButton4.Checked)
            {
                if (textBox1.Text == "Transportschicht")
                {
                    label3.Text = "RICHTIG!";
                }
                else
                {
                    label3.Text = "FALSCH! es ist die\r Transportschicht";
                }
            }
            if (radioButton5.Checked)
            {
                if (textBox1.Text == "Sitzungsschicht")
                {
                    label3.Text = "RICHTIG!";
                }
                else
                {
                    label3.Text = "FALSCH! es ist die\r Sitzungsschicht";
                }
            }
            if (radioButton6.Checked)
            {
                if (textBox1.Text == "Darstellungsschicht")
                {
                    label3.Text = "RICHTIG!";
                }
                else
                {
                    label3.Text = "FALSCH! es ist die\r Darstellungsschicht";
                }
            }
            if (radioButton7.Checked)
            {
                if (textBox1.Text == "Anwendungsschicht")
                {
                    label3.Text = "RICHTIG!";
                }
                else
                {
                    label3.Text = "FALSCH! es ist die\r Anwendungsschicht";
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "";
            label3.Text = "";
            label5.Text = "";
        }

        private void button3_Click(object sender, EventArgs e) //Button für Bild
        {
            
            button3.Visible = false;
            button4.Visible = true;
            label5.Visible = true;
            label5.Text = "";
            if (label3.Text == "RICHTIG!")
            {
                pictureBox1.Visible = true;
                this.Size = new System.Drawing.Size(704, 732);
            }
            else
            {
                label5.Text="Du musst zuerst eine Frage richtig beantwortet haben!";
            }
        }

        private void button4_Click(object sender, EventArgs e) //verstekcne Button für Bild
        {
            this.Size = new System.Drawing.Size(704, 338);
            button4.Visible = false;
            button3.Visible = true;
            pictureBox1.Visible = false;
            label5.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
