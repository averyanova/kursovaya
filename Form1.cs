using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;

namespace курсовая_по_тп
{
    public partial class Form1 : Form
    {
        List<Emitter> emitters = new List<Emitter>();
        Emitter Emitter;
        public Form1()
        {
            InitializeComponent();
            pictureBox.Image = new Bitmap(pictureBox.Width, pictureBox.Height);
            this.Emitter = new Emitter
            {
                Direction = 0,
                Spreading = 10,
                SpeedMin = 10,
                SpeedMax = 10,
                ParticleesPerTick = 20,
                ColorFrom = Color.Crimson,
                ColorTo = Color.FromArgb(0, Color.Green),
                X = pictureBox.Width / 2,
                Y = pictureBox.Height / 2,
            };
            emitters.Add(this.Emitter);

            Emitter = new TopEmitter
            {
                Width = pictureBox.Width,
                GravitationY = 0.25f
            };

            //Emitter.impactPoints.Add(new GravityPoint {
            //    X = pictureBox.Width / 2 + 100,
            //    Y = pictureBox.Height / 2});

            //Emitter.impactPoints.Add(new GravityPoint {
            //   X = pictureBox.Width / 2 - 100,
            //   Y = pictureBox.Height / 2});

            //Emitter.impactPoints.Add(new GravityPoint {
            //    X = (float)(pictureBox.Width * 0.25),
            //    Y = pictureBox.Height / 2});
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Emitter.UpdateState();
            using (var g = Graphics.FromImage(pictureBox.Image))
            {
                g.Clear(Color.Black);
                Emitter.Render(g);
                
            }
            pictureBox.Invalidate();
        }

        private void PictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            Emitter.X = e.X;
            Emitter.Y = e.Y;
        }

        private void TrackBar1_Scroll(object sender, EventArgs e)
        {
            foreach (var p in Emitter.impactPoints)
            {
                if (p is GravityPoint)
                {
                    (p as GravityPoint).Power = trackBar1.Value;
                    (p as GravityPoint).b = trackBar1.Value;

                }
            }
            label5.Text = $"{trackBar1.Value}";
        }

        private void PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Emitter.impactPoints.Add(new GravityPoint
                {
                    X = e.X,
                    Y = e.Y,
                    Power = trackBar1.Value,
                    b = trackBar1.Value,
            }) ;
            }
        }

        private void TrackBar2_Scroll(object sender, EventArgs e)
        {
            Emitter.ParticleesPerTick = trackBar2.Value;
            trackBar2.Value = trackBar2.Value;
            label6.Text = $"{trackBar2.Value}";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Emitter.GravitationX = 0;
            Emitter.GravitationY = 0;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Emitter.GravitationX = 0;
            Emitter.GravitationY = 1;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Emitter.ColorFrom = Color.Red;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Emitter.ColorFrom = Color.Blue;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Emitter.ColorFrom = Color.Yellow;
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Emitter.ColorFrom = Color.Pink;
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            Emitter.ColorFrom = Color.Green;
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            Emitter.ColorFrom = Color.Brown;
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            Emitter.ColorFrom = Color.Purple;
        }
    }
}
