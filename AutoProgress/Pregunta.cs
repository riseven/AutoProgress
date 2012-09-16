using System;
using System.Collections.Generic;
using System.Text;

namespace AutoProgress
{
    public class Pregunta : ICloneable
    {
        private string codTest;
        private int num;
        private int vecesContestada;
        private int vecesFallada;

        public Pregunta()
        {
            codTest = "";
            num = 0;
            vecesContestada = 0;
            vecesFallada = 0;
        }

        public Object Clone()
        {
            Pregunta p = new Pregunta();
            p.codTest = codTest;
            p.num = num;
            p.vecesContestada = vecesContestada;
            p.vecesFallada = vecesFallada;
            return p;
        }

        public string CodTest
        {
            get
            {
                return codTest;
            }
            set
            {
                codTest = value;
            }
        }

        public int Num
        {
            get
            {
                return num;
            }
            set
            {
                num = value;
            }
        }

        public int VecesContestada
        {
            get
            {
                return vecesContestada;
            }
            set
            {
                vecesContestada = value;
            }
        }

        public int VecesFallada
        {
            get
            {
                return vecesFallada;
            }
            set
            {
                vecesFallada = value;
            }
        }

    }
}
