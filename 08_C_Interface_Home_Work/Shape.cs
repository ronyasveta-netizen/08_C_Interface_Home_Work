using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace _08_C_Interface_Home_Work
{
    abstract class Shape : ILocated, IColored, IPrintable, IMovable
    {
        public int X { get; set; }
        public int Y { get; set; }

        public ConsoleColor Color { get; set; }

        public char Symbol { get; set; }

        public Shape()
        {
            X = ReadInt("Введіть X: ");
            Y = ReadInt("Введіть Y: ");
            Color = ReadColor();
            Symbol = ReadChar("Введіть одмн символ  для малювання фігури: ");
        }

        public Shape(int x = 0, int y = 0, ConsoleColor color = ConsoleColor.White, char symbol = '$')
        {
            X = x;
            Y = y;
            Color = color;
            Symbol = symbol;
        }

        public virtual void Print()
        {
            Console.ForegroundColor = Color;

            Console.WriteLine($"\n\t -------- {this.GetType().Name} -----------");
            Console.WriteLine($"Фігура    :  {this.GetType().Name}");
            Console.WriteLine($"Координати:  ({X}, {Y})");
            Console.WriteLine($"Колір     :  {Color}");
            Console.WriteLine($"Символ    :  '{Symbol}'");
            Console.WriteLine($"Площа     :  {Area}");
            Console.WriteLine($"Периметр  : {Perimeter}");
            Console.ResetColor();

        }
        public void Move(int dx, int dy) // зміна координат
        {
            X += dx;
            Y += dy;
        }

        public abstract double Area { get; }
        public abstract double Perimeter { get; }

        public abstract void Draw();





        protected int ReadInt(string message)
        {
            int value;
            Console.Write(message);

            while (!int.TryParse(Console.ReadLine(), out value) || value <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\t!Error! Введіть додатне ціле число: ");
                Console.ResetColor();
            }

            return value;
        }

        protected ConsoleColor ReadColor()
        {
            Console.Write("Введіть колір (Red, Green, Yellow, Blue ... ) : ");

            ConsoleColor color;
            while (!Enum.TryParse(Console.ReadLine(), true, out color))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\t!Error! Введіть правильну назву кольору: ");
                Console.ResetColor();
            }

            return color;
        }
        protected char ReadChar(string message)
        {
            Console.Write(message);
            string? inputSymbol = Console.ReadLine();

            while (string.IsNullOrEmpty(inputSymbol) || inputSymbol.Length != 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\t!Error! Введіть тільки ОДИН символ: ");
                Console.ResetColor();
                inputSymbol = Console.ReadLine();
            }

            return inputSymbol[0];
        }




    }
}
