using System;
using System.Collections.Generic;
using System.Text;

namespace DrinksMachine
{
    class Drinks
    {
        private int _tea;
        private int _teaS;
        private int _teaM;
        private int _teaSM;
        private int _coffee;
        private int _coffeeS;
        private int _coffeeM;
        private int _coffeeSM;
        string message = "WARNING! WE ARE OUT OF STOCK!";


        public Drinks()
        {
            this._tea = 0;
            this._teaS = 0;
            this._teaM = 0;
            this._teaSM = 0;
            this._coffee = 0;
            this._coffeeS = 0;
            this._coffeeM = 0;
            this._coffeeSM = 0;
        }

        public void AddTea(ref Machine machine)
        {
            if (machine.Tea > 0 & machine.Cups > 0)
            {
                machine.ReduceTea();  machine.ReduceCups();

                this._tea += 1;
                Console.WriteLine("You chose 1 cup of tea.");
            } else
            {
                Console.WriteLine(message);
            }
            Console.WriteLine("Cup(s) of tea = {0}", this._tea);
        }

        public void AddTeaS(ref Machine machine)
        {
            if (machine.Tea > 0 & machine.Sugar > 0 & machine.Cups > 0)
            {
                machine.ReduceTea(); machine.ReduceSugar(); machine.ReduceCups();
                this._teaS += 1;
                Console.WriteLine("You chose 1 cup of tea + sugar.");
            } else
            {
                Console.WriteLine(message);
            }
            Console.WriteLine("Cup(s) of tea (+ sugar) = {0}", this._teaS);
        }
        public void AddTeaM(ref Machine machine)
        {
            if (machine.Tea > 0 & machine.Milk > 0 & machine.Cups > 0)
            {
                machine.ReduceTea(); machine.ReduceMilk();  machine.ReduceCups();
                this._teaM += 1;
                Console.WriteLine("You chose 1 cup of tea + milk.");
            } else
            {
                Console.WriteLine(message);
            }
            Console.WriteLine("Cup(s) of tea (+ milk) = {0}", this._teaM);
        }
        public void AddTeaSM(ref Machine machine)
        {
            if (machine.Tea > 0 & machine.Sugar > 0 & machine.Milk > 0 & machine.Cups > 0)
            {
                // reduce quantity of relevant items
                machine.ReduceTea();  machine.ReduceSugar(); machine.ReduceMilk(); machine.ReduceCups();

                this._teaSM += 1;
                Console.WriteLine("You chose 1 cup of tea + sugar + milk.");
            } else
            {
                Console.WriteLine(message);
            }
            Console.WriteLine("Cup(s) of tea (+ sugar & milk) = {0}", this._teaSM);
        }
        public void AddCoffee(ref Machine machine)
        {
            if (machine.Coffee > 0 & machine.Cups > 0)
            {
                machine.ReduceCoffee(); machine.ReduceCups();
                this._coffee += 1;
                Console.WriteLine("You chose 1 cup of coffee.");
            }
            Console.WriteLine("Cup(s) of coffee = {0}", this._coffee);
        }
        public void AddCoffeeS(ref Machine machine)
        {
            if (machine.Coffee > 0 & machine.Sugar > 0 & machine.Cups > 0)
            {
                //  reduce quantity of relevant items
                machine.ReduceCoffee(); machine.ReduceSugar(); machine.ReduceCups();
                this._coffeeS += 1;
                Console.WriteLine("You chose 1 cup of coffee + sugar.");
            }
            Console.WriteLine("Cup(s) of coffee (+ sugar) = {0}", this._coffeeS);
        }
        public void AddCoffeeM(ref Machine machine)
        {
            if (machine.Coffee > 0 & machine.Milk > 0 & machine.Cups > 0)
            {
                machine.ReduceCoffee();
                machine.ReduceMilk(); 
                machine.ReduceCups();

                this._coffeeM += 1;
                Console.WriteLine("You chose 1 cup of coffee + milk.");
            } else
            {
                Console.WriteLine(message);
            }
            Console.WriteLine("Cup(s) of coffee (+ milk) = {0}", this._coffeeM);
        }
        public void AddCoffeeSM(ref Machine machine)
        {
            if (machine.Coffee > 0 & machine.Sugar > 0 & machine.Milk > 0 & machine.Cups > 0)
            {
                //  reduce the quantity or the relevant items
                machine.ReduceCoffee(); machine.ReduceSugar(); machine.ReduceMilk(); machine.ReduceCups();

                this._coffeeSM += 1;
                Console.WriteLine("You chose 1 cup of coffee + sugar + milk.");
            } else
            {
                Console.WriteLine(message);
            }

            Console.WriteLine("Cup(s) of coffee (+ sugar & milk) = {0}", this._coffeeSM);
        }


        public int Tea { get => this._tea; }
        public int TeaS { get => this._teaS; }
        public int TeaM { get => this._teaM; }
        public int TeaSM { get => this._teaSM; }
        public int Coffee { get => this._coffee; }
        public int CoffeeS { get => this._coffeeS; }
        public int CoffeeM { get => this._coffeeM; }
        public int CoffeeSM { get => this._coffeeSM; }

    }
}
