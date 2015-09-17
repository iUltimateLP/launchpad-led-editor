using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Input;
using Midi;
using System.Drawing.Drawing2D;

namespace Launchpad_LED_Editor
{

    public partial class MainForm : Form
    {
        public bool isTesting = false;
        public bool testing_recieve_passed = false;
        public bool testing_sending_passed = false;

        private TestingForm testingform = new TestingForm();
        private CustomColors colorsform = new CustomColors();

        public Panel[,] ledPanels = new Panel[8, 8];

        public Color currentPaintingColor;

        public byte[] sysex_header = { 240, 00, 32, 41, 2, 24}; //The SysEx header used for every launchpad message
        public byte[] sysex_end = { 247 }; //The SysEx end byte

        public bool isScrolling = false;
        public bool isScrollLooping = false;

        public List<DeviceManager.LaunchpadColor> availableColors = new List<DeviceManager.LaunchpadColor>();

        public MainForm()
        {
            InitializeComponent();

            updateStatusLabel();
    
            //Populate Input/Output combo boxes
            foreach (InputDevice idevice in DeviceManager.GetAllInputDevices())
            {
                midi_inputDevices.Items.Add(idevice.Name);
            }

            foreach (OutputDevice odevice in DeviceManager.GetAllOutputDevices())
            {
                midi_outputDevices.Items.Add(odevice.Name);
            }

            populateLEDs(8, 8);

            updateColor(Color.Gray);

            mainToolTip.SetToolTip(midi_inputDevices, "Shows available input devices.");
            mainToolTip.SetToolTip(midi_outputDevices, "Shows available output devices.");
            mainToolTip.SetToolTip(midi_InputState, "Shows actual state of MIDI input device");
            mainToolTip.SetToolTip(midi_OutputState, "Shows actual state of MIDI output device.");
            mainToolTip.SetToolTip(midi_testDevices, "Tests, if your Launchpad works correctly.");
            mainToolTip.SetToolTip(launchpadModels, "Select your Launchpad model in here, so colors can be automaticially set up for you.");
            mainToolTip.SetToolTip(scroll_Text, "The text you want to scroll");
            mainToolTip.SetToolTip(scroll_Speed, "The speed of scrolling. 1 = Slow, 7 = Fast, the default is 4.");
            mainToolTip.SetToolTip(scroll_Loop, "If you want to loop it.");
            mainToolTip.SetToolTip(scroll_Start, "Start scrolling");
            mainToolTip.SetToolTip(scroll_Stop, "Stop scrolling");
        }

        public void updateStatusLabel()
        {
            //Input state
            if (DeviceManager.targetInput == null)
            {
                midi_InputState.Text = "No Device";
                midi_InputState.ForeColor = Color.Red;
            }
            else
            {
                if (DeviceManager.targetInput.IsOpen)
                {
                    midi_InputState.Text = "Ready";
                    midi_InputState.ForeColor = Color.LimeGreen;
                }
            }

            //Output state
            if (DeviceManager.targetOutput == null)
            {
                midi_OutputState.Text = "No Device";
                midi_OutputState.ForeColor = Color.Red;
            }
            else
            {
                if (DeviceManager.targetOutput.IsOpen)
                {
                    midi_OutputState.Text = "Ready";
                    midi_OutputState.ForeColor = Color.LimeGreen;
                }
            }
        }

        private void midi_inputDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Getting selected InputDevice with help of our DeviceManager
            InputDevice selected = DeviceManager.GetInputDeviceByName(midi_inputDevices.SelectedItem.ToString());
            if (selected == null)
            {
                MessageBox.Show("The device cannot be found.", "Strange error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (DeviceManager.targetInput == selected)
            {
                //Just in case that we have already selected it.
            }
            else
            {
                if (DeviceManager.targetInput != null && DeviceManager.targetInput.IsOpen) //Input is valid and open?
                {
                    DeviceManager.targetInput.Close(); //Closing old
                    DeviceManager.targetInput.SysEx += null;
                    DeviceManager.targetInput = null; //Resetting it
                    updateStatusLabel();
                }
                DeviceManager.targetInput = selected; //Setting new input
                DeviceManager.targetInput.Open(); //Opening it
                DeviceManager.targetInput.SysEx += new InputDevice.SysExHandler(SysExAnswer);
                updateStatusLabel();
                AutoDetectLaunchpad(true);
            }
        }

        private void midi_outputDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Getting selected OutputDevice with help of our DeviceManager
            OutputDevice selected = DeviceManager.GetOutputDeviceByName(midi_outputDevices.SelectedItem.ToString());
            if (selected == null)
            {
                MessageBox.Show("The device cannot be found.", "Strange error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (DeviceManager.targetOutput == selected)
            {
                //Just in case that we have already selected it.
            }
            else
            {
                if (DeviceManager.targetOutput != null && DeviceManager.targetOutput.IsOpen) //Output is valid and open?
                {
                    DeviceManager.targetOutput.Close(); //Closing old
                    DeviceManager.targetOutput = null; //Resetting it
                    updateStatusLabel();
                }
                DeviceManager.targetOutput = selected; //Setting new input
                DeviceManager.targetOutput.Open(); //Opening it
                ResetAllNotes();
                updateStatusLabel();
                AutoDetectLaunchpad(false);
            }
        }

        private void midi_testDevices_Click(object sender, EventArgs e)
        {
            if (DeviceManager.targetInput == null || DeviceManager.targetOutput == null)
            {
                MessageBox.Show("Select Devices first!.", "Silly you!.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                midi_testDevices.Enabled = false; //Disable button

                StartTesting();
            }
        }

        public void AutoDetectLaunchpad(bool isInput)
        {
            if (isInput)
            {
                if (DeviceManager.targetInput.Name == "Launchpad S")
                {
                    launchpadModels.SelectedItem = launchpadModels.Items[3];
                }
                else if (DeviceManager.targetInput.Name == "Launchpad MK2")
                {
                    launchpadModels.SelectedItem = launchpadModels.Items[0];
                }
                else if (DeviceManager.targetInput.Name == "Launchpad Mini")
                {
                    launchpadModels.SelectedItem = launchpadModels.Items[1];
                }
                else if (DeviceManager.targetInput.Name == "Launchpad Pro")
                {
                    launchpadModels.SelectedItem = launchpadModels.Items[2];
                }
                else
                {
                    MessageBox.Show("Your MIDI device does not seem to be a Launchpad. However, you can continue anyway.\nIf this is a fault, please write in the forum thread that you are experiencing this, and give him this MIDI Device Name: " + DeviceManager.targetInput.Name, "No Launchpad?", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (DeviceManager.targetOutput.Name == "Launchpad S")
                {
                    launchpadModels.SelectedItem = launchpadModels.Items[3];
                }
                else if (DeviceManager.targetOutput.Name == "Launchpad MK2")
                {
                    launchpadModels.SelectedItem = launchpadModels.Items[0];
                }
                else if (DeviceManager.targetOutput.Name == "Launchpad Mini")
                {
                    launchpadModels.SelectedItem = launchpadModels.Items[1];
                }
                else if (DeviceManager.targetOutput.Name == "Launchpad Pro")
                {
                    launchpadModels.SelectedItem = launchpadModels.Items[2];
                }
                else
                {
                    MessageBox.Show("Your MIDI device does not seem to be a Launchpad. However, you can continue anyway.\nIf this is a fault, please write in the forum thread that you are experiencing this, and give him this MIDI Device Name: " + DeviceManager.targetInput.Name, "No Launchpad?", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        public void StartTesting()
        {
            DeviceManager.targetInput.NoteOn += new InputDevice.NoteOnHandler(this.TestingNoteOn);
            DeviceManager.targetInput.StartReceiving(null);
            isTesting = true;
            testingform.Show();
        }

        public void EndTesting()
        {
            DeviceManager.targetInput.NoteOn += null;
            isTesting = false;
            if (testingform.InvokeRequired)
            {
                testingform.Invoke(new MethodInvoker(delegate { testingform.Hide(); DeviceManager.targetInput.StopReceiving(); midi_testDevices.Enabled = true; }));
            }
            testing_recieve_passed = false;
            testing_sending_passed = false;
        }

        public void TestingNoteOn(NoteOnMessage msg)
        {
            if (isTesting && testing_recieve_passed == false)
            {
                testing_recieve_passed = true;
                testingform.setTestProgress(1);
            }
            if (isTesting && testing_recieve_passed == true && testing_sending_passed == false)
            {
                DeviceManager.targetOutput.SendNoteOn(0, Pitch.E5, 127);
                if (msg.Pitch == Pitch.E5)
                {
                    testing_sending_passed = true;
                    testingform.setTestProgress(2);
                    ResetAllNotes();
                    Thread.Sleep(500);
                    testingform.setTestProgress(3);
                    Thread.Sleep(300);
                    testingform.resetTestProgress();
                    EndTesting();
                }
            }

        }

        public void ResetAllNotes()
        {
            foreach (Pitch p in Enum.GetValues(typeof(Pitch)))
            {
                DeviceManager.targetOutput.SendNoteOff(0, p, 127);
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Reset and close all 
            if (DeviceManager.targetInput != null)
            {
                DeviceManager.targetInput.Close();
            }
            if (DeviceManager.targetOutput != null)
            {
                ResetAllNotes();
                DeviceManager.targetOutput.Close();
            }
        }

        private void launchpadModels_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = launchpadModels.SelectedItem.ToString();

            switch (name)
            {
                case "Launchpad S":
                    availableColors.Clear();
                    availableColors.Add(DeviceManager.LaunchpadColor.Green);
                    availableColors.Add(DeviceManager.LaunchpadColor.Lime);
                    availableColors.Add(DeviceManager.LaunchpadColor.Orange);
                    availableColors.Add(DeviceManager.LaunchpadColor.Red);
                    availableColors.Add(DeviceManager.LaunchpadColor.Yellow);
                    updateColors();
                    break;
                case "Launchpad Mini":
                    availableColors.Clear();
                    availableColors.Add(DeviceManager.LaunchpadColor.Green);
                    availableColors.Add(DeviceManager.LaunchpadColor.Lime);
                    availableColors.Add(DeviceManager.LaunchpadColor.Orange);
                    availableColors.Add(DeviceManager.LaunchpadColor.Red);
                    availableColors.Add(DeviceManager.LaunchpadColor.Yellow);
                    updateColors();
                    break;
                case "Launchpad Pro":
                    availableColors.Clear();
                    availableColors.Add(DeviceManager.LaunchpadColor.Blue);
                    availableColors.Add(DeviceManager.LaunchpadColor.Green);
                    availableColors.Add(DeviceManager.LaunchpadColor.LightBlue);
                    availableColors.Add(DeviceManager.LaunchpadColor.Lime);
                    availableColors.Add(DeviceManager.LaunchpadColor.Orange);
                    availableColors.Add(DeviceManager.LaunchpadColor.Red);
                    availableColors.Add(DeviceManager.LaunchpadColor.White);
                    availableColors.Add(DeviceManager.LaunchpadColor.Yellow);
                    updateColors();
                    break;
                case "Launchpad MK2":
                    availableColors.Clear();
                    availableColors.Add(DeviceManager.LaunchpadColor.Blue);
                    availableColors.Add(DeviceManager.LaunchpadColor.Green);
                    availableColors.Add(DeviceManager.LaunchpadColor.LightBlue);
                    availableColors.Add(DeviceManager.LaunchpadColor.Lime);
                    availableColors.Add(DeviceManager.LaunchpadColor.Orange);
                    availableColors.Add(DeviceManager.LaunchpadColor.Red);
                    availableColors.Add(DeviceManager.LaunchpadColor.White);
                    availableColors.Add(DeviceManager.LaunchpadColor.Yellow);
                    updateColors();
                    break;
                default:
                    break;
            }
        }

        public void populateLEDs(int sizex, int sizey)
        {
            int seperator_x_width = 8; 
            int seperator_y_width = 3; // Should be x_width-5 to be symmetrical (5 cause of the margin)

            //Population of LEDs proceeds in 4 blocks: I, II, III, IV
            //Block I
            for (int i = 0; i < sizex/2; i++)
            {
                for (int f = 0; f < sizey/2; f++)
                {
                    Panel panel = new Panel();
                    panel.Name = "led_" + i + "_" + f;
                    panel.BackColor = Color.Gray;
                    panel.Location = new Point(5 + (i * 52), 12 + (f * 52));
                    panel.Size = new Size(50, 50);
                    panel.MouseDown += new MouseEventHandler(led_mouseDown);
                    panel.MouseMove += new MouseEventHandler(led_mouseMove);
                    ledPanels[i, f] = panel;
                    ledGroup.Controls.Add(panel);
                }
            }
            //Block II
            for (int i = sizex / 2; i < sizex; i++)
            {
                for (int f = 0; f < sizey/2; f++)
                {
                    Panel panel = new Panel();
                    panel.Name = "led_" + i + "_" + f;
                    panel.BackColor = Color.Gray;
                    panel.Location = new Point(seperator_x_width + (i * 52), 12 + (f * 52));
                    panel.Size = new Size(50, 50);
                    panel.MouseDown += new MouseEventHandler(led_mouseDown);
                    panel.MouseMove += new MouseEventHandler(led_mouseMove);
                    ledPanels[i, f] = panel;
                    ledGroup.Controls.Add(panel);
                }
            }
            //Block III
            for (int i = sizex/2; i < sizex; i++)
            {
                for (int f = sizey/2; f < sizey; f++)
                {
                    Panel panel = new Panel();
                    panel.Name = "led_" + i + "_" + f;
                    panel.BackColor = Color.Gray;
                    panel.Location = new Point(seperator_x_width + (i * 52), 12 + seperator_y_width + (f * 52));
                    panel.Size = new Size(50, 50);
                    panel.MouseDown += new MouseEventHandler(led_mouseDown);
                    panel.MouseMove += new MouseEventHandler(led_mouseMove);
                    ledPanels[i, f] = panel;
                    ledGroup.Controls.Add(panel);
                }
            }
            //Block IV
            for (int i = 0; i < sizex/2; i++)
            {
                for (int f = sizey/2; f < sizey; f++)
                {
                    Panel panel = new Panel();
                    panel.Name = "led_" + i + "_" + f;
                    panel.BackColor = Color.Gray;
                    panel.Location = new Point(5 + (i * 52), 12 + seperator_y_width + (f * 52));
                    panel.Size = new Size(50, 50);
                    panel.MouseDown += new MouseEventHandler(led_mouseDown);
                    panel.MouseMove += new MouseEventHandler(led_mouseMove);
                    ledPanels[i, f] = panel;
                    ledGroup.Controls.Add(panel);
                }
            }
        }

        private void led_mouseDown(object sender, MouseEventArgs e)
        {
            Panel p = sender as Panel;
            string[] split = p.Name.Split('_');
            int led_x = int.Parse(split[1]);
            int led_y = int.Parse(split[2]);
            Pitch led_pitch = DeviceManager.matrixToNote(led_y, led_x);

            if (e.Button == MouseButtons.Left)
            {
                if (DeviceManager.targetOutput != null && DeviceManager.targetOutput.IsOpen)
                {
                    DeviceManager.targetOutput.SendNoteOn(0, led_pitch, DeviceManager.colorToVelo(currentPaintingColor));
                    p.BackColor = currentPaintingColor;
                }

            }
            else if (e.Button == MouseButtons.Right)
            {
                if (DeviceManager.targetOutput != null && DeviceManager.targetOutput.IsOpen)
                {
                    DeviceManager.targetOutput.SendNoteOn(0, led_pitch, DeviceManager.colorToVelo(Color.Gray));
                    p.BackColor = Color.Gray;
                }
            }

            p.Capture = false;
        }

        private void led_mouseMove(object sender, MouseEventArgs e)
        {
            Panel p = sender as Panel;
            string[] split = p.Name.Split('_');
            int led_x = int.Parse(split[1]);
            int led_y = int.Parse(split[2]);
            Pitch led_pitch = DeviceManager.matrixToNote(led_y, led_x);

            if (e.Button == MouseButtons.Left)
            {
                if (DeviceManager.targetOutput != null && DeviceManager.targetOutput.IsOpen)
                {
                    DeviceManager.targetOutput.SendNoteOn(0, led_pitch, DeviceManager.colorToVelo(currentPaintingColor));
                    p.BackColor = currentPaintingColor;
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                if (DeviceManager.targetOutput != null && DeviceManager.targetOutput.IsOpen)
                {
                    DeviceManager.targetOutput.SendNoteOn(0, led_pitch, DeviceManager.colorToVelo(Color.Gray));
                    p.BackColor = Color.Gray;
                }
            }
        }

        //Colors
        #region ColorPanels
        private void panel_red_Click(object sender, EventArgs e)
        {
            updateColor(Color.Red);
        }

        private void panel_green_Click(object sender, EventArgs e)
        {
            updateColor(Color.Green);
        }

        private void panel_yellow_Click(object sender, EventArgs e)
        {
            updateColor(Color.Yellow);
        }

        private void panel_orange_Click(object sender, EventArgs e)
        {
            updateColor(Color.Orange);
        }

        private void panel_blue_Click(object sender, EventArgs e)
        {
            updateColor(Color.Blue);
        }

        private void panel_lightBlue_Click(object sender, EventArgs e)
        {
            updateColor(Color.LightBlue);
        }

        private void panel_white_Click(object sender, EventArgs e)
        {
            updateColor(Color.White);
        }

        private void panel_lime_Click(object sender, EventArgs e)
        {
            updateColor(Color.Lime);
        }

        private void panel_clear_Click(object sender, EventArgs e)
        {
            updateColor(Color.Gray);
        }
        #endregion
        public void updateColor(Color color)
        {
            panel_currentColor.BackColor = color;
            currentPaintingColor = color;
        }

        public void updateColors()
        {
            if (availableColors.Contains(DeviceManager.LaunchpadColor.Blue))
            {
                panel_blue.Enabled = true;
                panel_blue.BackColor = Color.Blue;
            }
            else
            {
                panel_blue.Enabled = false;
                panel_blue.BackColor = Color.LightGray;
            }
            if (availableColors.Contains(DeviceManager.LaunchpadColor.LightBlue))
            {
                panel_lightBlue.Enabled = true;
                panel_lightBlue.BackColor = Color.LightBlue;
            }
            else
            {
                panel_lightBlue.Enabled = false;
                panel_lightBlue.BackColor = Color.LightGray;
            }
            if (availableColors.Contains(DeviceManager.LaunchpadColor.White))
            {
                panel_white.Enabled = true;
                panel_white.BackColor = Color.White;
            }
            else
            {
                panel_white.Enabled = false;
                panel_white.BackColor = Color.LightGray;
            }
        }

        public void SysExAnswer(SysExMessage m)
        {
            byte[] message = m.Data;
            byte[] stopbytes = { 240, 0, 32, 41, 2, 24, 21, 247 };
            if (isScrolling)
            {
                if (Enumerable.SequenceEqual(message, stopbytes))
                {
                    if (isScrollLooping == false)
                    {
                        isScrollLooping = false;
                        isScrolling = false;
                    }
                }
                else
                    Console.WriteLine("SysEx received something, but not a Scrolling Stop Byte!");
            }
        }

        private void scroll_Start_Click(object sender, EventArgs e)
        {
            if (DeviceManager.targetOutput != null && isScrolling == false && String.IsNullOrEmpty(scroll_Text.Text) == false && currentPaintingColor != Color.Gray)
            {
                //Format: SysEx header + TextScroll Operation ID + Color + Loop + Speed + Text + SysEx end
                byte[] text = DeviceManager.stringToAscii(scroll_Text.Text);
                byte opid = 20;
                byte color = (byte)DeviceManager.colorToVelo(currentPaintingColor);
                byte loop = Convert.ToByte(scroll_Loop.Checked);
                byte speed = (byte)scroll_Speed.Value;
                byte[] args = { opid, color, loop, speed};
                byte[] final = sysex_header.Concat(args.Concat(text.Concat(sysex_end))).ToArray();

                foreach (byte item in final)
                {
                    Console.Write(item.ToString() + "-");
                }
                Console.WriteLine("");
                DeviceManager.targetOutput.SendSysEx(final);
                isScrolling = true;
                isScrollLooping = scroll_Loop.Checked;
                if (DeviceManager.targetInput.IsReceiving == false)
                    DeviceManager.targetInput.StartReceiving(null, true);
            }
        }

        private void scroll_Stop_Click(object sender, EventArgs e)
        {
            if (isScrolling)
            {
                byte[] stop = { 240, 0, 32, 41, 2, 24, 20, 247 };
                DeviceManager.targetOutput.SendSysEx(stop);
                isScrolling = false;
                isScrollLooping = false;
                DeviceManager.targetInput.StopReceiving();
            }
        }

        private void scroll_Text_TextChanged(object sender, EventArgs e)
        {
            string str = scroll_Text.Text;
            List<char> unsupportedChars = new List<char>();

            foreach (char c in str)
            {
                if ((int)c > 127)
                {
                    if (unsupportedChars.Contains(c) == false)
                    {
                        unsupportedChars.Add(c);
                        unsupportedChars.Add(",".ToCharArray()[0]); //Adding a comma here, to make view better!
                    }
                }
            }

            if (unsupportedChars.Count != 0)
            {
                string all = new string(unsupportedChars.ToArray());
                errorBubble.Show("The following letters are unsupported: " + all, scroll_Text, scroll_Text.Width, 0, 2000);
                System.Media.SystemSounds.Asterisk.Play();
            }
        }

        private void transparentPanel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.HighQuality;

            Rectangle r1 = new Rectangle(10, 15, 25, 25);

            Gfx.RotateRect(g, r1, 45, Color.Black);
        }

        private void timer_UpdateCenter_Tick(object sender, EventArgs e)
        {
            transparentPanel1.Hide();
            transparentPanel1.Show();
        }

        private void colors_Edit_Click(object sender, EventArgs e)
        {
            colorsform.Show();
            colorsform.ShowInTaskbar = false;
            colors_Edit.Enabled = false;
            timer_checkColorWindow.Enabled = true;
        }

        private void timer_checkColorWindow_Tick(object sender, EventArgs e)
        {
            if (colorsform.Visible == false)
            {
                colors_Edit.Enabled = true;
                timer_checkColorWindow.Enabled = false;
            }
        }
    }
}
