using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Launchpad_LED_Editor
{
    public partial class TestingForm : Form
    {
        public bool visible = false;

        public TestingForm()
        {
            InitializeComponent();
        }

        public void setTestProgress(int pid)
        {
            if (pid == 1)
            {
                test_1.ForeColor = Color.LimeGreen;
            }
            else if (pid == 2)
            {
                test_2.ForeColor = Color.LimeGreen;
            }
            else if (pid == 3)
            {
                test_3.ForeColor = Color.LimeGreen;
            }
        }

        public void resetTestProgress()
        {
            test_1.ForeColor = Color.Gold;
            test_2.ForeColor = Color.Gold;
            test_3.ForeColor = Color.Gold;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Make sure the following points:\n1. Your device is correctly installed (drivers, etc..)\n2. Its working in other applications like Ableton."
                , "Make sure", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
