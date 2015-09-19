using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace Launchpad_LED_Editor
{
    public partial class CustomColors : Form
    {
        public CustomColorAdd colorsAddForm = new CustomColorAdd();
        public static Dictionary<string, Color> previewColors = new Dictionary<string, Color>();

        public MainForm insti;

        public CustomColors()
        {
            InitializeComponent();
            removeColor.Enabled = false;
            editColor.Enabled = false;

            if(File.Exists(@Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location)+"\\config.txt"))
            {
                Dictionary<string, int> configvalues = loadColorsFromConfig();
                for (int i = 0; i < configvalues.Count; i++)
                {
                    colorList.Items.Add(configvalues.ElementAt(i).Key).SubItems.Add(configvalues.ElementAt(i).Value.ToString());
                }
            }
            else
            {
                saveConfig();
            }
        }

        private void CustomColors_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
            insti.UpdateCustomColors();
        }

        private void addColor_Click(object sender, EventArgs e)
        {
            addColor.Enabled = false;
            removeColor.Enabled = false;
            colorsAddForm.OpenForAdd();
            colorsAddForm.instigator = this;
        }

        private void removeColor_Click(object sender, EventArgs e)
        {
            previewColors.Remove(colorList.SelectedItems[0].Text);
            colorList.Items.Remove(colorList.SelectedItems[0]);
            saveConfig();
            insti.UpdateCustomColors();
        }

        private void editColor_Click(object sender, EventArgs e)
        {
            addColor.Enabled = false;
            removeColor.Enabled = false;
            colorsAddForm.OpenForEdit(colorList.SelectedItems[0], previewColors[colorList.SelectedItems[0].Text]);
            colorsAddForm.instigator = this;
        }

        public void addCustomColor(string name, int velo, Color previewColor)
        {
            colorList.Items.Add(name);
            colorList.Items[colorList.Items.Count-1].SubItems.Add(velo.ToString());

            previewColors.Add(name, previewColor);

            saveConfig();

            insti.UpdateCustomColors();
        }

        public void editCustomColor(int index, string name, int velo, Color previewColor)
        {
            colorList.Items[index].SubItems[0].Text = name;
            colorList.Items[index].SubItems[1].Text = velo.ToString();

            previewColors[name] = previewColor;

            saveConfig();

            insti.UpdateCustomColors();
        }

        public void addFormClosed()
        {
            addColor.Enabled = true;
            removeColor.Enabled = true;
        }

        public static Dictionary<string,int> loadColorsFromConfig()
        {
            string path = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            if (File.Exists(@path+"\\config.txt"))
            {
                string[] read = File.ReadAllLines(@path + "\\config.txt");
                List<string> vars = new List<string>();
                Dictionary<string, int> final = new Dictionary<string, int>();
                

                foreach(string s in read)
                {
                    if (Array.IndexOf(read,s) >= 4)
                    {
                        vars.Add(s);
                    }
                }
                foreach(string str in vars)
                {
                    string[] sub = str.Split(Char.Parse("#"));
                    string[] sub2 = sub[1].Split(Char.Parse("^"));
                    final.Add(sub[0], int.Parse(sub2[0]));

                    int pFrom = sub2[1].IndexOf("[") + "[".Length;
                    int pTo = sub2[1].LastIndexOf("]");

                    String result = sub2[1].Substring(pFrom, pTo - pFrom);

                    if (result.Contains("A=") && result.Contains("R=") && result.Contains("G=") && result.Contains("B="))
                    {
                        //A=255, R=255, G=128, B=0
                        Regex r1 = new Regex(@"A=([0-9\-]+),");
                        Regex r2 = new Regex(@"R=([0-9\-]+),");
                        Regex r3 = new Regex(@"G=([0-9\-]+),");
                        Regex r4 = new Regex(@"B=([0-9\-]+)");

                        Match m1 = r1.Match(result);
                        Match m2 = r2.Match(result);
                        Match m3 = r3.Match(result);
                        Match m4 = r4.Match(result);

                        if (m1.Success && m2.Success && m3.Success && m4.Success)
                        {
                            string v1 = m1.Groups[1].Value;
                            string v2 = m2.Groups[1].Value;
                            string v3 = m3.Groups[1].Value;
                            string v4 = m4.Groups[1].Value;
                            previewColors[sub[0]] = Color.FromArgb(int.Parse(v1), int.Parse(v2), int.Parse(v3), int.Parse(v4));
                        }
                    }
                    else
                    {
                        previewColors[sub[0]] = Color.FromName(result);
                    }
                }
                return final;
            }
            else
            {
                return null;
            }
        }

        public void saveConfig()
        {
            string path = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            if (File.Exists(path+"\\config.txt"))
            {
                File.Delete(@path + "\\config.txt");
                saveConfig();
            }
            else
            {
                string[] intro = { "Launchpad LED editor config file", "v1.0" , "<== DO NOT MODIFY PARTS OF THIS FILE MANUALLY! THIS CAN CAUSE THE APPLICATION TO WORK WRONG! ==>", "" };
                File.WriteAllLines(@path + "\\config.txt", intro);
                foreach (ListViewItem i in colorList.Items)
                {
                    string[] lines = { i.Text + "#" + i.SubItems[1].Text + "^" + previewColors[i.Text]};
                    File.AppendAllLines(@path + "\\config.txt", lines);
                }
            }
        }

        private void colorList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (colorList.SelectedItems.Count == 1)
            {
                removeColor.Enabled = true;
                editColor.Enabled = true;
            }
            else
            {
                removeColor.Enabled = false;
                editColor.Enabled = false;
            }
        }

        private void colorList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            addColor.Enabled = false;
            removeColor.Enabled = false;
            colorsAddForm.OpenForEdit(colorList.SelectedItems[0], previewColors[colorList.SelectedItems[0].Text]);
            colorsAddForm.instigator = this;
        }
    }
}
