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

namespace Launchpad_LED_Editor
{
    public partial class MainForm : Form
    {
        public bool isTesting = false;
        public bool testing_recieve_passed = false;
        public bool testing_sending_passed = false;
        public Models currentModel = Models.Launchpad;

        private TestingForm testingform = new TestingForm();

        public Launchpad _launchpadMk1 = new Launchpad(Models.Launchpad, "Launchpad");
        public Launchpad _launchpadMk2 = new Launchpad(Models.LaunchpadMk2, "Launchpad MK2");
        public Launchpad _launchpadPro = new Launchpad(Models.LaunchpadPro, "Launchpad Pro");
        public Launchpad _launchpadMini = new Launchpad(Models.LaunchpadMini, "Launchpad Mini");
        public Launchpad _launchpadS = new Launchpad(Models.LaunchpadS, "Launchpad S");

        public Panel[,] ledPanels = new Panel[8, 8];

        public Color currentPaintingColor;

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
                Console.WriteLine("Input selected but it is already targetted");
            }
            else
            {
                if (DeviceManager.targetInput != null && DeviceManager.targetInput.IsOpen) //Input is valid and open?
                {
                    Console.WriteLine("Closing already open device and opting in another one!");
                    DeviceManager.targetInput.Close(); //Closing old
                    DeviceManager.targetInput = null; //Resetting it
                    updateStatusLabel();
                }
                DeviceManager.targetInput = selected; //Setting new input
                DeviceManager.targetInput.Open(); //Opening it
                updateStatusLabel();
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
                Console.WriteLine("Input selected but it is already targetted");
            }
            else
            {
                if (DeviceManager.targetOutput != null && DeviceManager.targetOutput.IsOpen) //Output is valid and open?
                {
                    Console.WriteLine("Closing already open device and opting in another one!");
                    DeviceManager.targetOutput.Close(); //Closing old
                    DeviceManager.targetOutput = null; //Resetting it
                    updateStatusLabel();
                }
                DeviceManager.targetOutput = selected; //Setting new input
                DeviceManager.targetOutput.Open(); //Opening it
                ResetAllNotes();
                updateStatusLabel();
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
            //DeviceManager.targetInput.StopReceiving();
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
            Console.WriteLine("MIDI NOTE ON RECEIVED! NOTE: " + msg.Pitch + " VELOCITY: " + msg.Velocity + " TIME: " + msg.Time);
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

        }

        public void populateLEDs(int sizex, int sizey)
        {
            for (int i = 0; i < sizex; i++)
            {
                for (int f = 0; f < sizey; f++)
                {
                    Panel panel = new Panel();
                    panel.Name = "led_" + i + "_" + f;
                    panel.BackColor = Color.Gray;
                    panel.Location = new Point(5 + (i * 52), 12 + (f * 52));
                    panel.Size = new Size(50, 50);
                    panel.Click += new EventHandler(led_click);
                    ledPanels[i, f] = panel;
                    ledGroup.Controls.Add(panel);
                    
                }
            }
        }

        private void led_click(object sender, EventArgs e)
        {
            Panel some = sender as Panel;

            string[] split = some.Name.Split('_');
            int led_x = int.Parse(split[1]);
            int led_y = int.Parse(split[2]);
            Pitch led_pitch = DeviceManager.matrixToNote(led_y, led_x);

            if (DeviceManager.targetOutput != null && DeviceManager.targetOutput.IsOpen)
            {
                DeviceManager.targetOutput.SendNoteOn(0, led_pitch, DeviceManager.colorToVelo(currentPaintingColor));
                Console.WriteLine("Painting color is " + currentPaintingColor.ToString());
                some.BackColor = currentPaintingColor;
            }
        }

        //Colors

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

        public void updateColor(Color color)
        {
            panel_currentColor.BackColor = color;
            currentPaintingColor = color;
        }
    }
}
