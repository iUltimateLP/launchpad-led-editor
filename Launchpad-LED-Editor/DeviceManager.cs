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

        #region LaunchpadData
        //Which key equals which note?
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

        public static Pitch[,] sessionNotesS = new Pitch[8, 8] {
            { Pitch.E3, Pitch.F3, Pitch.FSharp3, Pitch.G3, Pitch.C6, Pitch.CSharp6, Pitch.D6, Pitch.DSharp6 },
            { Pitch.C3, Pitch.CSharp3, Pitch.D3, Pitch.DSharp3, Pitch.GSharp5, Pitch.A5, Pitch.ASharp5, Pitch.B5 },
            { Pitch.GSharp2, Pitch.A2, Pitch.ASharp2, Pitch.B2, Pitch.E5, Pitch.F5, Pitch.FSharp5, Pitch.G5 },
            { Pitch.E2, Pitch.F2, Pitch.FSharp2, Pitch.G2, Pitch.C5, Pitch.CSharp5, Pitch.D5, Pitch.DSharp5 },
            { Pitch.C2, Pitch.CSharp2, Pitch.D2, Pitch.DSharp2, Pitch.GSharp4, Pitch.A4, Pitch.ASharp4, Pitch.B4 },
            { Pitch.GSharp1, Pitch.A1, Pitch.ASharp1, Pitch.B1, Pitch.E4, Pitch.F4, Pitch.FSharp4, Pitch.G4 },
            { Pitch.E1, Pitch.F1, Pitch.FSharp1, Pitch.G1, Pitch.C4, Pitch.CSharp4, Pitch.D4, Pitch.DSharp4 },
            { Pitch.C1, Pitch.CSharp1, Pitch.D1, Pitch.DSharp1, Pitch.GSharp3, Pitch.A3, Pitch.ASharp3, Pitch.B3 },
        };

        public static Pitch[] sideLEDnotes = new Pitch[]
        {
            Pitch.F6, Pitch.G5, Pitch.A4, Pitch.B3, Pitch.CSharp3, Pitch.DSharp2, Pitch.F1, Pitch.G0

        };

        public static Pitch[] sideLEDnotesS = new Pitch[]
        {
            Pitch.E6, Pitch.F6, Pitch.FSharp6, Pitch.G6, Pitch.GSharp6, Pitch.A6, Pitch.ASharp6, Pitch.B6
        };

        public enum LaunchpadModels
        {
            LaunchpadS,
            LaunchpadPro,
            LaunchpadMini,
            LaunchpadMk2
        }

        //Launchpad MK2, Pro, 
        public static Dictionary<string, int> LaunchpadMk2Colors = new Dictionary<string, int> {
            {"Red", 72},
            {"Green", 63},
            {"Yellow", 13},
            {"Orange", 9},
            {"Blue", 41},
            {"LightBlue", 36},
            {"White", 3},
            {"Lime", 17}
        };

        //Launchpad S, Mini
        public static Dictionary<string, int> LaunchpadSColors = new Dictionary<string, int> {
            {"Red", 15},
            {"Green", 60},
            {"Yellow", 62},
            {"Orange", 47},
            {"Lime", 61}
        };

        //Available Default Colors
        public enum LaunchpadColor
        {
            Red,
            Green,
            Yellow,
            Orange,
            Blue,
            LightBlue,
            White,
            Lime
        }

        public static int devid = 0;
        #endregion

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

        public static Pitch matrixToNote(int x, int y, LaunchpadModels model)
        {
            switch (model)
            {
                case LaunchpadModels.LaunchpadS:
                    return sessionNotesS[x, y];
                    break;
                case LaunchpadModels.LaunchpadPro:
                    return sessionNotes[x, y];
                    break;
                case LaunchpadModels.LaunchpadMini:
                    return sessionNotesS[x, y];
                    break;
                case LaunchpadModels.LaunchpadMk2:
                    return sessionNotes[x, y];
                    break;
                default:
                    return Pitch.A0;
                    break;
            }
        }

        public static Pitch matrixToSideLEDs(int x, int y, LaunchpadModels model)
        {
            switch (model)
            {
                case LaunchpadModels.LaunchpadS:
                    return sideLEDnotesS[y];
                    break;
                case LaunchpadModels.LaunchpadPro:
                    return sideLEDnotes[y];
                    break;
                case LaunchpadModels.LaunchpadMini:
                    return sideLEDnotesS[y];
                    break;
                case LaunchpadModels.LaunchpadMk2:
                    return sideLEDnotes[y];
                    break;
                default:
                    return Pitch.A0;
                    break;
            }
        }

        public static int colorToVelo(Color color, LaunchpadModels model)
        {
            switch (model)
            {
                case LaunchpadModels.LaunchpadS:
                    devid = 1;
                    break;
                case LaunchpadModels.LaunchpadPro:
                    devid = 2;
                    break;
                case LaunchpadModels.LaunchpadMini:
                    devid = 1;
                    break;
                case LaunchpadModels.LaunchpadMk2:
                    devid = 2;
                    break;
                default:
                    break;
            }
            if (devid == 1 && LaunchpadSColors.ContainsKey(color.Name))
            {
                return LaunchpadSColors[color.Name];
            }
            else if (devid == 2 && LaunchpadMk2Colors.ContainsKey(color.Name))
            {
                return LaunchpadMk2Colors[color.Name];                
            }
            else if (CustomColors.previewColors.ContainsValue(color))
            {
                Dictionary<string, int> velos = CustomColors.loadColorsFromConfig();
                string name = CustomColors.previewColors.FirstOrDefault(x => x.Value == color).Key;
                return velos[name];
            }
            else
            {
                return 0;
            }
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