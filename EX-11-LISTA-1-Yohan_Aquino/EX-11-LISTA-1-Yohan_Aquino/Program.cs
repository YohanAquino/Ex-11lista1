using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_11_LISTA_1_Yohan_Aquino
{
    class Program
    {
        static void Main(string[] args)
        {
            /*12. A partir de três valores que serão digitados, verificar se formam ou não um triângulo. Em
caso positivo, exibir sua classificação: “Isósceles, escaleno ou eqüilátero”. Um triângulo escaleno
possui todos os lados diferentes, o isósceles, dois lados iguais e o eqüilátero, todos os lados
iguais. Para existir triângulo é necessário que a soma de dois lados quaisquer seja maior que o
outro, isto, para os três lados. */
            Triangulo tri = new Triangulo();

            Console.WriteLine("Digite o 1°valor");
            tri.setNum1(int.Parse(Console.ReadLine()));

            Console.WriteLine("Digite o 2°valor");
            tri.setNum2(int.Parse(Console.ReadLine()));

            Console.WriteLine("Digite o 3°valor");
            tri.setNum3(int.Parse(Console.ReadLine()));

            if (tri.verificarTriangulo()) 
            {
                Console.WriteLine(tri.tipoTriangulo());
            }
            else 
            {
                Console.WriteLine("Não forma um triangulo");
            }
            Console.ReadKey();
        }
    }
}
