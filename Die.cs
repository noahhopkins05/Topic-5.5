﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topic_5._5
{
    public class Die
    {
        private int _roll;
        private Random _generator;

        public Die()
        {
            _generator = new Random();
            _roll = _generator.Next(1, 7);
        }

        public int Roll { get { return _roll; } }

        public override string ToString()
        {
            return _roll.ToString();
        }

        public int RollDie()
        {
            _roll = _generator.Next(1, 7);
            return _roll;
        }

        public void DrawRoll()
        {
            if (_roll == 1)
            {
                Console.WriteLine("-----");
                Console.WriteLine("|    |");
                Console.WriteLine("|  o |");
                Console.WriteLine("|    |");
                Console.WriteLine("-----");
            }
            if (_roll == 2)
            {
                Console.WriteLine("-----");
                Console.WriteLine("|o   |");
                Console.WriteLine("|    |");
                Console.WriteLine("|  o |");
                Console.WriteLine("-----");
            }
            if (_roll == 3)
            {
                Console.WriteLine("-----");
                Console.WriteLine("|o   |");
                Console.WriteLine("| o  |");
                Console.WriteLine("|  o |");
                Console.WriteLine("-----");
            }
            if (_roll == 4)
            {
                Console.WriteLine("-----");
                Console.WriteLine("|o o |");
                Console.WriteLine("|    |");
                Console.WriteLine("|o o |");
                Console.WriteLine("-----");
            }
            if (_roll == 5)
            {
                Console.WriteLine("-----");
                Console.WriteLine("|o o |");
                Console.WriteLine("| o  |");
                Console.WriteLine("|o o |");
                Console.WriteLine("-----");
            }
            else 
            {
                Console.WriteLine("-----");
                Console.WriteLine("|o o |");
                Console.WriteLine("| o  |");
                Console.WriteLine("|o o |");
                Console.WriteLine("-----");
            }
           
        }

    }
}
