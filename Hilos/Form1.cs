using System.Windows.Forms;

namespace Hilos
{
    public partial class Form1 : Form
    {
        byte r, g;
        bool b1, b2;

        public Form1()
        {
            InitializeComponent();
            r = 0;
            g = 0;
            b1 = false;
            b2 = false;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cambiarColor1()
        {
            int i = 0;
            while (i++ < 1530)
            {
                Thread.Sleep(3);
                if (r >= 0 && r <= 255 && !b1)
                {
                    r += 3;
                    if (r == 255)
                    {
                        b1 = true;
                    }


                }
                if (r >= 0 && r <= 255 && b1)
                {
                    r -= 3;
                    if (r == 0)
                    {
                        b1 = false;
                    }
                }
                pictureBox1.BackColor = Color.FromArgb(r, 80, 100);
            }
            cambiarColor2();
        }

        private void cambiarColor2()
        {
            int i = 0;
            while (i++ < 1530)
            {
                Thread.Sleep(3);
                if (r >= 0 && r <= 255 && !b1)
                {
                    r += 3;
                    if (r == 255)
                    {
                        b1 = true;
                    }


                }
                if (r >= 0 && r <= 255 && b1)
                {
                    r -=3;
                    if (r == 0)
                    {
                        b1 = false;
                    }
                }
                pictureBox2.BackColor = Color.FromArgb(r, 80, 100);
            }
            cambiarColor3();
        }

        private void cambiarColor3()
        {
            int i = 0;
            while (i++ < 1530)
            {
                Thread.Sleep(3);
                if (r >= 0 && r <= 255 && !b1)
                {
                    r++;
                    if (r == 255)
                    {
                        b1 = true;
                    }


                }
                if (r >= 0 && r <= 255 && b1)
                {
                    r--;
                    if (r == 0)
                    {
                        b1 = false;
                    }
                }
                pictureBox3.BackColor = Color.FromArgb(r, 80, 100);
            }
            cambiarColor4();
        }

        private void cambiarColor4()
        {
            int i = 0;
            while (i++ < 1530)
            {
                Thread.Sleep(3);
                if (r >= 0 && r <= 255 && !b1)
                {
                    r++;
                    if (r == 255)
                    {
                        b1 = true;
                    }


                }
                if (r >= 0 && r <= 255 && b1)
                {
                    r--;
                    if (r == 0)
                    {
                        b1 = false;
                    }
                }
                pictureBox4.BackColor = Color.FromArgb(r, 80, 100);
            }
            cambiarColor1();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(cambiarColor1));
            thread.Start();
        }
    }
}
