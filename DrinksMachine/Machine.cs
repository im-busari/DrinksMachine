using System;
using System.Collections.Generic;
using System.Text;

namespace DrinksMachine
{
    class Machine
    {
        private int _tea;
        private int _coffee;
        private int _sugar;
        private int _milk;
        private int _cups;

        public Machine()
        {
            this._tea = 10;
            this._coffee = 10;
            this._sugar = 10;
            this._milk = 10;
            this._cups = 10;
        }

        public void ReduceTea()
        {
            this._tea -= 1;

            /*if (this._tea > 0)  {
                this._tea -= 1;
                return true;
            }
            Console.WriteLine("Oopss.. We are out of tea.");
            return false;*/
        }

        public void ReduceCoffee()
        {
            this._coffee -= 1;
        }

        public void ReduceSugar()
        {
            this._sugar -= 1;
        }

        public void ReduceMilk()
        {
            this._milk -= 1;
        }

        public void ReduceCups()
        {
            this._cups -= 1;
        }

        public int Tea { get => this._tea; }
        public int Coffee { get => this._coffee; }
        public int Sugar { get => this._sugar; }
        public int Milk { get => this._milk; }
        public int Cups { get => this._cups; }


    }
}
