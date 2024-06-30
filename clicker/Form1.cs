using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace clicker
{
    public partial class Form1 : Form
    {
        int mainx;
        int mainy;
        bool start = false;
        public Form1()
        {
            InitializeComponent();
        }



        private void btnclick_Click(object sender, EventArgs e)
        {
            int number;
            if (lblnumber.Text == "Number of click")
            {
                number = 0;
                lblnumber.Text = number.ToString();
            }
            else
            {
                number = int.Parse(lblnumber.Text);
                number++;
                lblnumber.Text = number.ToString();
            }

        }
 
        private void tracker()
        {
            while (true)
            {
                int pointx = Cursor.Position.X;
                int pointy = Cursor.Position.Y;

                lblx.Invoke((MethodInvoker)(() => lblx.Text = pointx.ToString()));
                lbly.Invoke((MethodInvoker)(() => lbly.Text = pointy.ToString()));
                Thread.Sleep(2000);
            }
        }

        private void press()
        {
            while (true)
            {
                if (GetAsyncKeyState(resumeid) < 0)
                {
                    start = true;
                    Thread mouse_click = new Thread(mouseclick);
                    mainx =int.Parse(lblx.Text); 
                    mainy = int.Parse(lbly.Text);
                    LblStart.ForeColor = Color.Green;
                    lblStop.ForeColor = Color.Red;
                    mouse_click.Start();
                }
                if (GetAsyncKeyState(stopid) < 0)
                {
                    start = false;
                    LblStart.ForeColor = Color.Red;
                    lblStop.ForeColor = Color.Green;
                    Thread mouse_click = new Thread(mouseclick);
                    mouse_click.Abort();
                }
            }
        }
        [DllImport("user32.dll")]
        static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData, IntPtr dxExteraInfo);
        [DllImport("user32.dll")]
        static extern short GetAsyncKeyState(int vkey);



        const uint leftdown = 0x02;
        const uint leftup = 0x04;
        const int resumeid = 0x52;
        const int stopid = 0x53;

        void mouseclick()
        {
            while (start == true)
            {
                Random rnd = new Random();
                int randomx = rnd.Next(5, 30);
                int randomy = rnd.Next(5, 30);
                int back_or_forward = rnd.Next(1, 5);
                int x=mainx;
                int y=mainy;
                switch(back_or_forward)
                {
                    case 1:
                        {
                            x = x - randomx;
                            y = y - randomy;
                            break;
                        }
                    case 2:
                        {
                            x = x + randomx;
                            y = y + randomy;
                            break;
                        }
                    case 3:
                        {
                            x = x - randomx;
                            y = y + randomy;
                            break;
                        }
                    case 4:
                        {
                            x = x + randomx;
                            y = y - randomy;
                            break;
                        }

                }
                Point mainpoint = new Point(mainx, mainy);
                Cursor.Position = mainpoint;
                Point randompoint = new Point(x, y);
                Cursor.Position = randompoint;
                mouse_event(leftdown, 0, 0, 0, IntPtr.Zero);
                mouse_event(leftup, 0, 0, 0, IntPtr.Zero);
                Thread.Sleep((int)numInterval.Value);
            }

        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            Thread track = new Thread(tracker);
            track.Start();

            Thread start = new Thread(press);
            start.Start();
        }
    }
}
