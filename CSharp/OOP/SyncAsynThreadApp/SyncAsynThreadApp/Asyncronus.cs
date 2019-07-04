using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Drawing;
using System.Windows.Forms;

namespace SyncAsynThreadApp
{
    class Asyncronus:Form
    {
        private readonly Button _helloBtn;
        private readonly Button _printBtn;
        private  Thread _thread;
        public Asyncronus()
        {
            _helloBtn = new Button();
            _helloBtn.Text = "Hello";
            _helloBtn.Location = new Point(20, 150);
            _helloBtn.Click += _helloBtn_Click;

            _printBtn = new Button();
            _printBtn.Text = "Print";
            _printBtn.Location = new Point(20, 190);
            _printBtn.Click += _printBtn_Click; ;
            Controls.Add(_printBtn);
            Controls.Add(_helloBtn);

        }

        private void _printBtn_Click(object sender, EventArgs e)
        {
            _thread = new Thread(new ThreadStart(printDateTime));

            _thread.Start();

        }
        private void printDateTime()
        {
            while (true)
            {
               
                
                    Console.WriteLine(new DateTime().TimeOfDay);
                
                
            }
           
        }

        private void _helloBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello");
        }
    }
}