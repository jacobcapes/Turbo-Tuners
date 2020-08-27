using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Turbo_Tuners
{
    class Checkpoint
    {
        // declare fields to use in the class

        public int x1, y1, width1, height1;//variables for the rectangle
        public Image checkpoint;//variable for the planet's image
        public Rectangle checkRec;//variable for a rectangle to place our image in


        public Checkpoint()
        {
            x1 = 10;
            y1 = 360;
            width1 = 40;
            height1 = 40;
            checkpoint = Properties.Resources.car1;
            checkRec = new Rectangle(x1, y1, width1, height1);
        }
        public void drawCheck(Graphics g)
        {
            g.DrawImage(checkpoint, checkRec);
        }
    }
}
