using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KlavyeİleHareket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int x = pictureBox1.Location.X;
            int y = pictureBox1.Location.Y;
            if (e.KeyCode == Keys.Right&&x<300
                )
            {
                x = x + 5;

            }
            if (e.KeyCode == Keys.Left&& x>0)
            {
                x = x-5;
            }
                if (e.KeyCode == Keys.Up&&y>0)
                {
                    y = y -5;

                }
                if (e.KeyCode == Keys.Down&&y<300)
                {
                    y += 5;
                }
                if(pictureBox1.Right>=label1.Left)
            {
                label1.BackColor = Color.Red;
            }
            if (pictureBox1.Left <= label2.Right)
            {
                label2.BackColor = Color.Yellow;
            }
            if(pictureBox1.Bottom>=label4.Top)
                {
                label4.BackColor= Color.Green;
            }
            if (pictureBox1.Top <= label3.Bottom)
            {
                label3.BackColor = Color.Peru;
            }
            pictureBox1.Location = new Point(x,y);
                
                ;
            }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    }

