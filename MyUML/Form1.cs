using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyUML
{
    public partial class Form1 : Form
    {
        Bitmap _mainBitmap;
        Bitmap _tmpBitmap;
        Graphics _graphics;
        public Pen _pen;
        public Point _firstPoint;
        public bool _isButtonPressed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _mainBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            _pen = new Pen(Color.Green, 4);
            trackBar1.Value = (int)_pen.Width;
            pictureBox2.BackColor = _pen.Color;

            _graphics = Graphics.FromImage(_mainBitmap);
            _graphics.Clear(Color.White);
            
                                         
            pictureBox1.Image = _mainBitmap;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isButtonPressed)
            {
                                                
                _tmpBitmap = (Bitmap)_mainBitmap.Clone();
                _graphics = Graphics.FromImage(_tmpBitmap);

                _graphics.DrawLine(_pen, _firstPoint, e.Location);

                pictureBox1.Image = _tmpBitmap;

                GC.Collect();
            }
            
        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            _firstPoint = e.Location;
            _isButtonPressed = true;
        }
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            _isButtonPressed = false;
            _mainBitmap = _tmpBitmap;
        }
        /// <summary>
        /// Изменение цвета ручки.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            
            _pen.Color = colorDialog1.Color;

            pictureBox2.BackColor = _pen.Color;
        }
        /// <summary>
        /// Ширина ручки.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            _pen.Width = trackBar1.Value;
        }
    }
}
