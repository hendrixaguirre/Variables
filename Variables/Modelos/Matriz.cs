using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables.Modelos
{
    public class Matriz
    {
       private const int fila = 2, columna = 2;
       private int[,] matrizCuadrada = new int[2, 2];
       public int r { get; set; }
       public int c { get; set; }


        public void Agregar(int dato)
        {
            if (r == fila)
            {
                if (c == columna)
                {
                    return;
                }
            }
            if (c == columna)
            {
                c = 0;
                r++;
            }
            matrizCuadrada[r, c] = dato;
            c++;
        }

        public int[,] GetMatriz()
        {
            return matrizCuadrada;
        }
    }
}
