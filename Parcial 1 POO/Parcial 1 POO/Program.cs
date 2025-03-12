using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_1_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] iArreglo = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };//declaro las variables del arreglo
            Console.WriteLine("A continuación sale el areglo");//impresión de consola
            for (int i = 0; i < iArreglo.Length; i++)//recorre el arreglo
            {
                Console.Write(iArreglo[i] + " ");//imprime el arreglo con un espacio en blanco
            }
            Console.WriteLine();
            Console.WriteLine("Se va a modificar el indice 2 por el numero 99");
            iArreglo[2] = 99;//se cambia el tercer elemento (indice 2) por el valor 99
            Console.WriteLine("Se va a imprimir el arreglo actualizado");
            for (int i = 0; i < iArreglo.Length; i++)//se recorre nuevamente el arreglo
            {
                Console.Write(iArreglo[i] + " ");//imprime el arreglo con el indice cambiado por el numero 99
            }
            Console.WriteLine();
            int iContador = 0;//declaro mi contador
            for (int i = 0; i < iArreglo.Length; i++)//este for recorre el arreglo
            {
                iContador += iArreglo[i];//este es el contador
            }
            Console.WriteLine("El resultado de la suma de los elementos es: " + iContador);//imprimo el mensaje de la suma y el valor
            Console.WriteLine("escriba un numero para buscar en el arreglo");//le pido al usuario un numero para buscar en el arreglo
            int iBuscar = int.Parse(Console.ReadLine());//declaro el buscador de mi arreglo
            int iNavigate = Array.IndexOf(iArreglo, iBuscar);//declaro mi navegador en el arreglo
            if (iNavigate == -1){
                Console.WriteLine("El elemento no fue encontrado");//imprime si no fue encontrado el numero
            }
            else//declaro en caso de que no se cumpla el if entra el else
            {
                Console.WriteLine("Nuestro número " + iBuscar + " Fue encontrado en el arreglo y esta en el indice " + iNavigate);//imprime si fue encontrado el numero y en que indice 
            }
        }
    }
}
