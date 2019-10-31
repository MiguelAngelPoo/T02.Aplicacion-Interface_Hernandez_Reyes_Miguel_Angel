using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T02.Aplicacion_Interface
{
    class Program
    {
        static void Main(string[] args)
        {//instaciamos la clase operacion
            Operacion Op = new Operacion();
            Op.ValorA = 10;//asignamos valores para A y B
            Op.ValorB = 20;
            Menu();


            //Menu de opciones para despleglar resultados
            void Menu()
            {
                Console.WriteLine(Op.Numeros());
                Console.WriteLine("Menu de resultados que mirar");
                Console.WriteLine("1-Sumar");
                Console.WriteLine("2-Restar");
                Console.WriteLine("3-divicion");
                Console.WriteLine("4-multiplicacion");
                Console.WriteLine("5-Todas");
                Console.WriteLine("6-Salir");


                Console.WriteLine("Dame opcion: ");

                int Op2 = Convert.ToInt32(Console.ReadLine());

                //opciones de desplige y salida
                switch (Op2)
                {
                    case 1:
                        Console.WriteLine("El resultado de la suma es: " + Op.SumaRes());
                        Console.ReadKey();
                        Console.Clear();
                        Menu();
                        
                        break;
                    case 2:
                        Console.WriteLine("El resultado de la resta es: " + Op.RestaRes());
                        Console.ReadKey();
                        Console.Clear();
                        Menu();
                        break;
                    case 3:
                        Console.WriteLine("El resultado de la divicion es: " + Op.DivicionRes());
                        Console.ReadKey();
                        Console.Clear();
                        Menu();
                        break;
                    case 4:
                        Console.WriteLine("El resultado de la multiplicacion es: " + Op.MultiplicacionRes());
                        Console.ReadKey();
                        Console.Clear();
                        Menu();

                        break;
                    case 5:
                        Console.WriteLine("El resultado de la suma es: " + Op.SumaRes());
                        Console.WriteLine("El resultado de la resta es: " + Op.RestaRes());
                        Console.WriteLine("El resultado de la divicion es: " + Op.DivicionRes());
                        Console.WriteLine("El resultado de la multiplicacion es: " + Op.MultiplicacionRes());
                        Console.ReadKey();
                        Console.Clear();
                        Menu();
                        break;
                    case 6:
                        //codigo para salir
                        Environment.Exit(0);
                        break;
                }




                Console.ReadKey();
            }



        }
    }
}
