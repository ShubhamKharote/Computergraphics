using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computergraphics
{
    public partial class Form1 : Form
    {
        Color cc=Color.Black;
        String action = "";
        public Form1()
        {
            InitializeComponent();
        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            Graphics gg = panel3.CreateGraphics();

            Pen p = new Pen(cc);
            gg.DrawRectangle(p,50,50,100,100);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics gg = panel3.CreateGraphics();

            Pen p = new Pen(cc);
             gg.DrawEllipse(p, 50, 50, 100, 100);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Graphics gg = panel3.CreateGraphics();
            gg.Clear(Color.White);  
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog(); 
            cd.ShowDialog();
            cc = cd.Color;
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button5_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if(action=="down")
            {
                Graphics gg = panel3.CreateGraphics();

                Brush b = new SolidBrush(cc);
                int s = int.Parse(textBox1.Text);
                gg.FillEllipse(b, e.X, e.Y, s, s);
                
            }
            
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            action = "down";
        }

        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
            action = "up";
        }
    }
}
