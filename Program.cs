using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador, acumulador;
            int cantidad, maximo, minimo;
            int valor;
            int promedio;
            maximo = 0; minimo = 10000000;
            contador = 0;
            acumulador = 0;
            Console.WriteLine("ingrese la cantidad de numeros a entrar");
            string linea = Console.ReadLine();
            cantidad = Convert.ToInt32(linea);

            for (int n=0; n<cantidad;n++)
            {
                
                Console.WriteLine("ingrese el valor del numero");
                string numero = Console.ReadLine();
                valor = Convert.ToInt32(numero);
                acumulador = acumulador+ valor;
                if (valor > maximo)
                {
                    maximo = valor;
                }
                if (valor < minimo)
                {
                    minimo = valor;
                }
                
                contador++;
            }
            if (cantidad > 0) ;
            {
                promedio = acumulador / cantidad;
            }
            if (cantidad > 0)
            {
                Console.WriteLine("el maximo: " + maximo + " el minimo es: " + minimo + " y el promedio es:" + promedio);
            }
            else
            {
                Console.WriteLine("no se ingresaron valores");
            }
        }
    }
}
