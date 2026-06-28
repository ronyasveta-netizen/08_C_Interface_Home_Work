using System;
using System.Collections.Generic;
using System.Text;

namespace _08_C_Interface_Home_Work
{
    class Rectangle : Shape
    {
        private int width;
        private int height;

        public int Width
        {
            get => width;

            //set => width = value > 0 ? value : throw new ArgumentOutOfRangeException("Ширина має бути додатним числом!");

            set => width = value > 0 ? value : 1;
        }

        public int Height
        {
            get => height;

            //set => height = value > 0 ? value : throw new ArgumentOutOfRangeException("Висота має бути додатним числом!");

            set => height = value > 0 ? value : 1;
        }

        public Rectangle() : base()
        {
            Width = ReadInt("Введіть ширину прямокутника: ");
            Height = ReadInt("Введіть висоту прямокутника: ");
        }

        public Rectangle(int x, int y, ConsoleColor color, char symbol, int width, int height)
            : base(x, y, color, symbol)
        {
            Width = width;   
            Height = height; 
        }

        public override double Area => Width * Height;

        public override double Perimeter => 2 * (Width + Height);

        public override void Draw()
        {
            Console.ForegroundColor = Color;

            for (int i = 0; i < Y; i++)
                Console.WriteLine();

            for (int i = 0; i < Height; i++)
            {
                Console.Write(new string(' ', X));

                for (int j = 0; j < Width * 2; j++)
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
            Console.WriteLine($"Ширина    :  {Width}");
            Console.WriteLine($"Висота    :  {Height}");
            Console.WriteLine($"Площа     :  {Area}");
            Console.WriteLine($"Периметр  :  {Perimeter}");

            Console.ResetColor();
        }
    }
}