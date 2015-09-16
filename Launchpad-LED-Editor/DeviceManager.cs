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

        public static Pitch[,] sessionNotes = new Pitch[8, 8] {
            { Pitch.A5, Pitch.ASharp5, Pitch.B5, Pitch.C6, Pitch.CSharp6, Pitch.D6, Pitch.DSharp6, Pitch.E6 },
            { Pitch.B4, Pitch.C5, Pitch.CSharp5, Pitch.D5, Pitch.DSharp5, Pitch.E5, Pitch.F5, Pitch.FSharp5 },
            { Pitch.CSharp4, Pitch.D4, Pitch.DSharp4, Pitch.E4, Pitch.F4, Pitch.FSharp4, Pitch.G4, Pitch.GSharp4 },
            { Pitch.DSharp3, Pitch.E3, Pitch.F3, Pitch.FSharp3, Pitch.G3, Pitch.GSharp3, Pitch.A3, Pitch.ASharp3 },
            { Pitch.F2, Pitch.FSharp2, Pitch.G2, Pitch.GSharp2, Pitch.A2, Pitch.ASharp2, Pitch.B2, Pitch.C3 },
            { Pitch.G1, Pitch.GSharp1, Pitch.A1, Pitch.ASharp1, Pitch.B1, Pitch.C2, Pitch.CSharp2, Pitch.D2 },
            { Pitch.A0, Pitch.ASharp0, Pitch.B0, Pitch.C1, Pitch.CSharp1, Pitch.D1, Pitch.DSharp1, Pitch.E1 },
            { Pitch.BNeg1, Pitch.C0, Pitch.CSharp0, Pitch.D0, Pitch.DSharp0, Pitch.E0, Pitch.F0, Pitch.FSharp0 }
        };

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

        public static Pitch matrixToNote(int x, int y)
        {
            return sessionNotes[x, y];
        }

        public static int colorToVelo(Color color)
        {
            if (color == Color.Red)
                return 72;
            if (color == Color.Green)
                return 63;
            if (color == Color.Yellow)
                return 13;
            if (color == Color.Orange)
                return 9;
            if (color == Color.Blue)
                return 41;
            if (color == Color.LightBlue)
                return 36;
            if (color == Color.White)
                return 3;
            if (color == Color.Lime)
                return 17;
            else
                return 0;
        }

        public static byte[] stringToAscii(string str)
        {
            //http://stackoverflow.com/questions/5348844/how-to-convert-a-string-to-ascii
            List<byte> curList = new List<byte>();
            foreach(char c in str)
            {
                int unicode = c;
                if (unicode < 128)
                {
                    curList.Add(System.Convert.ToByte(unicode));
                }
            }
            byte[] cur = curList.ToArray();
            return cur;
        }
    }
}