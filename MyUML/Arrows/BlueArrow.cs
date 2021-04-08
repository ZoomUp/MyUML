using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MyUML.Arrows
{
    public class BlueArrow : AbstractArrow
    {
        public BlueArrow()
        {
            _pen = new Pen(Color.Blue, 6);
        }

        public override void Draw(Graphics graphics)
        {
            graphics.DrawLine(_pen, StartPoint, EndPoint);
        }
    }
}
