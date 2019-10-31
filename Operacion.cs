using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T02.Aplicacion_Interface
{
     class Operacion: Principal,Ivalor,IOperaciones
    {
        //clase donde se realiza la herencia y se usan las clases de interfas
        public double Suma { get; set; }
        public double Resta { get; set; }
        public double Divicion { get; set; }
        public double Multiplicacion { get; set; }
        public double ValorA { get; set; }
        public double ValorB { get; set; }

        public override string Numeros()
        {
            return "El valor A es:" + ValorA + "\n" + "El valor B es: " + ValorB;
            //Mensaje que muestra los valores que contienen las variables

        }


        public  double SumaRes()
        {
            //realizacion de las operaciones

            Suma = ValorA + ValorB;
            return Suma = ValorA + ValorB;
        }


        public double RestaRes()
        {
            //realizacion de las operaciones


            Resta = ValorA - ValorB;
            return Resta;
        }
        

        public double DivicionRes()
        {
            //realizacion de las operaciones


            Divicion = ValorA / ValorB;
            return Divicion;

        }


        public double MultiplicacionRes()
        {
            //realizacion de las operaciones


            Multiplicacion = ValorA * ValorB;
            return Multiplicacion;

        }



    }
}
