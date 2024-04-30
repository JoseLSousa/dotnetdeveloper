using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeiroProjetoDOTNET.models
{
    public class Calculadora
    {
        public void Somar(int x, int y){
            Console.WriteLine($"{x} + {y} = {x + y}");
        }
        public void Subtrair(int x, int y){
            Console.WriteLine($"{x} - {y} = {x - y}");
        }
        public void Multiplicar(int x, int y){
            Console.WriteLine($"{x} * {y} = {x * y}");
        }
        public void Dividir(int x, int y){
            Console.WriteLine($"{x} / {y} = {x / y}");
        }
        public void Potencia(int x, int y){
            double pot = Math.Pow(x, y);
            Console.WriteLine($"{x}^{y} = {pot}");
        }
        public void Seno(double angulo){
            double Radiano = angulo * Math.PI / 180;
            double Seno = Math.Sin(Radiano);
            Console.WriteLine($"Seno de {angulo} = {Math.Round(Seno, 4)}");
        }
        public void Coseno(double angulo){
            double Radiano = angulo * Math.PI / 180;
            double Coseno = Math.Tan(Radiano);
            Console.WriteLine($"Coseno de {angulo} = {Math.Round(Coseno, 4)}");
        }
        public void Tangente(double angulo){
            double Radiano = angulo * Math.PI / 180;
            double Tangente = Math.Tan(Radiano);
            Console.WriteLine($"Tangente de {angulo} = {Math.Round(Tangente, 4)}");
        }
        public void RaizQuadrada(double x){
            double raiz = Math.Sqrt(x);
            Console.WriteLine($"Raiz quadrada de {x} ={Math.Round(raiz, 4)}");
        }
    }
}