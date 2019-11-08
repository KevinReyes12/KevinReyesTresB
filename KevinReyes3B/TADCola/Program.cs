using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TADCola
{
    class Program
    {
        static void Main(string[] args)
        {


        }
        Object[] ArregloCola;
        int primero = -1, ultimo = -1, Num_elem;
        Object[] ArregloColaaux;
        int primeroaux = -1, ultimoaux = -1;
        int Cant_elem = 5;

        
        

        //Encola un elemento
        public void Ingresar(Object x)
        {
            if (VaciaCola())
            { //si mi cola esta vacia
                ultimo++;  //ese dato es el ultimo
                primero++;  //ese dato sera el primero
                ArregloCola[ultimo] = x;   //guardo el dato x en el
            }                               //ArregloCola en la posicion de ultimo
            else
            {  //si hay datos

                if (ultimo == Cant_elem - 1) //esta lleno mi cola
                    Console.WriteLine("No hay campo"); 

            else
                {
                    ultimo++; //pasa a ser el ultimo por eso incrementa
                    ArregloCola[ultimo] = x; //guardo el dato X

                }
            }
        }
        public void Ingresaraux(Object x)
        {
            if (VaciaCola())
            { //si mi cola esta vacia
                ultimoaux++;  //ese dato es el ultimo
                primeroaux++;  //ese dato sera el primero
                ArregloColaaux[ultimoaux] = x;   //guardo el dato x en el
            }                               //ArregloCola en la posicion de ultimo
            else
            {  //si hay datos

                if (ultimoaux == Cant_elem - 1) //esta lleno mi cola
                    Console.WriteLine("No hay campo");

            else
                {
                    ultimoaux++; //pasa a ser el ultimo por eso incrementa
                    ArregloColaaux[ultimoaux] = x; //guardo el dato X

                }
            }
        }
        public Object Avanzar()
        {
            Object data = null;
            if (VaciaCola()) //si la cola esta vacia
                Console.WriteLine("No hay Elementos"); 

        else
            { //si hay datos
                data = ArregloCola[primero]; //hago una copia del dato que sale
                if (primero == ultimo)
                { //solo hay un dato
                    primero = -1;  //cola queda vacia
                    ultimo = -1;   // cola queda vacia
                }
                else
                {  //hay mas de un dato
                    primero++;
                }

            }
            return (data);  //retorno el dato que sale de la cola
        }

        //Desencola un elemento
        public Object Avanzaraux()
        {
            Object data = null;
            if (VaciaColaaux()) 
                Console.WriteLine("No hay Elementos"); 

        else
            { //si hay datos
                data = ArregloColaaux[primeroaux]; 
                if (primeroaux == ultimoaux)
                { //solo hay un dato
                    primeroaux = -1;  
                    ultimoaux = -1;   
                }
                else
                {  //hay mas de un dato
                    primeroaux++;
                }

            }
            return (data);  //retorno el dato que sale de la cola
        }


        //Retorna si esta vacia la cola
        public Boolean VaciaCola()
        {
            if ((ultimo == -1) && (primero == -1))
                return (true);  //cola vacia
            else
                return (false);  //cola tiene datos
        }
        public Boolean VaciaColaaux()
        {
            if ((ultimoaux == -1) && (primeroaux == -1))
                return (true);  //cola vacia
            else
                return (false);  //cola tiene datos
        }
        public void Imprimir()
        {
            Object desplazarse2;
            if (VaciaCola())
            {
                Console.WriteLine("No hay elementos"); 
            }
            else
            {
                Console.WriteLine("La Cola es: "); 
                while (!VaciaCola())
                {
                    desplazarse2 = Avanzar();
                    Ingresaraux(desplazarse2);
                } while (!VaciaColaaux())
                {
                    desplazarse2 = Avanzaraux();
                    Console.WriteLine(desplazarse2 + "\t"); 
                    Ingresar(desplazarse2);



                }
                Console.Write(""); 
            }
        }
        public int contar()
        {
            Object desplazarse2;
            int contador = 0;
            if (VaciaCola())
            {
                Console.WriteLine("No hay elementos"); 
            }
            else
            {
                //System.out.print("La Cola es: ");
                while (!VaciaCola())
                {
                    desplazarse2 = Avanzar();
                    contador = contador + 1;
                    Ingresaraux(desplazarse2);
                } while (!VaciaColaaux())
                {
                    desplazarse2 = Avanzaraux();
                    //System.out.println(desplazarse2+"\t");
                    Ingresar(desplazarse2);



                }
                //System.out.print("");
            }
            return (contador);
        }


    }
    
}
