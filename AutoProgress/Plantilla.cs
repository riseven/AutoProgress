using System;
using System.Collections.Generic;
using System.Text;

namespace AutoProgress
{
    public class Plantilla
    {
        private string codigo;
        private string[] respuestas;
        private const int SIZE = 100;
        private int lastRespuesta;

        public Plantilla()
        {
            respuestas = new string[100];
            lastRespuesta = 0;
        }

        public string Codigo
        {
            get
            {
                return codigo;
            }
            set
            {
                codigo = value;
            }
        }

        public string GetRespuesta(int num)
        {
            if (num < 1 || num >= SIZE)
            {
                throw new Exception("Numero de pregunta inválido");
            }
            return respuestas[num];
        }

        public void SetRespuesta(int num, string c)
        {
            if (num < 1 || num >= SIZE)
            {
                throw new Exception("Numero de pregunta inválido");
            }
            respuestas[num] = c;
            if (num > lastRespuesta)
            {
                lastRespuesta = num;
            }
        }

        public int NumRespuestas
        {
            get
            {
                return lastRespuesta;
            }
        }
    }
}
