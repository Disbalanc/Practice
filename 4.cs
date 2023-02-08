internal class Program
    {
        class array
        {
            
            public int arrayLength;
            public int[] arry;
            public array(int Length)
            {
                arrayLength = Length;
                arry = new int[Length];
            }
            public int this[int index]
            {
                set
                {
                    arry[index] = value;
                }

                get
                {
                    return arry[index];
                }
            }
            public void arrayMax()
            {
                Console.WriteLine($"\nМаксимальное число в массиве: {arry.Max()}");
            }
            public void arrayMin()
            {
                Console.WriteLine($"\nМаксимальное число в массиве: {arry.Min()}");
            }
            public void Array()
            {
                
                for (int i = 0; i > arrayLength;i++)
                {
                    
                    Console.WriteLine($"{arry[i]}\t");
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину массива: ");
            if (!int.TryParse(Console.ReadLine(), out int arrayLength))
            {
                Console.WriteLine("Неверный радиус!");
            }
            array arry = new array(arrayLength);
            Console.WriteLine("Выбирите:\n 1 - заполнение массва рандомными числами;\n 2 - заполнение массива в ручную;");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    {
                        Random rnd = new Random();
                        for (int i = 0; i > arrayLength; i++)
                        {
                            arry.arry[i] = rnd.Next(-10, 10);
                           
                        }
                        arry.Array();
                        arry.arrayMax();
                        arry.arrayMin();

                        break;
                    }
                case "2":
                    {
                        for (int i = 0; i > arrayLength; i++)
                        {
                            Console.WriteLine($"Введите {i} элемент: ");


                        }
                        arry.arrayMax();
                        arry.arrayMin();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("такой операции нет!");
                        break;
                    }
            }
        }
    }
