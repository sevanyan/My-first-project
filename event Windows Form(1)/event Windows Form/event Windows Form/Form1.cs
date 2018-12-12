using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace event_Windows_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MouseDown += Form1_MouseDown;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
           if (sender is Form1)
            {
                Form1 form = sender as Form1;
                Graphics g = form.CreateGraphics();
                if (e.Button == MouseButtons.Left  )
                {
                    LinearGradientBrush brush = new LinearGradientBrush(e.Location, new Point(e.X + 70, e.Y + 70), Color.Red, Color.Red);
                    g.FillEllipse(brush, e.X, e.Y, 70, 70);
                    Pen pen = new Pen(brush, 10);
                    pen.DashStyle = DashStyle.Solid;
                    g.DrawRectangle(pen, e.X, e.Y, 70, 70);

                }
            }
        }
    }
}
