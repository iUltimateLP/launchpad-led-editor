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
    public partial class CustomColorAdd : Form
    {
        public CustomColors instigator;

        public int index;
        public int mode;

        public CustomColorAdd()
        {
            InitializeComponent();
        }

        public void OpenForAdd()
        {
            mode = 1;
            this.Show();
        }

        public void OpenForEdit(ListViewItem item, Color previewColor)
        {
            mode = 2;
            this.index = item.Index;
            this.Show();
            nameEdit.Text = item.Text;
            velocityEdit.Value = decimal.Parse(item.SubItems[1].Text);
            panel_previewColor.BackColor = previewColor;
            previewColorDialog.Color = previewColor;
        }

        public bool isColorOnlyGray(Color color)
        {
            int a = color.A;
            int r = color.R;
            int g = color.G;
            int b = color.B;
            if (r == g && g == b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool doesColorAlreadyExist(string name, Color color, decimal velo)
        {
            Dictionary<string, int> velos = CustomColors.loadColorsFromConfig();
            Dictionary<string, Color> colors = CustomColors.previewColors;
            int ivelo = (int)velo;

            if (velos.ContainsValue(ivelo))
            {
                return true;
            }
            
            if (colors.ContainsValue(color))
            {
                return true;
            }

            if (colors.ContainsKey(name) && velos.ContainsKey(name))
            {
                return true;
            }

            return false;
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            bool nameWrong = false;
            string nameWrongMessage = "The name cannot be empty! ";
            bool veloWrong = false;
            string veloWrongMessage = "The velocity cannot be zero! ";
            bool colorWrong = false;
            string colorWrongMessage = "The color cannot be any shade of gray! ";
            bool alreadyExisting = false;
            string alreadyExistingMessage = "This color already exists! ";
            string final = "The following errors occured: ";

            if (String.IsNullOrEmpty(nameEdit.Text))
                nameWrong = true;

            if (velocityEdit.Value == 0)
                veloWrong = true;

            if (isColorOnlyGray(panel_previewColor.BackColor))
                colorWrong = true;

            if (doesColorAlreadyExist(nameEdit.Text, panel_previewColor.BackColor, velocityEdit.Value))
                alreadyExisting = true;

            if (!nameWrong && !veloWrong && !colorWrong && !alreadyExisting)
            {
                if (mode == 1)
                {
                    instigator.addCustomColor(nameEdit.Text, (int)velocityEdit.Value, panel_previewColor.BackColor);
                    this.Hide();
                    instigator.addFormClosed();
                    nameEdit.Clear();
                    velocityEdit.Value = 0;
                }
                else if (mode == 2)
                {
                    instigator.editCustomColor(index, nameEdit.Text, (int)velocityEdit.Value, panel_previewColor.BackColor);
                    this.Hide();
                    instigator.addFormClosed();
                    nameEdit.Clear();
                    velocityEdit.Value = 0;
                    index = 0;
                }
            }
            else
            {
                switch (nameWrong)
                {
                    case true:
                        final = final + nameWrongMessage;
                        break;
                    case false:
                        break;
                    default:
                        break;
                }

                switch (veloWrong)
                {
                    case true:
                        final = final + veloWrongMessage;
                        break;
                    case false:
                        break;
                    default:
                        break;
                }

                switch (colorWrong)
                {
                    case true:
                        final = final + colorWrongMessage;
                        break;
                    case false:
                        break;
                    default:
                        break;
                }

                switch (alreadyExisting)
                {
                    case true:
                        final = final + alreadyExistingMessage;
                        break;
                    case false:
                        break;
                    default:
                        break;
                }

                error.Show(final, nameEdit);
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            instigator.addFormClosed();
            nameEdit.Clear();
            velocityEdit.Value = 0;
            index = 0;
            panel_previewColor.BackColor = Color.Black;
        }

        private void panel_previewColor_Click(object sender, EventArgs e)
        {
            panel_previewColor.Enabled = false;
            previewColorDialog.ShowDialog();
            panel_previewColor.Enabled = true;
            panel_previewColor.BackColor = previewColorDialog.Color;
        }

        private void CustomColorAdd_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
            instigator.addFormClosed();
            nameEdit.Clear();
            velocityEdit.Value = 0;
            index = 0;
            panel_previewColor.BackColor = Color.Black;
        }
    }
}
