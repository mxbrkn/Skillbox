namespace HomeWork03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Part1();
            Part2();
            Part3();
        }

        static void Part1()
        {
            Console.WriteLine("Введите число: ");

            //Искренне надеемся, что пользователь введет именно число
            //Исключения будем обрабатывать когда-то потом
            int number = int.Parse(Console.ReadLine());

            //Будем конструировать слово в зависимости от условий
            string resultWord = "четным";

            if (number % 2 > 0)
            {
                resultWord = "не" + resultWord;
            }

            //Сообщаем результат
            Console.WriteLine($"Число является {resultWord}");
            Console.ReadKey();
        }

        static void Part2()
        {
            Console.WriteLine(
                "Добро пожаловать в Black Jack!!!\n\n" +
                "Введите количество ваших карт:");
            int Number = int.Parse(Console.ReadLine());

            int sum = 0;        // Конечная сумма
            int CardNumber = 0; // Счётчик карт
            int intvalue;       // Числовое значение карты

            while (CardNumber < Number)
            {
                Console.WriteLine("Введите номинал вашей следующей карты");
                string strvalue = Console.ReadLine().ToUpper(); // Преобразуем в заглавную, так как могут ввести в любом регистре

                switch (strvalue)
                {
                    case "1":
                        intvalue = 1;
                        break;
                    case "2":
                        intvalue = 2;
                        break;
                    case "3":
                        intvalue = 3;
                        break;
                    case "4":
                        intvalue = 4;
                        break;
                    case "5":
                        intvalue = 5;
                        break;
                    case "6":
                        intvalue = 6;
                        break;
                    case "7":
                        intvalue = 7;
                        break;
                    case "8":
                        intvalue = 8;
                        break;
                    case "9":
                        intvalue = 9;
                        break;
                    case "10":
                        intvalue = 10;
                        break;
                    case "J":
                        intvalue = 10;
                        break;
                    case "Q":
                        intvalue = 10;
                        break;
                    case "K":
                        intvalue = 10;
                        break;
                    case "T":
                        intvalue = 10;
                        break;

                    default:
                        intvalue = 0;
                        break;
                }

                sum += intvalue;
                CardNumber++;
            }

            Console.WriteLine($"Сумма ваших карт {sum}");
            Console.ReadKey();
        }

        static void Part3()
        {
            Console.WriteLine("Введите число: ");

            //Введём число и сконвертируем его в нужный тип
            int number = Convert.ToInt32(Console.ReadLine());

            //В задании написано с 1, но зачем, если на 1 делится вообще любое число даже не простое, так что начнем с 2
            int i = 2;
            bool simpleNumber = true;

            while (i < number - 1)
            {
                if (number % i == 0)
                {
                    simpleNumber = false;
                    break; //Если делится на любое другое число - то всё, можно прерывать
                }
                i++;
            }

            Console.WriteLine(simpleNumber ? "Число является простым" : "Число не является простым");
            Console.ReadKey();
        }
    }
}