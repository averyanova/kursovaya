using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace курсовая_по_тп
{
    public class Particle
    {
        public int radius;
        public float x;
        public float y;
        public float speedX;
        public float speedY;
        public float life;
        public static Random rnd = new Random();

        public virtual void Draw(Graphics g)
        {
            float k = Math.Min(1f, life / 100);
            int alpha = (int)(k * 255);
            var color = Color.FromArgb(alpha, Color.Black);
            var b = new SolidBrush(color);
            g.FillEllipse(b, x - radius, y - radius, radius * 2, radius * 2);
            b.Dispose();
        }

        public Particle()
        {
            var direction = rnd.Next(360);
            var speed = 1 + rnd.Next(10);
            speedX = (float)(Math.Cos(direction / 180 * Math.PI) * speed);
            speedY = - (float)(Math.Sin(direction / 180 * Math.PI) * speed);
            radius = 2 + rnd.Next(10);
            life = 20 + rnd.Next(100);
        }
    }
    public class ParticleColorful : Particle
    {
        public Color FromColor;
        public Color ToColor;

        public static Color MixColor (Color color1, Color color2, float k)
        {
            return Color.FromArgb(
                (int)(color2.A * k + color1.A * (1-k)),
                (int)(color2.R * k + color1.R * (1 - k)),
                (int)(color2.G * k + color1.G * (1 - k)),
                (int)(color2.B * k + color1.B * (1 - k)));
        }
        public override void Draw (Graphics g)
        {
            float k = Math.Min(1f, life / 100);
            var color = MixColor(ToColor, FromColor, k);
            var b = new SolidBrush(color);
            g.FillEllipse(b, x - radius, y - radius, radius * 2, radius * 2);
            b.Dispose();
        }
    }
}
