using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyBoardClikerBot
{
    public partial class Form1 : Form
    {
        int step = 0;
        int count = 0;
        string putButton;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Location = new Point(1, 1);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            count = Convert.ToInt32(textBox2.Text);
            putButton = textBox1.Text;
            step = 1;
            ButtonLoop();
        }

        // CLOSE BUTTON
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        async void ButtonLoop()
        {
            await Task.Run(() =>
            {
                for (; true;)
                {
                    if (radioButton1.Checked)
                    {
                        if (step == 1)
                        {
                            for (int i = 0; i < count; i++)
                            {
                                if (i == 0)
                                {
                                    Thread.Sleep(2000);

                                }
                                Thread.Sleep(1);
                                SendKeys.SendWait("{enter}");
                            }
                            step = 0;
                        }
                        else if (step == 0)
                        {
                            break;
                        }
                    }else if (radioButton2.Checked)
                    {
                        if (step == 1)
                        {
                            for (int i = 0; i < count; i++)
                            {
                                if (i == 0)
                                {
                                    Thread.Sleep(2000);

                                }
                                Thread.Sleep(1);
                                SendKeys.SendWait(putButton);
                            }
                            step = 0;
                        }
                        else if (step == 0)
                        {
                            break;
                        }
                    }
                }
            });
        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
