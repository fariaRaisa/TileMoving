using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TileMoving
{
    public partial class Form1 : Form
    {

        private Point MouseDownLocation;
        private int lockedOn = 0;
        List<Panel> panels;
        Point unPinPos = new Point();


        public Form1()
        {
            InitializeComponent();
            
            
            panels = new List<Panel>();
            panels.Add(panel1);
            panels.Add(panel2);
            panels.Add(panel3);
            panels.Add(panel4);

        }


        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                MouseDownLocation = e.Location;
                unPinPos = panel1.Location;
                lockedOn = 1;
                panel1.BringToFront();

            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            Panel temPanel = findOverlap(panel1);

            if (temPanel != null)
            {
                swapPanels(temPanel, panel1);
            }
            else
            {
                swapPanels(panel1, panel1);

            }
            
        }


        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left && lockedOn==1)
            {
                panel1.Left = e.X + panel1.Left - MouseDownLocation.X;
                panel1.Top = e.Y + panel1.Top - MouseDownLocation.Y;
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                MouseDownLocation = e.Location;
                unPinPos = panel2.Location;
                lockedOn = 2;
                panel2.BringToFront();
            }
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            Panel temPanel = findOverlap(panel2);

            if (temPanel != null)
            {
                swapPanels(temPanel, panel2);
            }
            else
            {
                swapPanels(panel2, panel2);

            }
        }


        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left && lockedOn == 2)
            {
                panel2.Left = e.X + panel2.Left - MouseDownLocation.X;
                panel2.Top = e.Y + panel2.Top - MouseDownLocation.Y;
            }
        }


        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                MouseDownLocation = e.Location;
                unPinPos = panel3.Location;
                lockedOn = 3;
                panel3.BringToFront();

            }
        }

        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
            Panel temPanel = findOverlap(panel3);

            if (temPanel != null)
            {
                swapPanels(temPanel, panel3);
            }
            else
            {
                swapPanels(panel3, panel3);

            }
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left && lockedOn == 3)
            {
                panel3.Left = e.X + panel3.Left - MouseDownLocation.X;
                panel3.Top = e.Y + panel3.Top - MouseDownLocation.Y;
            }
        }


        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                MouseDownLocation = e.Location;
                unPinPos = panel4.Location;
                lockedOn = 4;
                panel4.BringToFront();

            }
        }

        private void panel4_MouseUp(object sender, MouseEventArgs e)
        {
            Panel temPanel = findOverlap(panel4);

            if (temPanel != null)
            {
                swapPanels(temPanel, panel4);
            }
            else
            {
                swapPanels(panel4, panel4);

            }
        }

        private void panel4_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left && lockedOn == 4)
            {
                panel4.Left = e.X + panel4.Left - MouseDownLocation.X;
                panel4.Top = e.Y + panel4.Top - MouseDownLocation.Y;
            }
        }



        private Panel findOverlap(Panel p)
        {
            foreach (Panel pan in panels)
            {
                if (pan != p)
                {
                    if (pan.Bounds.IntersectsWith(p.Bounds))
                    {
                        return pan;
                    }
                }
            }

            return null;
        }


        private void swapPanels(Panel p1, Panel p2)
        {
            p2.Location = p1.Location;
            p1.Location = unPinPos; 
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


    }
}
