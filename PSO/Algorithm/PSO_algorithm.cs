using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSO
{
    class PSO_algorithm
    {

        public static Particle[] DaneStartowe (Problem problem, Param par, ref BestPosition GlobalBest, IFunkcja funkcja)
        {
            Random random = new Random();
            Particle[] particles = new Particle[par.nPop];
            bool PierwszaLiteracja = true;
            for (int i = 0; i < par.nPop; i++)
            {

                particles[i].Position = problem.VarMin + (random.NextDouble() * (problem.VarMax - problem.VarMin));

                particles[i].Velocity = 0;
                particles[i].Cost = funkcja.Funkcja(particles[i].Position);
                particles[i].Best = new BestPosition { Position = particles[i].Position, Cost = particles[i].Cost };
                if (PierwszaLiteracja)
                {
                    GlobalBest = particles[i].Best;
                    PierwszaLiteracja = false;
                }
                if ((particles[i].Best.Cost < GlobalBest.Cost))
                {
                    GlobalBest = particles[i].Best;
                }

            }
            return particles;


        }

        public static Particle[] MainFloop(Particle[] particles, Problem problem, Param par, ref BestPosition GlobalBest, IFunkcja funkcja)
        {
            Random random = new Random();
            double MaxVelocity = 0.2 * (problem.VarMax - problem.VarMin);
            double MinVelocity = -MaxVelocity;
            for (int i = 0; i < par.nPop; i++)
            {

                particles[i].Velocity = par.w * particles[i].Velocity // ustalanie nowego wectora 
                    + par.c1 * random.NextDouble() * particles[i].Best.Position - particles[i].Position // min lokalne 
                     + par.c2 * random.NextDouble() * GlobalBest.Position - particles[i].Position; // min globalne  

                if (particles[i].Velocity > MaxVelocity) // sprawdzanie czy wketor wyszedł poza zakres 
                    particles[i].Velocity = MaxVelocity;
                else if (particles[i].Velocity < MinVelocity)
                    particles[i].Velocity = MinVelocity;

                particles[i].Position = particles[i].Position + particles[i].Velocity; // utawinie nowej pozycji 

                if (particles[i].Position > problem.VarMax) // prawdzanie czy pozycja została ustalona poza zakresem 
                    particles[i].Position = problem.VarMax;
                else if (particles[i].Position < problem.VarMin)
                    particles[i].Position = problem.VarMin;


                particles[i].Cost = funkcja.Funkcja(particles[i].Position);


                if ((particles[i].Cost < particles[i].Best.Cost))// sprawdzenie czy minimum lokalne jest mniejsze od aktualnego 
                {
                    particles[i].Best = new BestPosition { Position = particles[i].Position, Cost = particles[i].Cost };

                    if ((particles[i].Best.Cost < GlobalBest.Cost))// sprawdzenie czy minimum globalne jest mniejsze od aktualnego 
                    {
                        GlobalBest = particles[i].Best;
                    }

                }



            }
            return particles;
        }

        public static double[] Main_PSO(Problem problem, Param par, ref BestPosition[] SpisW, IFunkcja funkcja)
        {
            Random random = new Random();
            double[] wynik = new double[2];
            BestPosition GlobalBest = new BestPosition();
    
            Particle[] particles = DaneStartowe(problem,par, ref GlobalBest, funkcja);


              BestPosition[] SpisWyników = new BestPosition[par.MaxIterations];

            for (int j = 0; j < par.MaxIterations; j++)
            {
                particles = MainFloop(particles, problem, par, ref GlobalBest, funkcja);

                par.w = par.w * par.wdamp;
                SpisWyników[j] = GlobalBest;
            }

            SpisW = SpisWyników;

            wynik[0] = GlobalBest.Cost;
            wynik[1] = GlobalBest.Position;

            return wynik; ;
        }
     
    }



}
