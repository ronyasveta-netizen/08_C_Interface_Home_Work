using System;
using System.Collections.Generic;
using System.Text;

namespace _08_C_Interface_Home_Work
{
    class Square : Shape
    {
        private int side;

        public int Side
        {
            get => side;

            //set => side = value > 0 ? value : throw new ArgumentOutOfRangeException("Сторона має бути додатним числом!");

            set => side = value > 0 ? value : 1;
        }

        public Square() : base()
        {
            Side = ReadInt("Введіть сторону квадрата: ");
        }

        public Square(int x, int y, ConsoleColor color, char symbol, int side)
            : base(x, y, color, symbol)
        {
            Side = side; 
        }

        public override double Area => Side * Side;

        public override double Perimeter => 4 * Side;

        public override void Draw()
        {
            Console.ForegroundColor = Color;

            // Зміщення по Y
            for (int i = 0; i < Y; i++)
                Console.WriteLine();

            // Малювання квадрата
            for (int i = 0; i < Side; i++)
            {
                // Зміщення по X
                Console.Write(new string(' ', X));

                for (int j = 0; j < Side * 2 ; j++) // подвоїв side - так фігура більше на квадрат подібниа  
                    Console.Write(Symbol);
                    

                Console.WriteLine();
            }

            Console.ResetColor();
        }

        public override void Print()
        {
            Console.ForegroundColor = Color;

            Console.WriteLine($"\n\t -------- {this.GetType().Name} -----------");
            Console.WriteLine($"Фігура    :  {this.GetType().Name}");
            Console.WriteLine($"Координати:  ({X}, {Y})");
            Console.WriteLine($"Колір     :  {Color}");
            Console.WriteLine($"Символ    :  '{Symbol}'");
            Console.WriteLine($"Сторона   :  {Side}");
            Console.WriteLine($"Площа     :  {Area}");
            Console.WriteLine($"Периметр  :  {Perimeter}");

            Console.ResetColor();
        }
    }
}
