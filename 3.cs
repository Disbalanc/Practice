class Triangle
    {
        double x1, y1=0; // первоя точка стоит на 0 отметке
        double x2, y2, x3, y3; // поля для остальных точек

        double a,b,c; // стороны a, b и c

        double cornerA, cornerB, cornerC; // углы a, b и c
        /// <summary>
        /// Присвоение закрытым полям сторон данными от пользователя
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            Console.WriteLine($"\nВаши стороны: \n a={a}\n b={b}\n c={c}");
        }
        /// <summary>
        /// Присвоение точек координт данными от пользователя
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="d"></param>
        public Triangle (double a, double b, double c, double d)
        {
            this.x2 = a;
            this.y2 = b;
            this.x3 = c;
            this.y3 = d;
        }
        /// <summary>
        /// расчёт сторон изходя из расположения точек на оси координат
        /// </summary>
        public void MakeStorona()
        {
            double two = 2; // избавление от магического числа
            a = Math.Sqrt(Math.Pow(x2 - x1, two) + Math.Pow(y2 - y1, two)); // сторона a
            b = Math.Sqrt(Math.Pow(x3 - x2, two) + Math.Pow(y3 - y2, two)); // сторона b
            c = Math.Sqrt(Math.Pow(x3 - x1, two) + Math.Pow(y3 - y1, two)); // сторона с

            Console.WriteLine($"\nВаши стороны: \n a={a}\n b={b}\n c={c}");
        }
        /// <summary>
        /// Проверка возможности существования треугольника
        /// </summary>
        public void ProverkaTriangle()
        {
            if (a < 0||b< 0||c<0) Console.WriteLine("\nтреугольник не существует! Отрицательные длины!"); // проверка на отрицательные длины сторон
            else if (a + b <= c || a + c <= b || b + c <= a) // проверка на существование треугольника
                Console.WriteLine("\nЭто не треугольник!");
            else if (a == b && b == c) // проверка равны ли все стороны
                Console.WriteLine("\nЭто равносторонний треугольник!");
            else if (a == b || a == c || b == c) // проверка на равны ли 2 стороны
                Console.WriteLine("\nЭто равнобедренный треугольник!");
            else
                Console.WriteLine("\nЭто произвольный треугольник.");
        }
        /// <summary>
        /// для нахожждения углов в треугольнике
        /// </summary>
        public void findingСorners()
        {
            double A = Math.Acos((Math.Pow(a, 2) + Math.Pow(c, 2) - Math.Pow(b, 2)) / (2 * a * c)) * 180 / Math.PI; // нахождение углов
            double B = Math.Acos((Math.Pow(a, 2) + Math.Pow(b, 2) - Math.Pow(c, 2)) / (2 * a * b)) * 180 / Math.PI;
            double C = Math.Acos((Math.Pow(b, 2) + Math.Pow(c, 2) - Math.Pow(a, 2)) / (2 * c * b)) * 180 / Math.PI;
            A = Math.Round(A, 5); // округление углов
            B = Math.Round(B, 5);
            C = Math.Round(C, 5);

            cornerA = A; // присвоение полям значениев углов и вывод
            Console.WriteLine($"\nУгол А: {A}");
            cornerB = B;
            Console.WriteLine($"Угол B: {B}");
            cornerC = C;
            Console.WriteLine($"Угол C: {C}");
        }
        /// <summary>
        /// Для нахождения всего в треугольнике
        /// </summary>
        public void AnglesTriangle()
        {
            double summCorner = 180; // избавление от магических чисел
            double one = 1;
            double two = 2;
            double three = 3;

            double radianA = cornerA * Math.PI / summCorner;
            Console.WriteLine($"\nCos угла А: {Math.Cos(radianA)}");
            Console.WriteLine($"Sin угла A: {Math.Sin(radianA)}");
            Console.WriteLine($"Tan угла A: {Math.Tan(radianA)}");
            Console.WriteLine($"cTan угла A: {one / Math.Tan(radianA)}");

            double radianB = cornerB * Math.PI / summCorner;
            Console.WriteLine($"Cos угла B: {Math.Cos(radianB)}");
            Console.WriteLine($"Sin угла B: {Math.Sin(radianB)}");
            Console.WriteLine($"Tan угла B: {Math.Tan(radianB)}");
            Console.WriteLine($"cTan угла B: {one / Math.Tan(radianB)}");

            double radianC = cornerC * Math.PI / summCorner;
            Console.WriteLine($"Cos угла C: {Math.Cos(radianC)}");
            Console.WriteLine($"Sin угла C: {Math.Sin(radianC)}");
            Console.WriteLine($"Tan угла C: {Math.Tan(radianC)}");
            Console.WriteLine($"cTan угла C: {one / Math.Tan(radianC)}");

            Console.WriteLine($"ACos: {Math.Acos(one) * summCorner / Math.PI}");
            Console.WriteLine($"ATan: {Math.Atan(Math.Sqrt(three)) * summCorner / Math.PI}");
            Console.WriteLine($"ACTan: {one / (Math.Atan(three) * summCorner / Math.PI)}");
            double p = (a + b + c) / two; //полу периметр
            Console.WriteLine($"высота a {(2 * Math.Sqrt(p * (p - a) * (p - b) * (p - c))) / a}");
            Console.WriteLine($"высота b {(2 * Math.Sqrt(p * (p - a) * (p - b) * (p - c))) / b}");
            Console.WriteLine($"высота c {(2 * Math.Sqrt(p * (p - a) * (p - b) * (p - c))) / c}");
            Console.WriteLine($"Площадь треугольника: {Math.Sqrt(p * (p - a) * (p - b) * (p - c))}");
            Console.WriteLine($"Периметр треугольника: {a+b+c}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Выбирите:\n 1 - по координатам точек;\n 2 - по сторонам;");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        {
                            Console.WriteLine("Введите координаты сторон треугольника: ");
                            Console.Write("Введите координату x2");
                            if (!double.TryParse(Console.ReadLine(), out double X2))
                            {
                                Console.WriteLine("Неверный радиус!");
                            }
                            Console.Write("Введите координату y2");
                            if (!double.TryParse(Console.ReadLine(), out double Y2))
                            {
                                Console.WriteLine("Неверный радиус!");
                            }
                            Console.Write("Введите координату x3");
                            if (!double.TryParse(Console.ReadLine(), out double X3))
                            {
                                Console.WriteLine("Неверный радиус!");
                            }
                            Console.Write("Введите координату y3");
                            if (!double.TryParse(Console.ReadLine(), out double Y3))
                            {
                                Console.WriteLine("Неверный радиус!");
                            }

                            Triangle trig = new Triangle(Math.Round(X2, 2), Math.Round(Y2, 2), Math.Round(X3, 2), Math.Round(Y3, 2));
                            trig.MakeStorona();
                            trig.findingСorners();
                            trig.ProverkaTriangle();
                            trig.AnglesTriangle();
                            break;
                        }
                    case "2":
                        {
                            Console.WriteLine("Введите стороны треугольника: ");
                            Console.WriteLine("Введите сторону a");
                            if (!double.TryParse(Console.ReadLine(), out double a))
                            {
                                Console.WriteLine("Неверный радиус!");
                            }
                            Console.WriteLine("Введите сторону b");
                            if (!double.TryParse(Console.ReadLine(), out double b))
                            {
                                Console.WriteLine("Неверный радиус!");
                            }
                            Console.WriteLine("Введите сторону c");
                            if (!double.TryParse(Console.ReadLine(), out double c))
                            {
                                Console.WriteLine("Неверный радиус!");
                            }
                            Triangle trig = new Triangle(a,b,c);
                            trig.findingСorners();
                            trig.ProverkaTriangle();
                            trig.AnglesTriangle();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("такой операции нет!");
                            break;
                        }
                }
                Console.WriteLine("\nЗапуск - ENTER;\nВыход из программы - ESC");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
