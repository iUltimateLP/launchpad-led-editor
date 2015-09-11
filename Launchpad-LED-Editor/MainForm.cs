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
using Midi;

namespace Launchpad_LED_Editor
{
    public partial class MainForm : Form
    {
        public bool isTesting = false;
        public bool testing_recieve_passed = false;
        public bool testing_sending_passed = false;

        private TestingForm testingform = new TestingForm();

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

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            DeviceManager.targetOutput.SendNoteOn(0, Pitch.E3, (int)numericUpDown1.Value);
        }
    }
}
