using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnippetGenerator
{
    public partial class ToastNotification : Form
    {
        int timerCounter = 0;
        public ToastNotification(string ToastMessage, Point LocationOfSender)
        {
            InitializeComponent();
            lblToastMessage.Text = ToastMessage;
            this.Location = LocationOfSender;
        }

        private void ToastNotification_Load(object sender, EventArgs e)
        {
            tmrToastTimer.Enabled = true;
        }

        private void tmrToastTimer_Tick(object sender, EventArgs e)
        {
            timerCounter += tmrToastTimer.Interval;
            if(timerCounter < 750)
            {   
                this.Opacity += 0.07;
            }
            else if(timerCounter <= 1500)
            {
                this.Opacity -= 0.07;
            }
            else
            {
                this.Close();
            }
        }
    }
}
