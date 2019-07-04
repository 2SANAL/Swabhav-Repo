using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace SyncAsynThreadApp
{
    class Synchronus : Form
    {
        private readonly Button _helloBtn;
        private readonly Button _printBtn;

        public Synchronus()
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
            while (true)
            {
                Console.WriteLine(new DateTime().Minute);
            }
        }

        private void _helloBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello");
        }
    }
}
