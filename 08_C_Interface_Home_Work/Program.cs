using _08_C_Interface_Home_Work;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.Unicode;
        Console.InputEncoding = Encoding.Unicode;
        Console.WriteLine("Привіт світ!");

        Console.WriteLine("\n\t -- ЛІНІЯ --");
        Line line = new Line();


        line.Print();

        Console.WriteLine("\n--- Малюємо ---");
        line.Draw();

        Console.WriteLine("\n--- Зміщуємо лінію на (5, 2) ---");
        line.Move(5, 2);

        Console.WriteLine("\n--- Після зміщення  ---");
        line.Print();

        Console.WriteLine("\n--- Малювання після зміщення  ---");
        line.Draw();

        Console.WriteLine("\nНатисніть будь-яку клавішу щоб продовжити . . . ");
        Console.ReadKey();

        Console.WriteLine("\n\t -- КВАДРАТ --");
        Square square = new Square();

        square.Print();

        Console.WriteLine("\n--- Малюємо ---");
        square.Draw();

        Console.WriteLine("\n--- Зміщуємо квадрат на (4, 1) ---");
        square.Move(4, 1);

        Console.WriteLine("\n--- Після зміщення ---");
        square.Print();

        Console.WriteLine("\n--- Малювання після зміщення ---");
        square.Draw();

        Console.WriteLine("\nНатисніть будь-яку клавішу щоб продовжити . . . ");
        Console.ReadKey();

        Console.WriteLine("\n\t -- ПРЯМОКУТНИК --");
        Rectangle rectangle = new Rectangle();

        rectangle.Print();

        Console.WriteLine("\n--- Малюємо ---");
        rectangle.Draw();

        Console.WriteLine("\n--- Зміщуємо прямокутник на (2, 1) ---");
        rectangle.Move(2, 1);

        Console.WriteLine("\n--- Після зміщення ---");
        rectangle.Print();

        Console.WriteLine("\n--- Малювання після зміщення ---");
        rectangle.Draw();


    }

}
