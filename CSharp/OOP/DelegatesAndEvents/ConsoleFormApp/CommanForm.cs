using System;
using System.Drawing;
using System.Windows.Forms;

namespace ConsoleFormApp
{
   public class CommanForm : Form
    {
       
        
            private Button _redButton = new Button();
            private Button _blueButton = new Button();

            public CommanForm()
            {
                this.Text = "CommanForm";
                this.Height = 768;
                this.Width = 1024;

                _redButton.Text = "Red";
                _redButton.BackColor = Color.Red;
                _redButton.Location = new Point(30, 95); ;
                _redButton.Click += SetBackGroundColor;

                _blueButton.Text = "Blue";
                _blueButton.BackColor = Color.Blue;
                _blueButton.Location = new Point(30, 50);
                _blueButton.Click += SetBackGroundColor;

                this.Controls.Add(_blueButton);
                this.Controls.Add(_redButton);

            }
            private void SetBackGroundColor(object sender, EventArgs e)
            {
                if (sender.Equals(_redButton))
                {
                    this.BackColor = Color.Red;
                }
                if (sender.Equals(_blueButton))
                {
                    this.BackColor = Color.Blue;
                }
            }
        }
    }

