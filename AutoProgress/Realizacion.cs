using System;
using System.Collections.Generic;
using System.Text;

namespace AutoProgress
{
    class Realizacion
    {
        private int num;
        private string codTest;
        private DateTime fecha;
        private int fallos;

        public Realizacion()
        {
            num = 0;
            codTest = "";
            fecha = DateTime.Now;
            fallos = 0;
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

        public DateTime Fecha
        {
            get
            {
                return fecha;
            }
            set
            {
                fecha = value;
            }
        }

        public int Fallos
        {
            get
            {
                return fallos;
            }
            set
            {
                fallos = value;
            }
        }


    }
}
