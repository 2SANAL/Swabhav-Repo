
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ConsoleFromApp
{
    class WelcomeFrom1:Form
    {
        private Button button = new Button();


        public WelcomeFrom1()
        {
            this.Text = "Sanal";
            this.BackColor = Color.Chartreuse;
            this.Height = 768;
            this.Width = 1024;

            button.Text = "Submit";
            button.BackColor = Color.AliceBlue;
            button.Location = new Point(30, 25); ;
            this.Controls.Add(button);
            button.Click += HelloHandler;
            button.Click += GoodByHandler;

        }
        void HelloHandler(object sender, EventArgs e)
        {
            Console.WriteLine("Hello");
        }
        void GoodByHandler(object sender, EventArgs e)
        {
            Console.WriteLine("Good By");
        }


    }
}
