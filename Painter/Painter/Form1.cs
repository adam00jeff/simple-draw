using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Painter
{/// <summary>
/// partial class split over multiple source files
/// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// 
        /// </summary>
        /// 
        Bitmap myBitmap;
        Pen myPen = new Pen(Color.Black, 3);
        public Form1()
        {
            InitializeComponent();
            ///should be same size as the form
            myBitmap = new Bitmap(640, 480);

        }
        /// <summary>
        /// 
        /// button 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("button pressed");
            button1.Text = "Stop";
            myPen = new Pen(Color.Red, 2);
        }
        /// <summary>
        /// 
        /// button 2 
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            Console.WriteLine("button2 pressed");
            button2.Text = "Stop stop";
            myPen = new Pen(Color.Blue, 2);
        }
        /// <summary>
        /// 
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics; // get graphics context of form
            g.DrawImageUnscaled(myBitmap, 0, 0); // put off-screen bitmap on form
            Refresh();// refresh the window to display
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Graphics g = Graphics.FromImage(myBitmap); // get graphics context of screen bitmap
            ///Pen p = myPen(Color.Red, 2);
            g.DrawLine(myPen, e.X, e.Y, e.X + 1, e.Y + 1); // draw point on off screen bitmap
        }
    }
}
