using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TADPila
{
    class Program
    {

        static void Main(string[] args)
        {

            Menu();
        }
        public static void Menu()
        {
            Console.WriteLine("******** Menu de TAD PILA ********");
            Console.WriteLine("1.Insertar dato en pila");
            Console.WriteLine("2.Eliminar dato en pila");
            Console.WriteLine("3.Imprimir pila");
            int opcion = int.Parse(Console.ReadLine());
            Opciones(opcion);
        }
        public static void Opciones(int op){
            switch (op)
            {
                case 1:Insertar();
                    break;
                case 2:Eliminar();
                    break;
                case 3:Imprimir();
                    break;

               default:Menu();
                    break;
            }
        }
        static String [] Pila=new String[5];
        static int cima = -1;
        public static void Insertar()
        {
            Console.WriteLine("Ingrese un dato a la Pila");
            String dato = Console.ReadLine();
            Crear(dato);
        }
        public static void Crear(String dato)
        {
            if ((Pila.Length-1)==cima)
            {
                Console.WriteLine("Capacidad de la pila al límite");
                Imprimir();
            }
            else
            {
                cima++;
            }
            Agregar(dato);
        }
        public static void Agregar(String dato)
        {
            Pila[cima] = dato;
            Menu();
        }
        public static void Eliminar()
        {
            if (cima==-1)
            {
                Console.WriteLine("la pila esta vacíá");
            }
            else
            {
                Pila[cima] = null;
                --cima;
            }
            Menu();
        }
        public static void Imprimir()
        {
            for (int i = Pila.Length-1; i >=0 ; i--)
            {
                Console.WriteLine(Pila[i]);
            }
            Menu();
        }
        
    }
}
