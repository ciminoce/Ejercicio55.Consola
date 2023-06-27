using System;

namespace Ejercicio55.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cantidadMultiplos = 0;
            
            
            #region Ingreso nroIngresado
            int nroIngresado = PedirEntero("Ingrese un número entero:");
            #endregion
            #region Ingreso Limite Inferior
            int limiteMenor = PedirEntero("Ingrese el valor del límite menor:");
            #endregion
            int limiteMayor = PedirEntero("Ingrese el valor del límite mayor:");
            Console.WriteLine($"Múltiplos del número {nroIngresado}");
            for (int contador = limiteMenor; contador <= limiteMayor; contador++)
            {
                if (EsMultiplo(contador, nroIngresado))
                {
                    cantidadMultiplos++;//cantidadMultiplos=cantidadMultiplos+1
                    Console.WriteLine($"{contador}");
                }
            }
            Console.WriteLine($"Cantidad de Múltiplos={cantidadMultiplos}");
            Console.ReadLine();
        }

        private static bool EsMultiplo(int contador, int nroIngresado)
        {
            return contador % nroIngresado == 0;
        }
        private static int PedirEntero(string Mensaje)
        {
            int nro = 0;
            do
            {
                Console.Write(Mensaje);
                string strConsola = Console.ReadLine();
                if (!int.TryParse(strConsola, out nro))
                {
                    Console.WriteLine("Número mal ingresado");

                }
                else
                {
                    break;
                }

            } while (true);
            return nro;
        }
    }
}
