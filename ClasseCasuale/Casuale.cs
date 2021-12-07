using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseCasuale
{
    class Casuale
    {
        //la classe può non avere attributi
        //oppure mi memorizzo il numero estratto che può essere ripreso da una property
        protected int numEstratto;

        public int NumEstratto
        {
            get { return numEstratto; }
        }

        public virtual int Estrai()
        {
            numEstratto = DateTime.Now.Millisecond;
            return numEstratto;
        }

        public virtual int Estrai(int n)
        {
            numEstratto = DateTime.Now.Millisecond % n;
            return numEstratto;
        }

        public virtual int Estrai(int n, int m)
        {
            numEstratto = n + (DateTime.Now.Millisecond % (m - n));
            return numEstratto;
        }
        
    }

    class CasualePari : Casuale
    {
        public override int Estrai()
        {
            do
            {
                numEstratto = DateTime.Now.Millisecond;
            } while (numEstratto % 2 == 1);
            return numEstratto;
        }

        public override int Estrai(int n)
        {
            do
            {
                numEstratto = DateTime.Now.Millisecond % n;
            } while (numEstratto % 2 == 1);
            return numEstratto; 
        }

        public override int Estrai(int n, int m)
        {
            do
            {
                numEstratto = n + (DateTime.Now.Millisecond % (m - n));
            } while (numEstratto % 2 == 1);
            return numEstratto;
        }

    }

    class CasualeDispari : Casuale
    {
        public override int Estrai()
        {
            do
            {
                numEstratto = DateTime.Now.Millisecond;
            } while (numEstratto % 2 != 1);
            return numEstratto;
        }

        public override int Estrai(int n)
        {
            do
            {
                numEstratto = DateTime.Now.Millisecond % n;
            } while (numEstratto % 2 != 1);
            return numEstratto;
        }

        public override int Estrai(int n, int m)
        {
            do
            {
                numEstratto = n + (DateTime.Now.Millisecond % (m - n));
            } while (numEstratto % 2 != 1);
            return numEstratto;
        }

    }

    class CasualePrimo : Casuale
    {
        public override int Estrai()
        {
            do
            {
                numEstratto = DateTime.Now.Millisecond;
            } while (!IsPrimo(numEstratto));
            return numEstratto;
        }

        public override int Estrai(int n)
        {
            do
            {
                numEstratto = DateTime.Now.Millisecond % n;
            } while (!IsPrimo(numEstratto));
            return numEstratto;
        }

        public override int Estrai(int n, int m)
        {
            do
            {
                numEstratto = n + (DateTime.Now.Millisecond % (m - n));
            } while (!IsPrimo(numEstratto));
            return numEstratto;
        }

        private bool IsPrimo(int num)
        {
            //restituisce true se il numero è primo, altrimenti ritorna false
            if (num < 3) return false;
            int div = 1;
            do
            {
                div++;
                if (num % div == 0) return false;
            } while (div < (num / 2)-1);
            return true;
        }

    }
}
