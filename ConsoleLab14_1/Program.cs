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
            Cat cat1 = new Cat("Кошка");
            cat1.ShowInfo();
            Dog dog1 = new Dog("Собака");
            dog1.ShowInfo();
            Cat cat2 = new Cat();
            cat2.ShowInfo();
            Dog dog2 = new Dog();
            dog2.ShowInfo();
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

        public Cat()
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

        public Dog()
        {
            this.name = Name;
        }

        public override string Say()
        {
            return "Гав!";
        }
    }
}
