using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burbuja.operaciones
{
    internal class MetBurbuja
    {
       //metodo burbuja consiste en comparar dos valores 
       public void ordenarBurbuja(int[] arreglo)
       {
            for(int i = 0; i <= arreglo.Length; i++)
            {
                for(int j=i+1; j< arreglo.Length; j++)
                {
                    if (arreglo[i] < arreglo[i])
                    {
                        int temp = arreglo[i];
                        arreglo[j] = arreglo[i];
                        arreglo[i] = temp;
                    }
                }
            }
       }
    }
}
