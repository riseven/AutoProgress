using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace AutoProgress
{
    class DBI
    {
        private static DBI _dbi ;

        public static DBI Interfaz
        {
            get
            {
                if (_dbi == null)
                {
                    _dbi = new DBI();
                    _dbi.apds.EnforceConstraints = false;
                }
                return _dbi;
            }
        }

        protected AutoProgressDataSetTableAdapters.PlantillasTableAdapter pta = new AutoProgress.AutoProgressDataSetTableAdapters.PlantillasTableAdapter();
        protected AutoProgressDataSetTableAdapters.FilasPlantillasTableAdapter fpta = new AutoProgress.AutoProgressDataSetTableAdapters.FilasPlantillasTableAdapter();
        protected AutoProgressDataSetTableAdapters.TestsTableAdapter tta = new AutoProgress.AutoProgressDataSetTableAdapters.TestsTableAdapter();
        protected AutoProgressDataSetTableAdapters.PreguntasTableAdapter prta = new AutoProgress.AutoProgressDataSetTableAdapters.PreguntasTableAdapter();
        protected AutoProgressDataSetTableAdapters.RealizacionesTableAdapter rta = new AutoProgress.AutoProgressDataSetTableAdapters.RealizacionesTableAdapter();
        AutoProgressDataSet apds = new AutoProgressDataSet();

        public List<Plantilla> GetListaPlantillas()
        {
            List<Plantilla> lista = new List<Plantilla>();

            pta.Fill(apds.Plantillas);
            fpta.Fill(apds.FilasPlantillas);

            foreach (DataRow dPlant in apds.Plantillas)
            {
                Plantilla p = new Plantilla();
                p.Codigo = (string)dPlant["codigo"];

                foreach (DataRow dFila in apds.FilasPlantillas)
                {
                    string plantilla = (string)dFila["plantilla"];
                    if (plantilla == p.Codigo)
                    {
                        int num = (int)dFila["num"];
                        string respuesta = (string)dFila["respuesta"];
                        p.SetRespuesta(num, respuesta);
                    }
                }

                lista.Add(p);
            }

            return lista;
        }

        public void AddPlantilla(Plantilla p)
        {
            pta.Insert(p.Codigo);
            for (int i = 1; i <= p.NumRespuestas; i++)
            {
                fpta.Insert(p.Codigo, i, p.GetRespuesta(i));
            }
        }

        public void GetPlantilla(Plantilla p)
        {
            pta.Fill(apds.Plantillas);
            fpta.Fill(apds.FilasPlantillas);
            foreach (DataRow d in apds.Plantillas)
            {
                if ((string)d["codigo"] == p.Codigo)
                {
                    foreach (DataRow dFila in apds.FilasPlantillas)
                    {
                        string plantilla = (string)dFila["plantilla"];
                        if (plantilla == p.Codigo)
                        {
                            int num = (int)dFila["num"];
                            string respuesta = (string)dFila["respuesta"];
                            p.SetRespuesta(num, respuesta);
                        }
                    }
                }
            }
        }

        public List<Test> GetListaTests()
        {
            List<Test> lista = new List<Test>();

            tta.Fill(apds.Tests);

            foreach (DataRow d in apds.Tests)
            {
                Test t = new Test();
                t.Codigo = (string)d["codigo"];
                t.CodPlantilla = (string)d["plantilla"];

                lista.Add(t);
            }

            return lista;
        }

        public void AddTest(Test t)
        {
            tta.Insert(t.Codigo, t.CodPlantilla);

            for (int i = 1; i <= t.NumPreguntas; i++)
            {
                Pregunta p = t.GetPregunta(i);
                prta.Insert(p.CodTest, p.Num, p.VecesContestada, p.VecesFallada);
            }
        }

        public void GetTest(Test t)
        {
            tta.Fill(apds.Tests);
            prta.Fill(apds.Preguntas);

            foreach (DataRow d in apds.Tests)
            {
                if ((string)d["codigo"] == t.Codigo)
                {
                    t.CodPlantilla = (string)d["plantilla"];
                    break;
                }
            }

            foreach (DataRow d in apds.Preguntas)
            {
                if ((string)d["test"] == t.Codigo)
                {
                    Pregunta p = new Pregunta();
                    p.CodTest = t.Codigo;
                    p.Num = (int)d["num"];
                    p.VecesContestada = (int)d["veces"];
                    p.VecesFallada = (int)d["fallos"];
                    t.SetPregunta(p.Num, p);
                }
            }
        }

        public void UpdatePregunta(Pregunta p, Pregunta orig_p)
        {
            prta.Update(p.CodTest, p.Num, p.VecesContestada, p.VecesFallada, orig_p.CodTest,
                orig_p.Num, orig_p.VecesContestada, orig_p.VecesFallada);
        }

        public List<Realizacion> GetListaRealizaciones(Test t)
        {
            List<Realizacion> lista = new List<Realizacion>();

            rta.Fill(apds.Realizaciones);

            foreach (DataRow d in apds.Realizaciones)
            {
                if ((string)d["test"] == t.Codigo)
                {
                    Realizacion r = new Realizacion();
                    r.CodTest = t.Codigo;
                    r.Num = (int)d["num"];
                    r.Fecha = (DateTime)d["fecha"];
                    r.Fallos = (int)d["fallos"];

                    lista.Add(r);
                }
            }

            return lista;
        }

        public void AddRealizacion(Realizacion r)
        {
            rta.Insert(r.Num, r.CodTest, r.Fecha, r.Fallos);
        }

        public List<Pregunta> GetListaPreguntas()
        {
            List<Pregunta> lista = new List<Pregunta>();

            prta.Fill(apds.Preguntas);

            foreach (DataRow d in apds.Preguntas)
            {
                Pregunta p = new Pregunta();
                p.CodTest = (string)d["test"];
                p.Num = (int)d["num"];
                p.VecesContestada = (int)d["veces"];
                p.VecesFallada = (int)d["fallos"];

                lista.Add(p);
            }

            return lista;
        }

    }
}
