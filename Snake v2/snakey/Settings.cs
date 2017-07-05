using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace snakey
{
    public enum directions { up, down, left, right };
    class Settings
    {
        public static int height { get; set; }
        public static int width { get; set; }
        public static int speed { get; set; }
        public static int score { get; set; }
        public static int points { get; set; }
        public static bool gameover { get; set; }
        public static directions direction { get; set; }

        public Settings()
        {
            height = 16;
            width = 16;
            speed = 16;
            score = 0;
            points = 1*speed;
            gameover = false;
            direction = directions.right;
        }
    }
}
