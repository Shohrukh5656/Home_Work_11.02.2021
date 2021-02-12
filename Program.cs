using System;

namespace ConsoleApplication
{

    class Program
    {
        delegate T Operation<T>(T numberber1, T numberber2);

        public static T Pluslement<T>(T numberber1, T numberber2)
        {
            return (dynamic)numberber1 + (dynamic)numberber2;
        }

        public static T Minuselement<T>(T numberber1, T numberber2)
        {
            return (dynamic)numberber1 - (dynamic)numberber2;
        }
        public static T Umnozhitelemnt<T>(T numberber1, T numberber2)
        {
            return (dynamic)numberber1 * (dynamic)numberber2;
        }
        public static T Delitelement<T>(T numberber1, T numberber2)
        {
            return (dynamic)numberber1 / (dynamic)numberber2;
        }


        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            var Firstelement = decimal.TryParse(Console.ReadLine(), out var firstelement);
            if (!Firstelement)
            {
                System.Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Вы ввели не число в");
                System.Console.ForegroundColor = ConsoleColor.White;
                return;
            }
            Console.Write("Введите второй число: ");
            var Secondelement = decimal.TryParse(Console.ReadLine(), out var secondelement);
            if (!Secondelement)
            {
                System.Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Вы ввели не число в");
                System.Console.ForegroundColor = ConsoleColor.White;
                return;
            }
            Console.WriteLine("Выберите операцию: 1.(+) 2.(-) 3.(*) 4.(/)");
            Console.WriteLine("Пример выбора операции: 1");
            Console.Write("Введите операцию: ");
            var Number = decimal.TryParse(Console.ReadLine(), out var number);
            Operation<decimal> operation = null;
            Console.WriteLine();

            if (!Number)
            {
                System.Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Вы ввели не число в");
                System.Console.ForegroundColor = ConsoleColor.White;
                return;
            }

            if (number == 1)
            {
                operation = Pluslement;
                System.Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Ответ = " + operation.Invoke(firstelement, secondelement));
                return;
            }

            if (number == 2)
            {
                operation = Minuselement;
                System.Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Ответ = " + operation.Invoke(firstelement, secondelement));
                return;
            }
            if (number == 3)
            {
                operation = Umnozhitelemnt;
                System.Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Ответ = " + operation.Invoke(firstelement, secondelement));
                return;
            }
            if (number == 4)
            {
                operation = Delitelement;
                System.Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Ответ = " + operation.Invoke(firstelement, secondelement));
                return;
            }
        }
    }
}
