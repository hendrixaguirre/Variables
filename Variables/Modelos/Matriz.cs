using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Variables.Modelos
{
    public class Matriz
    {
        private const int FILA = 2, COLUMNA = 2;
        private int[,] matrizCuadrada = new int[FILA, COLUMNA];
        public int r { get; set; }
        public int c { get; set; }


        public bool Agregar(int dato)
        {
            if (r < FILA && c < COLUMNA)
            {
                if (c == 0)
                {
                    matrizCuadrada[r, c] = dato;
                    c++;
                }
                else
                {
                    matrizCuadrada[r, c] = dato;
                    c = 0;
                    r++;
                }
                return true;
            }
            else
            {
                MessageBox.Show("Ha llegado al límite de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        public DataTable getMatrizC()
        {
            //Creo un datatable
            DataTable dt = new DataTable();

            //Crear las columnas del datatable
            for (int colum = 0; colum < COLUMNA; colum++)
            {
                dt.Columns.Add();
            }

            // Crear filas del datatable
            for (int row = 0; row < FILA; row++)
            {
                var nuevaFila = dt.NewRow();
                for (int col = 0; col < COLUMNA; col++)
                {
                    nuevaFila[col] = matrizCuadrada[row, col];
                }
                dt.Rows.Add(nuevaFila);
            }
            return dt;
        }
    }
}
