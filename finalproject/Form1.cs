using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalproject
{
    public partial class Form1 : Form
    { 
        int formtype,pointcounter;
        private List<Point> points;
        //Point[] pointarry;
        public Form1()
        {
            InitializeComponent();
            points = new List<Point>();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void square_Click(object sender, EventArgs e)
        {
            formtype = 4;
            //pointarry = new Point[4];
            MessageBox.Show("please click 4 points:");
        }

        private void triangle_Click(object sender, EventArgs e)
        {
            formtype = 3;
            //pointarry = new Point[3]; 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.MouseClick += MainForm_MouseClick;
            this.Paint += MainForm_Paint;
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {

            if (false)
            {
                // Draw lines between the points
                using (Pen pen = new Pen(Color.Black))
                {
                    for (int i = 1; i < points.Count; i++)
                    {
                        e.Graphics.DrawLine(pen, points[i - 1], points[i]);
                    }
                }
            }

            // Draw points
            foreach (Point point in points)
            {
                e.Graphics.FillEllipse(Brushes.Red, point.X - 2, point.Y - 2, 5, 5);
            }
        }

        private void MainForm_MouseClick(object sender, MouseEventArgs e)
        {
            if (pointcounter <= formtype)
            {
                if (pointcounter == 0)
                {
                    points.Add(e.Location);
                    pointcounter++;
                }

                if (pointcounter > 1 && points.Last() != e.Location)
                {
                    points.Add(e.Location);
                    pointcounter++;
                }
               
                
            }
            
            this.Invalidate(); // Invalidate the form to trigger the Paint event
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)

        {
            labelpoint.Text = "" + (e.Location.X + 119) + ","+ (e.Location.Y + 410);
        }

        private void labelpoint_Click(object sender, EventArgs e)
        {
        }

        /*
        private void formclick(object sender, MouseEventArgs e)
        {
            if (pointcounter < formtype)
            {
                points[pointcounter] = e.Location;
                pointcounter++;
            }

            if (pointcounter == formtype)
            {
                // All points have been picked
                int a = 0;
            }
        }*/
    }
}

