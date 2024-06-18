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
            if (lblnumber.Text == "تعداد کلیک")
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

        private void btnautoclick_Click(object sender, EventArgs e)
        {
           


            //Thread trackertread = new Thread(tracker);
            //label1.Text = Cursor.Position.X.ToString();
            //label2.Text = Cursor.Position.Y.ToString();
            //mainx = Cursor.Position.X;
            //mainy = Cursor.Position.Y;
            //trackertread.Start();




            //Thread mouse_click = new Thread(mouseclick);
            //mouse_click.Start();

        }
        //private void tracker()
        //{
        //    while (start == true)
        //    {
        //        int pointx = Cursor.Position.X;
        //        int pointy = Cursor.Position.Y;

        //        label1.Invoke((MethodInvoker)(() => label1.Text = pointx.ToString()));
        //        label2.Invoke((MethodInvoker)(() => label2.Text = pointy.ToString()));
        //        Thread.Sleep(2000);
        //    }
        //}

        private void press()
        {
            while (true)
            {
                if (GetAsyncKeyState(resumeid) < 0)
                {
                    start = true;
                    Thread mouse_click = new Thread(mouseclick);
                    mainx = Cursor.Position.X; 
                    mainy = Cursor.Position.Y;
                    mouse_click.Start();
                }
                if (GetAsyncKeyState(stopid) < 0)
                {
                    start = false;
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
                int randomx = rnd.Next(10, 30);
                int randomy = rnd.Next(10, 30);
                int back_or_forward = rnd.Next(1, 3);
                int x=mainx;
                int y=mainy;
                if (back_or_forward == 1)
                {
                    x = x - randomx;
                    y = y - randomy;
                }
                else if (back_or_forward == 2)
                {
                    x = x + randomx;
                    y = y + randomy;
                }
                Point mainpoint = new Point(mainx, mainy);
                uint pointx = (uint)(int)mainx;
                uint pointy = (uint)(int)mainy;
                Point randompoint = new Point(x, y);
                Cursor.Position = randompoint;
                mouse_event(leftdown, 0, 0, 0, IntPtr.Zero);
                mouse_event(leftup, 0, 0, 0, IntPtr.Zero);
                Thread.Sleep(2000);
            }

        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            Thread start = new Thread(press);
            start.Start();
        }
    }
}
