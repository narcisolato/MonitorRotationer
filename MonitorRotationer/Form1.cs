using System;
using System.Windows.Forms;

namespace MonitorRotationer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MonitorRotationer.ResetAllRotations();
        }

        private void M1Clock0_Click(object sender, EventArgs e)
        {
            MonitorRotationer.Rotate(1, MonitorRotationer.Orientations.DEGREES_CW_0);
        }

        private void M1Clock90_Click(object sender, EventArgs e)
        {
            MonitorRotationer.Rotate(1, MonitorRotationer.Orientations.DEGREES_CW_90);
        }

        private void M1Clock180_Click(object sender, EventArgs e)
        {
            MonitorRotationer.Rotate(1, MonitorRotationer.Orientations.DEGREES_CW_180);
        }

        private void M1Clock270_Click(object sender, EventArgs e)
        {
            MonitorRotationer.Rotate(1, MonitorRotationer.Orientations.DEGREES_CW_270);
        }

        private void M2Clock0_Click(object sender, EventArgs e)
        {
            MonitorRotationer.Rotate(2, MonitorRotationer.Orientations.DEGREES_CW_0);
        }

        private void M2Clock90_Click(object sender, EventArgs e)
        {
            MonitorRotationer.Rotate(2, MonitorRotationer.Orientations.DEGREES_CW_90);
        }

        private void M2Clock180_Click(object sender, EventArgs e)
        {
            MonitorRotationer.Rotate(2, MonitorRotationer.Orientations.DEGREES_CW_180);
        }

        private void M2Clock270_Click(object sender, EventArgs e)
        {
            MonitorRotationer.Rotate(2, MonitorRotationer.Orientations.DEGREES_CW_270);
        }
    }    
}