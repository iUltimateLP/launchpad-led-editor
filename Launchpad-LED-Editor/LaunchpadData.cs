using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Launchpad_LED_Editor
{
    public enum Colors
    {
        Black,
        Green,
        Blue,
        LightBlue,
        Magenta,
        Pink,
        Orange,
        DarkGreen,
        Red,
        White,
        Lime
    }

    public class Launchpad
    {
        public Models model;
        public string name;
        public Launchpad(Models model, string name)
        {
            this.model = model;
            this.name = name;
        }
    }

    public enum Models
    {
        Launchpad,
        LaunchpadMk2,
        LaunchpadMini,
        LaunchpadS,
        LaunchpadPro
    }
}
