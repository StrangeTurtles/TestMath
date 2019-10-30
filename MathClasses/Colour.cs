using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClasses
{
    public class Colour
    {
        public UInt32 colour;

        public Colour()
        {
            colour = 0;
        }
        public Colour(uint red, uint green, uint blue, uint alpha)
        {
            colour = (red << 24) + (green << 16) + (blue << 8) + (alpha);
        }
        public void Set(Colour c)
        {
            colour = c.colour;
        }
        public void SetRed(uint red)
        {
            Colour c = new Colour();
            c.colour = (red << 24) + colour;
            Set(c);
        }
        public void SetGreen(uint green)
        {
            Colour c = new Colour();
            c.colour = (green << 16) + colour;
            Set(c);
        }
        public void SetBlue(uint blue)
        {
            Colour c = new Colour();
            c.colour = (blue << 8) + colour;
            Set(c);
        }
        public void SetAlpha(uint alpha)
        {
            Colour c = new Colour();
            c.colour = (alpha) + colour;
            Set(c);
        }
        public Byte GetRed()
        {
            uint c = 0;
            c = colour;
            c = (c >> 24);
            return (byte)c;
        }
        public Byte GetGreen()
        {
            uint c = 0;
            c = colour;
            c = (c >> 16);
            return (byte)c;
        }
        public Byte GetBlue()
        {
            uint c = 0;
            c = colour;
            c = (c >> 8);
            //c = (c << 8);
            //c = (c >> 8);
            return (byte)c;
        }
        public Byte GetAlpha()
        {
            uint c = 0;
            c = colour;
            return (byte)c;
        }
    }
}
