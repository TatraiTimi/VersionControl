using aqefte_week06.Abstractions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aqefte_week06.Entities
{
    internal class Car : Toy
    {
        protected override void DrawImage(Graphics g)
        {
            Image imagefile = Image.FromFile("Images/car.png");
            g.DrawImage(imagefile, new Rectangle(0, 0, Width, Height));
        }
    }
}
