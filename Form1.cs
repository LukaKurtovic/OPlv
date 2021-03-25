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
        Linija l1 = new Linija();
        Queue<Linija> kolekcijaLinija = new Queue<Linija>();
        Graphics graphicsHelper;
        
        Boolean bMouseDown;
        
       

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            
            l1.koordinata1 = e.Location;
            bMouseDown = true;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            l1.koordinata2 = e.Location;
            kolekcijaLinija.Enqueue(l1);
            bMouseDown = false;  
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (bMouseDown)
            {
                l1.koordinata2 = e.Location;
                l1.DrawGrafObj(graphicsHelper);
                this.Invalidate();
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
           
            
            foreach (Linija line in kolekcijaLinija)
            {
                line.DrawGrafObj(graphicsHelper);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            graphicsHelper = this.CreateGraphics();
            bMouseDown = false;
            l1.SetColor(Color.Red);
        }
    }
}
