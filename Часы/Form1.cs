using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Часы
{
    public partial class Form1 : Form
    {
        Random rnd;
        public Form1()
        {
            InitializeComponent();
            pictureBox2.Parent = pictureBox1;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox3.Parent = pictureBox1;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox4.Parent = pictureBox1;
            pictureBox4.BackColor = Color.Transparent;
            pictureBox5.Parent = pictureBox1;
            pictureBox5.BackColor = Color.Transparent;
            pictureBox6.Parent = pictureBox1;
            pictureBox6.BackColor = Color.Transparent;
            pictureBox7.Parent = pictureBox1;
            pictureBox7.BackColor = Color.Transparent;
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            prep.Visible = false;
            prep2.Visible = false;
            rnd = new Random();
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            pictureBox2.Left += 1;
            int value1 = rnd.Next(10, 25);
            this.timer1.Interval = value1;
            if (pictureBox3.Bounds.IntersectsWith(prep.Bounds))
            {
                if (rnd.Next(1, 500) == 1)
                {
                    timer1.Stop();
                }
            }
            if (pictureBox3.Bounds.IntersectsWith(prep2.Bounds))
            {
                if (rnd.Next(1, 500) == 1)
                {
                    timer1.Stop();
                }
            }
            if (pictureBox2.Bounds.IntersectsWith(Fin.Bounds))
            {

                this.timer1.Enabled = false;
                this.timer2.Enabled = false;
                this.timer3.Enabled = false;
                this.timer4.Enabled = false;
                this.timer5.Enabled = false;
                this.timer6.Enabled = false;
                MessageBox.Show("Победил 1-ый", "Победа");
            }
        }

        private void On_Click(object sender, EventArgs e)
        {
            this.timer1.Enabled = true;
            this.timer2.Enabled = true;
            this.timer3.Enabled = true;
            this.timer4.Enabled = true;
            this.timer5.Enabled = true;
            this.timer6.Enabled = true;
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            pictureBox3.Left += 1;
            int value2 = rnd.Next(10, 25);
            this.timer2.Interval = value2;
            if (pictureBox3.Bounds.IntersectsWith(prep.Bounds))
            {
                if (rnd.Next(1, 500) == 1)
                {
                    timer2.Stop();
                }
            }
            if (pictureBox3.Bounds.IntersectsWith(prep2.Bounds))
            {
                if (rnd.Next(1, 500) == 1)
                {
                    timer2.Stop();
                }
            }
            if (pictureBox3.Bounds.IntersectsWith(Fin.Bounds))
            {
                this.timer1.Enabled = false;
                this.timer2.Enabled = false;
                this.timer3.Enabled = false;
                this.timer4.Enabled = false;
                this.timer5.Enabled = false;
                this.timer6.Enabled = false;
                MessageBox.Show("Победил 2-ой","Победа");
            }
        }

        private void Timer3_Tick(object sender, EventArgs e)
        {
            pictureBox4.Left += 1;
            int value3 = rnd.Next(10, 25);
            this.timer3.Interval = value3;
            if (pictureBox3.Bounds.IntersectsWith(prep.Bounds))
            {
                if (rnd.Next(1, 500) == 1)
                {
                    timer3.Stop();
                }
            }
            if (pictureBox3.Bounds.IntersectsWith(prep2.Bounds))
            {
                if (rnd.Next(1, 500) == 1)
                {
                    timer3.Stop();
                }
            }
            if (pictureBox4.Bounds.IntersectsWith(Fin.Bounds))
            {
                this.timer1.Enabled = false;
                this.timer2.Enabled = false;
                this.timer3.Enabled = false;
                this.timer4.Enabled = false;
                this.timer5.Enabled = false;
                this.timer6.Enabled = false;
                MessageBox.Show("Победил 3-ий", "Победа");
            }

        }

        private void Timer4_Tick(object sender, EventArgs e)
        {
            pictureBox5.Left += 1;
            int value4 = rnd.Next(10, 25);
            this.timer4.Interval = value4;
            if (pictureBox3.Bounds.IntersectsWith(prep.Bounds))
            {
                if (rnd.Next(1, 500) == 1)
                {
                    timer4.Stop();
                }
            }
            if (pictureBox3.Bounds.IntersectsWith(prep2.Bounds))
            {
                if (rnd.Next(1, 500) == 1)
                {
                    timer4.Stop();
                }
            }
            if (pictureBox5.Bounds.IntersectsWith(Fin.Bounds))
            {

                this.timer1.Enabled = false;
                this.timer2.Enabled = false;
                this.timer3.Enabled = false;
                this.timer4.Enabled = false;
                this.timer5.Enabled = false;
                this.timer6.Enabled = false;
                MessageBox.Show("Победил 4-ый", "Победа");
            }
        }

        private void Timer5_Tick(object sender, EventArgs e)
        {
            pictureBox6.Left += 1;
            int value5 = rnd.Next(10, 25);
            this.timer5.Interval = value5;
            if (pictureBox3.Bounds.IntersectsWith(prep.Bounds))
            {
                if (rnd.Next(1, 500) == 1)
                {
                    timer5.Stop();
                }
            }
            if (pictureBox3.Bounds.IntersectsWith(prep2.Bounds))
            {
                if (rnd.Next(1, 500) == 1)
                {
                    timer5.Stop();
                }
            }
            if (pictureBox6.Bounds.IntersectsWith(Fin.Bounds))
            {

                this.timer1.Enabled = false;
                this.timer2.Enabled = false;
                this.timer3.Enabled = false;
                this.timer4.Enabled = false;
                this.timer5.Enabled = false;
                this.timer6.Enabled = false;
                MessageBox.Show("Победил 5-ый", "Победа");
            }
        }

        private void Timer6_Tick(object sender, EventArgs e)
        {
            pictureBox7.Left += 1;
            int value6 = rnd.Next(10, 25);
            this.timer6.Interval = value6;
            if (pictureBox3.Bounds.IntersectsWith(prep.Bounds))
            {
                if (rnd.Next(1, 500) == 1)
                {
                    timer6.Stop();
                }
            }
            if (pictureBox3.Bounds.IntersectsWith(prep2.Bounds))
            {
                if (rnd.Next(1, 500) == 1)
                {
                    timer6.Stop();
                }
            }
            if (pictureBox7.Bounds.IntersectsWith(Fin.Bounds))
            {

                this.timer1.Enabled = false;
                this.timer2.Enabled = false;
                this.timer3.Enabled = false;
                this.timer4.Enabled = false;
                this.timer5.Enabled = false;
                this.timer6.Enabled = false;
                MessageBox.Show("Победил 6-ой", "Победа");
            }
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
