using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilgi_Yarışması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruno = 0;
        int dogru = 0;
        int yanlis = 0;

        int sure = 20;
        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            sure = 20;
            label11.Text = sure.ToString();
            button5.Text = "İLERİ";
            soruno++;
            label2.Text = soruno.ToString();

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;

            if (soruno == 1)
            {
                richTextBox1.Text = "Mustafa Kemal kaç yılında doğmuştur ?";
                button1.Text = "1880";
                button2.Text = "1881";
                button3.Text = "1882";
                button4.Text = "1883";
                label5.Text  = "1881"; 

            }

            if(soruno == 2)
            {
                richTextBox1.Text = "Türkiye kaç coğrafi bölgeye ayrılır?";
                button1.Text = "7";
                button2.Text = "15";
                button3.Text = "25";
                button4.Text = "81";
                label5.Text = "7";
            }

            if(soruno == 3)
            {
                richTextBox1.Text = "Ağrı Dağı HAngi İlimizdedir?";
                button1.Text = "İstanbul";
                button2.Text = "Malatya";
                button3.Text = "Ağrı";
                button4.Text = "İzmir";
                label5.Text = "Ağrı";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            timer1.Enabled = false;
            label4.Text = button1.Text;
            if(label4.Text == label5.Text)
            {
                dogru++;
                label7.Text = dogru.ToString();
            }
            else
            {
                yanlis++;
                label9.Text = yanlis.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            timer1.Enabled = false;

            label4.Text = button2.Text;

            if (label4.Text == label5.Text)
            {
                dogru++;
                label7.Text = dogru.ToString();
            }
            else
            {
                yanlis++;
                label9.Text = yanlis.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            timer1.Enabled = false;

            label4.Text = button3.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                label7.Text = dogru.ToString();
            }
            else
            {
                yanlis++;
                label9.Text = yanlis.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            timer1.Enabled = false;

            label4.Text = button4.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                label7.Text = dogru.ToString();
            }
            else
            {
                yanlis++;
                label9.Text = yanlis.ToString();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sure = Convert.ToInt32(label11.Text);

            sure = sure - 1;
            label11.Text = sure.ToString();

            if(sure == 0)
            {
                timer1.Enabled = false;
                yanlis++;
                label9.Text = yanlis.ToString();

            }

        }
    }
}
