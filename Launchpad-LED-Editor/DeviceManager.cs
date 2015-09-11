using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Midi;

/*
DeviceManager.cs
Combines basic MIDI functions
*/

namespace Launchpad_LED_Editor
{
    public class DeviceManager
    {
        public static InputDevice targetInput = null;
        public static OutputDevice targetOutput = null;

        //Function to return all MIDI input devices
        public static InputDevice[] GetAllInputDevices()
        {
            return InputDevice.InstalledDevices.ToArray();
        }

        //Function to return all MIDI output devices
        public static OutputDevice[] GetAllOutputDevices()
        {
            return OutputDevice.InstalledDevices.ToArray();
        }

        //Function to get any input device by specifying a name
        public static InputDevice GetInputDeviceByName(string name)
        {
            foreach (InputDevice item in GetAllInputDevices())
            {
                if (item.Name == name)
                {
                    return item;
                }
            }
            return null;
        }

        //Function to get any output device by specifying a name
        public static OutputDevice GetOutputDeviceByName(string name)
        {
            foreach (OutputDevice item in GetAllOutputDevices())
            {
                if (item.Name == name)
                {
                    return item;
                }
            }
            return null;
        }
    }
}