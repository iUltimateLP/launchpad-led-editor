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
    public partial class CustomColors : Form
    {
        public CustomColors()
        {
            InitializeComponent();
        }

        private void CustomColors_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
    }
}
