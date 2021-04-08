using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MyUML.Arrows
{
    public abstract class AbstractArrow
    {
        protected Pen _pen;
        public Point StartPoint { get; set; }
        public Point EndPoint { get; set; }

        public abstract void Draw(Graphics graphics);
        
    }
}
