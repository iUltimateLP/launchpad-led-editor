namespace Launchpad_LED_Editor
{
    /*
    red = "255,0,0";
    green = "0,255,0";
    blue = "0,0,255";
    yellow = "255,255,0";
    orange = "255,128,0";
    white = "255,255,255";
    magenta = "255,0,255";
    lightBlue = "0,128,255";
    cyan = "0,255,255";
   */

    public class Launchpad
    {
        public LaunchpadTypes type;
        public string name;
    }

    public enum LaunchpadTypes
    {
        Launchpad,
        LaunchpadMk2,
        LaunchpadMini,
        LaunchpadPro,
        LaunchpadS
    }
}