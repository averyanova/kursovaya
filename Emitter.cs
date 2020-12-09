using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace курсовая_по_тп
{
    public class Emitter
    {//
        List<Particle> particles = new List<Particle>();
        public List<IImpactPoint> impactPoints = new List<IImpactPoint>();
        public int X;
        public int Y;
        public int Direction = 0;
        public int Spreading = 360;
        public int SpeedMin = 1;
        public int SpeedMax = 10;
        public int RadiusMin = 2;
        public int RadiusMax = 10;
        public int LifeMin = 20;
        public int LifeMax = 100;
        public int ParticleesPerTick = 20;
        public Color ColorFrom = Color.Aquamarine;
        public Color ColorTo = Color.FromArgb(0, Color.Black);
        public float GravitationX = 0;
        public float GravitationY = 0;

        public virtual Particle CreateParticle()
        {
            var particle = new ParticleColorful();
            particle.FromColor = ColorFrom;
            particle.ToColor = ColorTo;
            return particle;
        }

        public void UpdateState()
        {
            int particlesToCreate = ParticleesPerTick;
            foreach (var particle in particles)
            {
                if (particle.life < 0)
                {
                    if (particlesToCreate > 0)
                    {
                        particlesToCreate -= 1;
                        ResetParticle(particle);
                    }
                }
                else
                {
                    particle.x += particle.speedX;
                    particle.y += particle.speedY;

                    foreach (var point in impactPoints)
                    {
                        point.ImpactParticle(particle);
                    }

                    particle.speedX += GravitationX;
                    particle.speedY += GravitationY;

                    
                }
            }

            while ( particlesToCreate >= 1)
            {
                particlesToCreate -= 1;
                var particle = CreateParticle();
                ResetParticle(particle);
                particles.Add(particle);
            }
        }

        public void Render(Graphics g)
        {
            foreach (var particle in particles)
            {
                particle.Draw(g);
            }

            foreach (var point in impactPoints)
            {
                point.Render(g);
            }
        }
        public int ParticlesCount = 500;
        public virtual void ResetParticle(Particle particle)
        {
            particle.life = Particle.rnd.Next(LifeMin, LifeMax);
            particle.x = X;
            particle.y = Y;
            var direction = Direction + (double)Particle.rnd.Next(Spreading) - Spreading / 2;
            var speed = Particle.rnd.Next(SpeedMin, SpeedMax);
            particle.speedX = (float)(Math.Cos(direction / 180 * Math.PI) * speed);
            particle.speedY = -(float)(Math.Sin(direction / 180 * Math.PI) * speed);
            particle.radius = Particle.rnd.Next(RadiusMin, RadiusMax);
        }
        
    }

        public class TopEmitter : Emitter
        {
            public int Width;
            public override void ResetParticle(Particle particle)
            {
                base.ResetParticle(particle);
                particle.x = Particle.rnd.Next(Width);
                particle.y = 0;
                particle.speedY = 1;
                particle.speedX = Particle.rnd.Next(-2, 2);
            }
        }

    public abstract class IImpactPoint
    {
        public float X;
        public float Y;

        public abstract void ImpactParticle(Particle particle);

        public virtual void Render(Graphics g)
        {
            g.FillEllipse(
                new SolidBrush(Color.Beige),
                X - 5,
                Y - 5,
                10,
                10);
        }
    }

    public class GravityPoint : IImpactPoint
    {
        public int Power = 1;
        public int count = 0;

        public override void ImpactParticle(Particle particle)
        {
            float gX = X - particle.x;
            float gY = Y - particle.y;
            double r = Math.Sqrt(gX * gX + gY * gY);
            if (r + particle.radius < Power / 2)
            {
                particle.life = 0;
                count++;
            }
        }
        public override void Render(Graphics g)
        {
            g.DrawEllipse(
                new Pen(Color.Red),
                X - Power / 2,
                Y - Power / 2,
                Power,
                Power);

            g.DrawString($"{count}",
                new Font("Verdana", 10),
                new SolidBrush(Color.White),
                X - 25,
                Y - 5);
        }
    }

    
}
