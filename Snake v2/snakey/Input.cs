using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace snakey
{
    class Input
    {
        public static Hashtable keysTable = new Hashtable();

        public static bool keypressed(Keys key)
        {
            if (keysTable[key] == null)
            {
                return false;
            }
            return (bool)keysTable[key];
        }
        public static void changestate(Keys key, bool state)
        {
            keysTable[key] = state;
        }
    }
}
