namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите сторону a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите сторону b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите сторону c: ");
            int c = Convert.ToInt32(Console.ReadLine());
            Triangle triangle = new Triangle(a, b, c);
            triangle.checkTriangle();
            triangle.ReadLine();
        }
    }
    class Triangle
    {
        private int a,c,b;

        public Triangle(int SideА, int SideB, int SideC) { a = SideА;b=SideB;c = SideC;}

        public void checkTriangle()
        {
            if (a < 0||b< 0||c<0) Console.WriteLine("треугольник не существует! Отрицательные длины!");
            else if (a + b <= c || a + c <= b || b + c <= a)
                Console.WriteLine("Это не треугольник!");
            else if (a == b && b == c)
                Console.WriteLine("Это равносторонний треугольник!");
            else if (a == b || a == c || b == c)
                Console.WriteLine("Это равнобедренный треугольник!");
            else
                Console.WriteLine("Это треугольник.");
            Console.ReadKey();
        }

        public void ReadLine()
        {
            Console.WriteLine($"\nТреугольник со сторонами: \na-{a}, \nb-{b}, \nc-{c}");
        }
    }
}
