using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLab14
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Кошка");
            cat.ShowInfo();
            Dog dog = new Dog("Собака");
            dog.ShowInfo();
            UnnamedAnimal human = new UnnamedAnimal();
            human.ShowInfo();


            Console.WriteLine();
            Console.WriteLine("Для завершения нажмите любую клавишу");
            Console.ReadKey();
        }
    }

    abstract class Animal
    {
        public abstract string name { get; set; }

        public Animal(string name = "некое животное")
        {
            this.name = name;
        }

        public abstract string Say();

        public void ShowInfo()
        {
            string say = Say();
            Console.WriteLine("{0} \t{1}", name, say);
        }
    }

    class Cat : Animal
    {
        string Name;
        public override string name
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
        }

        public Cat(string Name)
        {
            this.name = Name;
        }

        public override string Say()
        {
            return "Мяу!";
        }
    }

    class Dog : Animal
    {
        string Name;
        public override string name
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
        }

        public Dog(string Name)
        {
            this.name = Name;
        }

        public override string Say()
        {
            return "Гав!";
        }
    }

    class UnnamedAnimal : Animal
    {
        string Name;
        public override string name
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
        }

        public override string Say()
        {
            return "Привет!";
        }
    }
}
