using System;
using System.Collections.Generic;

namespace Alumno
{
    //creacion de clase
    class Alumno
    {
        //declaracion de variables
        protected string nombre;
        protected string tialu;
        
        //constuctor que toma como parametros el nombre y el titulo que esta cursando
        public Alumno(string no, string tialu)
        {
            this.nombre = no;
            this.tialu = tialu;
        }

        //metodo de imprecion
        public void print()
        {
            //condicion extra que ve si es licenciado o posgrado
            if(tialu == "Licenciatura")
            Console.WriteLine($"{nombre} tienes que hacer servicio social y recidencia\n");
            
            else if(tialu == "Posgrado")
            Console.WriteLine($"{nombre} tienes que hacer una investigacion de un tema");
        }
    }

    //clase heredada de la clase alumno
    class Licenciatura:Alumno
    {
        //construcor de la clase que recibe el nombre y titulo
        public Licenciatura(string nombre, string tialu):base(nombre, tialu)
        {
            
        }
        //metodo de imprecion
        public new void print()
        {
            //condiciones ya mencionadas
            if(tialu == "Licenciatura")
            Console.WriteLine($"{nombre} tienes que hacer servicio social y recidencia\n");
            
            else if(tialu == "Posgrado")
            Console.WriteLine($"{nombre}tienes que hacer una investigacion de un tema");
        }
    }

    //clase heredada de la clase alumno
    class Posgrado:Alumno
    {
        //constructor que recibe el nombre y el titulo
        public Posgrado(string nombre, string tialu):base(nombre, tialu)
        {

        }
        //metodo de imprecion
        public new void print()
        {
            //condicion ya mencionada
            if(tialu == "Licenciatura")
            Console.WriteLine($"{nombre} tienes que hacer servicio social y recidencia");
            
            else if(tialu == "Posgrado")
            Console.WriteLine($"{nombre}tienes que hacer una investigacion de un tema");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //pureba de la condicion y crecion de alumnos
            Alumno prueba = new Alumno("nombre", "Posgrado");
            Alumno prueba1 = new Alumno("nombre", "Licenciatura");
            prueba.print();
            prueba1.print();

            //creacion de alumno y imprecion
            Licenciatura a = new Licenciatura("Carlos", "Licenciatura");
            a.print();
            //creacion de alumno y imprecion
            Posgrado b = new Posgrado("Tom", "Posgrado");
            b.print();
        }
    }
}
