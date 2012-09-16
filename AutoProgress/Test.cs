using System;
using System.Collections.Generic;
using System.Text;

namespace AutoProgress
{
    public class Test
    {
        private string codigo;
        private string codPlantilla;
        private Pregunta[] preguntas;
        private const int SIZE = 100;
        private int lastPregunta;

        public Test()
        {
            codigo = "";
            codPlantilla = "";
            preguntas = new Pregunta[SIZE];
            lastPregunta = 0;
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

        public string CodPlantilla
        {
            get
            {
                return codPlantilla;
            }
            set
            {
                codPlantilla = value;
            }
        }

        public int NumPreguntas
        {
            get
            {
                return lastPregunta;
            }
        }

        public Pregunta GetPregunta(int num)
        {
            if (num < 1 || num >= SIZE)
            {
                throw new Exception("Numero de pregunta no valido");
            }
            return (Pregunta)preguntas.GetValue(num);
        }

        public void SetPregunta(int num, Pregunta p)
        {
            if (num < 1 || num >= SIZE)
            {
                throw new Exception("Numero de pregunta no valido");
            }
            preguntas.SetValue(p, num);
            if (num > lastPregunta)
            {
                lastPregunta = num;
            }
        }
    }
}
