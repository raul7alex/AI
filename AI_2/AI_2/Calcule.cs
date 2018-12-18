using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI_2
{
    class Calcule
    {

        public double Suma(List<double> list)
        {
            double S = 0;
            for (int i = 0; i < list.Count; i++)
            {
                S += list[i];
            }
            return S;
        }

        public double Produs(List<double> list)
        {
            double P = 1;
            for (int i = 0; i < list.Count; i++)
            {
                P *= list[i];
            }
            return P;
        }

        public double Minim(List<double> list)
        {
            double min = list[0];
            for (int i = 1; i < list.Count; i++)
            {
                if (min > list[i])
                {
                    min = list[i];
                }
            }
            return min;
        }

        public double Maxim(List<double> list)
        {
            double max = list[0];
            for (int i = 1; i < list.Count; i++)
            {
                if (max < list[i])
                {
                    max = list[i];
                }
            }
            return max;
        }



        public double Sigmoidala(double rez,double prag, double g)
        {

            double X = -g * (rez - prag);
            return (double)(1 / (1 + Math.Pow(Math.E, X)));
        }

        public double TanH(double rez, double prag, double g)
        {

            double P = g * (rez - prag);
            double N = -g * (rez - prag);

            return (Math.Pow(Math.E, P) - Math.Pow(Math.E, N)) /
                   (Math.Pow(Math.E, P) + Math.Pow(Math.E, P));
        }

        public double Treapta(double rez, double prag)
        {

            if (rez >= prag)
            {
                return 1;
            }
            else
            {
                return 0;
            }

        }

        public double Semn(double rez, double prag)
        {
            if (rez >= prag)
            {
                return 1;
            }
            else
            {
                return -1;
            }

        }

        public double Rampa(double rez, double g)
        {
            if (rez >= g)
            {
                return 1;
            }
            if (rez < g * -1)
            {
                return -1;
            }
            else
            {
                return rez / g;
            }
        }
    }
}
