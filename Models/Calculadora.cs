using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projetos_dotNet.Models
{
    public class Calculadora
    {
        public void Soma(int x, int y){
            Console.WriteLine($"{x}+{y} = {x+y}");
        }

        public void Subtrair(int x, int y){
            Console.WriteLine($"{x}-{y} = {x-y}");
        }

        public void Multiplicar(int x, int y){
            Console.WriteLine($"{x}x{y} = {x*y}");
        }

        public void Dividir(double x, double y){
            Console.WriteLine($"{x}/{y} = {x/y}");
        }

        public void Potencia(int x, int y){
            double pot = Math.Pow(x,y);
            Console.WriteLine($"{x}^{y} = {pot}");
        }

        public void Seno(double angulo){
            double radiano = angulo*Math.PI/180;
            double seno = Math.Sin(radiano);
            Console.WriteLine($"Seno({angulo}) = {Math.Round(seno,4)}");
        }

        public void Cosseno(double angulo){
            double radiano = angulo*Math.PI/180;
            double cosseno = Math.Cos(radiano);
            Console.WriteLine($"Cosseno({angulo}) = {Math.Round(cosseno,4)}");
        }

        public void Tangente(double angulo){
            double radiano = angulo*Math.PI/180;
            double tangente = Math.Tan(radiano);
            Console.WriteLine($"Tangente({angulo}) = {Math.Round(tangente,4)}");
        }

        public void RaizQuadrada(double x){
            double raiz = Math.Sqrt(x);
            Console.WriteLine($"Raiz quadrada de {x} é {raiz}");
        }

    }
}