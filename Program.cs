namespace ForRectangel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ristkülik");

            //teha for loopida ristkülik
            Console.WriteLine("Sisesta ristküliku külje mõõdud");

            Console.WriteLine("Pikkus");
            double length = double.Parse(Console.ReadLine());

            Console.WriteLine("Laius");
            double witdh = double.Parse(Console.ReadLine());

            //kasutada for loopi
            //peab tuleb ristküliku kujund
            for (int row = 1; row <= length; row++)
            {
                for (int col = 1; col <= witdh; col++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            //teha kalkulatsioon, kus arvutatakse pindala ja ümbermõõt
            Console.WriteLine("Ruudu pindala: " + (length + witdh) * 2);
            Console.WriteLine("Ruudu ümbermõõt: " + length * witdh);

        }
    }
}
