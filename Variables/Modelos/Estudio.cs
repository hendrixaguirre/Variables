using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables.Modelos
{
    public class Estudio
    {
        public static int[] edades = new int[10];
        public static int pos = 0;
        

        public static int GetPromedio()
        {
            int prom = 0;
            int suma = 0;
            foreach (int edad in edades)
            {
                suma += edad;
            }
            prom = (int)suma / pos;
            return prom;
        }

        public static int GetMayor()
        {
            int edadMaxima = 0;
            foreach (int edad in edades)
            {
                if (edad > edadMaxima)
                {
                   edadMaxima = edad;
                }
            }
            return edadMaxima;
        }

        public static int GetMenor()
        {
            int edadMinima = edades[0];
            for (int i = 1; i < pos; i++)
            {
                if (edades[i] < edadMinima)
                {
                    edadMinima = edades[i];
                }
            }
            return edadMinima;
        }

        public static int GetMayorEdad()
        {
            int MayorEdad = 0;
            foreach (int edad in edades)
            {
                if (edad >=18 && edad < 100)
                {
                    MayorEdad++;
                }
            }
            return MayorEdad;
        }

        public static int GetMenorEdad()
        {
            int MenorEdad = 0;
            foreach (int edad in edades)
            {
                if (edad > 0 && edad < 18)
                {
                    MenorEdad++;
                }
            }
            return MenorEdad;
        }
    }
}
