using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_11_LISTA_1_Yohan_Aquino
{
    class Triangulo
    {
        private int n1;
        private int n2;
        private int n3;

        public void setNum1(int x) 
        {
            n1 = x;
        }
        public void setNum2(int x)
        {
            n2 = x;
        }
        public void setNum3(int x)
        {
            n3 = x;
        }
        public Boolean verificarTriangulo() 
        {
            if (n1 < (n2 + n3) && n2 < (n1 + n3) && n3 < (n1 + n2))
            {
                return true;
            }
            else 
            {
                return false;
            }
            }

        public string tipoTriangulo() 
        {
            if (n1 == n2 && n1 == n3 && n2 == n3)
            {
               return "Os três valores formam um triângulo equilátero";
            }
            else
            {
                if (n1 != n2 && n1 != n3 && n2 != n3)
                {
                    return "Os três valores formam um triângulo escaleno";
                }
                else
                {
                    return "Os três valores formam um triângulo isósceles";
                }
            }
        }

    }
}
