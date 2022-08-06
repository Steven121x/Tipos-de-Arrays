using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arrays implicitos
            //Arrays implicito incorrecto
            //var datos = new[] {"Juan", "Diaz", "10"};

            //Arrays implicito correcto
            var valores = new[] { 10, 23, 1.2, 5.8 };

            //Arrays implicito correcto

            var valores2 = new[] { 10, 40, 50, 60, 87 };

            //Arrays de objetos

            Empleados Ana = new Empleados("ana", 30);//Crear objeto y darle valor a los parametros | de la linea [ 27 ] 
            Empleados[] arraysEmpleados = new Empleados[2];

            //crear mientras almacenamos el objeto

            arraysEmpleados[0] = new Empleados("sara", 27);

            //crear objeto luego al almacenarlo

            arraysEmpleados[1] = Ana;

            // arrays de tipos o clases anonimas

            var personas = new[]
            {
                new{nombre="juan", edad=19 },// Pos 0

                new{nombre="diana", edad=35 }, // Pos 1

                new{nombre="Sara", edad=19 }, //Posicion y valores //Pos 2

            }; //aqui se termina  
        }
    }

    class Empleados
    {
        //Constructor publico | Para dar valor a los obj del array
        public Empleados(String nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
            

        }
        public Empleados()
        {
          

        }
        //Variables del Constructor para los arrays de objeto
        public int edad;
        public string nombre;
    }
}
