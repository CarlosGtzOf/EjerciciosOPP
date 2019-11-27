using System;
using System.Collections.Generic;

namespace MusicoAbstracto
{
    //creacion de clase abstracta
    abstract class Musico 
    {
        //declaracion de variable protegida para poder ser heredada y usada
        protected string nombre;
        
        //constructor con el parametro de nombre
        public Musico(string n)
        {
            nombre = n;
        }

        //metodos abstractos que tendran que usar las clases heredadas de musico
        public abstract void Saluda();

        public abstract void Afina();

        public abstract void toca();
    }

    //clase bajista heredando de musico
    class Bajista:Musico
    {
        //variable privada
        private string bajo;
        
        //construcot que toma el nombre de la clase musico, y toma como parametro el bajo
        public Bajista(string no,string bajo):base(no)
        {
            this.bajo = bajo;
        } 

        //metodos aplicados en la clase heredada, que la clase principal requiere
       public override void Afina()
        {
           Console.WriteLine($"{nombre} esta afinando su bajo {bajo}");
        }

       public override void Saluda()
        {
           Console.WriteLine($"hola soy {nombre} y soy bajista");
        }

       public override void toca()
        {
           Console.WriteLine($"toca {nombre} su bajo {bajo}\n");
        }
    }

    class Guitarrista:Musico
    {
        //variable privada
        private string Guitarra;

        //construcot que toma el nombre de la clase musico, y toma como parametro la guitarra
        public Guitarrista(string no,string Guitarra):base(no)
        {
            this.Guitarra = Guitarra;
        } 

        //metodos aplicados en la clase heredada, que la clase principal requiere
        public override void Afina()
        {
            Console.WriteLine($"{nombre} esta afinando su guitarra {Guitarra}");
        }

        public override void Saluda()
        {
            Console.WriteLine($"hola soy {nombre} y soy guitarrista");
        }

        public override void toca()
        {
            Console.WriteLine($"toca {nombre} su bajo {Guitarra}\n");
        }
    }

    class Baterista:Musico
    {
        //variable privada
        private string bateria;

        //construcot que toma el nombre de la clase musico, y toma como parametro la bateria
        public Baterista(string no, string bateria):base(no)
        {
            this.bateria = bateria;
        }

        //metodos aplicados en la clase heredada, que la clase principal requiere
        public override void Afina()
        {
            Console.WriteLine($"{nombre} esta afinando su bateria {bateria}");
        }
        
        public override void Saluda()
        {
            Console.WriteLine($"hola soy {nombre} y soy baterista");
        }

        public override void toca()
        {
            Console.WriteLine($"toca {nombre} su bateria {bateria}");
        }
    }


    class Program
    { 

        static void Main()
        {   
            //declaracion de los musicos
            Bajista flea = new Bajista("flea", "Yamaha");
            Guitarrista Tom = new Guitarrista("Tom", "Gibson");
            Baterista Carlos = new Baterista("Carlos", "Yamaha");

            //lista que añade a los musicos para que se impriman en el foreach los saludos, la afinacion y el tocar
            List<Musico> grupo = new List<Musico>();
            grupo.Add(flea);
            grupo.Add(Tom);
            grupo.Add(Carlos);
            foreach(Musico m in grupo)
            {
                m.Saluda();
                m.Afina();
                m.toca();
            }

        }
    }
}