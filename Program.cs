namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            int i, t, p, n, c1, c2, c3, c4, c5, ca;
            Console.WriteLine("Ingrese N cantidad de productos");
            n = Convert.ToInt32(Console.ReadLine());
            (c1,c2,c3,c4,c5,ca) = (0,0,0,0,0,0);
            for (i=1; i<=n; i++)
            {
                t = R(0, 1);
                p = R(100, 1000);
                if (t == 0)
                {
                    c1++;
                }
                if (t == 0 && p>500)
                {
                    c2++;
                }
                if (t == 1 && 900>p && p>600)
                {
                    c3++;
                }
                    c4+=p;
                if (450 > p && p > 250)
                {
                    c5+=p;
                    ca++;
                }
            }
            Console.WriteLine("1)");
            Console.WriteLine("Nacionales:" + c1);
            Console.WriteLine("Importados:" + (n-c1));
            Console.WriteLine("2)");
            Console.WriteLine("La cantidad de productos nacionales cuyo precio es mayor a 500:" + c2);
            Console.WriteLine("3)");
            Console.WriteLine("El porcentaje de productos importados cuyo precio está entre 600 y 900:" + (100*c3/n) + "%");
            Console.WriteLine("4)");
            Console.WriteLine("El promedio de precios de los N productos:" + c4/n);
            Console.WriteLine("5)");
            Console.WriteLine("El promedio de precios de productos importados y nacionales cuto precio está entre 250 y 450:" + c5/ca);
        }
        static int R(int n1, int n2)
        {
            Random random = new Random();
            return random.Next(n1, n2+1);
        }
    }
}