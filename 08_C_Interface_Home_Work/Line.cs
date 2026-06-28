using System;
using System.Collections.Generic;
using System.Text;

namespace _08_C_Interface_Home_Work
{
    class Line : Shape
    {
        private int length;
        public int Length
        {
            get => length;

            //set => length = value > 0 ? value : throw new ArgumentOutOfRangeException("Довжина має бути додатним числом!");
            
            //щоб не відловлювати 
            set => length = value > 0 ? value : 1;
        }

        public Line() : base()
        {
            Length = ReadInt("Введіть довжину лінії: ");
        }

        public Line(int x, int y, ConsoleColor color, char symbol, int length)
            : base(x, y, color, symbol)
        {
            Length = length;
        }

        public override double Area => 0;

        public override double Perimeter => Length;

        public override void Draw() // малюємо зі зміщенням відповідно до введених координат
        {
            Console.ForegroundColor = Color;
            // Зміщення по Y
            for (int i = 0; i < Y; i++)
                Console.WriteLine();
            // Зміщення по X
            Console.Write(new string(' ', X));

            for (int i = 0; i < Length; i++)
                Console.Write(Symbol);

            Console.WriteLine();

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
            Console.WriteLine($"Довжина   :  {Length}");

            Console.ResetColor();
        }
    }
}
