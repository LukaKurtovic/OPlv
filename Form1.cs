using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LV2
{
    public partial class Form1 : Form
    {

        Point ptStart, ptEnd;
        Graphics graphicsHelper;
        Pen penHelper;
        Boolean bMouseDown;
       
       

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ptStart = e.Location;
            bMouseDown = true;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            bMouseDown = false;  
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (bMouseDown)
            {
                ptEnd = e.Location;
                this.Invalidate();
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            graphicsHelper.DrawLine(penHelper, ptStart, ptEnd);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            graphicsHelper = this.CreateGraphics();
            penHelper = new Pen(Color.Red, 2);
            bMouseDown = false;
        }
    }
}
