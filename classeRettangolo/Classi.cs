using System;
using System.Collections.Generic;
using System.Text;

namespace classeRettangolo
{
    class Rettangolo
    {
        double lato1;
        double lato2;

        public Rettangolo()
        {
            lato1 = 0;
            lato2 = 0;
        }

        public Rettangolo(double l1, double l2)
        {
            if (l1 > 0) {
                lato1 = l1;
            }
            else
            {
                lato1 = 0;
            }

            if (l2 > 0)
            {
                lato2 = l2;
            }
            else
            {
                lato2 = 0;
            }

        }

        public double Perimetro()
        {
            return lato1 * 2 + lato2 * 2;
        }

        public double Area()
        {
            return lato1 * lato2;
        }

        public void SetLato1(double l)
        {
            if (l > 0)
            {
                lato1 = l;
            }
        }
        public void SetLato2(double l)
        {
            if (l > 0)
            {
                lato2 = l;
            }
        }
        public double GetLato1()
        {
            return lato1;
        }
        public double GetLato2()
        {
            return lato2;
        }
    }
}
