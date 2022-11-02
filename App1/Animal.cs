using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    abstract class Animal
    {
        public abstract string Name { get; set; }

        public Animal (string name)
        {
            Name = name;
        }
        public abstract void GetSay();

        public void ShowInfo()
        {
            Console.WriteLine(Name);
            GetSay();
        }

    }

    class Cat : Animal
    {
        string say;
        string name;
        public override string Name 
        { get => name; 
          set =>name = value; 
        }

        public Cat(string name, string say)
            :base(name)
        {
            this.say = say;
        }

        public Cat(string name) : base(name)
        {
        }

        public override void GetSay()
        {
            Console.WriteLine("мяу");
        }
    }
    class Dog : Animal
    {
        string say;
        string name;
        public override string Name
        {
            get => name;
            set => name = value;
        }

        public Dog(string name, string say)
            : base(name)
        {
            this.say = say;
        }

        public Dog(string name) : base(name)
        {
        }

        public override void GetSay()
        {
            Console.WriteLine("гав");
        }
    }
}
