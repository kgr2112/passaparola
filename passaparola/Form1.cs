using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace passaparola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int soruno = 0, dogru = 0, yanlis = 0;

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                switch (soruno)
                {
                    case 1:
                        if (textBox1.Text =="aston villa")
                        {
                            button1.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button1.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 2:
                        if (textBox1.Text == "beatles")
                        {
                            button2.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button2.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;

                    case 3:
                        if (textBox1.Text == "citroen")
                        {
                            button3.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button3.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;

                    case 4:
                        if (textBox1.Text == "denmark")
                        {
                            button4.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button4.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;

                    case 5:
                        if (textBox1.Text == "eve")
                        {
                            button5.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button5.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;

                    case 6:
                        if (textBox1.Text == "fenerbahce")
                        {
                            button6.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button6.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;

                    case 7:
                        if (textBox1.Text == "glasgow")
                        {
                            button7.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button7.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;

                    case 8:
                        if (textBox1.Text == "harmonica")
                        {
                            button8.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button8.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;

                    case 9:
                        if (textBox1.Text == "ikea")
                        {
                            button9.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button9.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;

                    case 10:
                        if (textBox1.Text == "jamaica")
                        {
                            button10.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button10.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;

                    case 11:
                        if (textBox1.Text == "kennel")
                        {
                            button11.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button11.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;

                    case 12:
                        if (textBox1.Text == "ludwig")
                        {
                            button12.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button12.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;

                    case 13:
                        if (textBox1.Text == "madonna")
                        {
                            button13.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button13.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;

                    case 14:
                        if (textBox1.Text == "nokia")
                        {
                            button14.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button14.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;

                    case 15:
                        if (textBox1.Text == "osaka")
                        {
                            button15.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button15.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;

                    case 16:
                        if (textBox1.Text == "panama")
                        {
                            button16.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button16.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;

                    case 17:
                        if (textBox1.Text == "ronaldo")
                        {
                            button17.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button17.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;

                    case 18:
                        if (textBox1.Text == "seoul")
                        {
                            button18.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button18.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;

                    case 19:
                        if (textBox1.Text == "thailand")
                        {
                            button19.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button19.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;

                    case 20:
                        if (textBox1.Text == "urban")
                        {
                            button20.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button20.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;

                    case 21:
                        if (textBox1.Text == "vespa")
                        {
                            button21.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button21.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;

                    case 22:
                        if (textBox1.Text == "wembley")
                        {
                            button22.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button22.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;

                    case 23:
                        if (textBox1.Text == "yoghurt")
                        {
                            button23.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button23.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;

                    case 24:
                        if (textBox1.Text == "zombie")
                        {
                            button24.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();
                        }
                        else
                        {
                            button24.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                }

            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.Text = "Next";
            soruno++;
            this.Text = soruno.ToString();
            
            if (soruno==1)
            {
                richTextBox1.Text = "The football team in the Premier League from Birmingham?";
                button1.BackColor = Color.Yellow;

            }
            if (soruno==2)
            {
                richTextBox1.Text = "World famous band from Liverpool?";
                button2.BackColor = Color.Yellow;

            }
            if (soruno==3)
            {
                richTextBox1.Text = "What car's logo looks like a double arrow facing upwards?";
                button3.BackColor = Color.Yellow;
            }
            if (soruno ==4 )
            {
                richTextBox1.Text = "Which country has these cities: Aarhus, Aalborg, and Esbjerg?";
                button4.BackColor = Color.Yellow;
            }
            if (soruno == 5)
            {
                richTextBox1.Text = "Adam's wife?";
                button5.BackColor = Color.Yellow;
            }
            if (soruno == 6)
            {
                richTextBox1.Text = "The Turkish Super League football team?";
                button6.BackColor = Color.Yellow;
            }
            if (soruno == 7)
            {
                richTextBox1.Text = "A city in Scotland?";
                button7.BackColor = Color.Yellow;
            }
            if (soruno == 8)
            {
                richTextBox1.Text = "With which musical instrument is Larry Adler associated?";
                button8.BackColor = Color.Yellow;
            }
            if (soruno == 9)
            {
                richTextBox1.Text = "What is the name of the furnishing company founded by Ingvar Kamprad?";
                button9.BackColor = Color.Yellow;
            }
            if (soruno == 10)
            {
                richTextBox1.Text = "Which country's car international index mark is JA?";
                button10.BackColor = Color.Yellow;
            }
            if (soruno == 11)
            {
                richTextBox1.Text = "Hotel for dogs?";
                button11.BackColor = Color.Yellow;
            }
            if (soruno == 12)
            {
                richTextBox1.Text = "Beethoven's first name?";
                button12.BackColor = Color.Yellow;
            }
            if (soruno == 13)
            {
                richTextBox1.Text = "Like a Virgin singer?";
                button13.BackColor = Color.Yellow;
            }
            if (soruno == 14)
            {
                richTextBox1.Text = "Finnish cell phone maker?";
                button14.BackColor = Color.Yellow;
            }
            if (soruno == 15)
            {
                richTextBox1.Text = "Japan's second largest city?";
                button15.BackColor = Color.Yellow;
            }
            if (soruno == 16)
            {
                richTextBox1.Text = "Canal that connects the Atlantic and Pacific?";
                button16.BackColor = Color.Yellow;
            }
            if (soruno == 17)
            {
                richTextBox1.Text = "Brazil's leading World Cup goalscorer?";
                button17.BackColor = Color.Yellow;
            }
            if (soruno == 18)
            {
                richTextBox1.Text = "Gangnam Style city?";
                button18.BackColor = Color.Yellow;
            }
            if (soruno == 19)
            {
                richTextBox1.Text = "Bangkok is its capital?";
                button19.BackColor = Color.Yellow;
            }
            if (soruno == 20)
            {
                richTextBox1.Text = "Opposite of rural?";
                button20.BackColor = Color.Yellow;
            }
            if (soruno == 21)
            {
                richTextBox1.Text = "Brand of Italian scooter?";
                button21.BackColor = Color.Yellow;
            }
            if (soruno == 22)
            {
                richTextBox1.Text = "England's world famous stadium?";
                button22.BackColor = Color.Yellow;
            }
            if (soruno == 23)
            {
                richTextBox1.Text = "A custard-like food made from curdled milk?";
                button23.BackColor = Color.Yellow;
            }
            if (soruno == 24)
            {
                richTextBox1.Text = "Undead person?";
                button24.BackColor = Color.Yellow;
            }
        }
    }
}
