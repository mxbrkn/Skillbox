using System.IO;


namespace part1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string choice = "1";

            while (choice=="1"||choice=="2")
            {
                choice = ShowChoice();

                ProcessChoice(choice);
                if (choice == "0")
                {
                    break;
                }
            }

        }


        static string ShowChoice()
        {
            Console.WriteLine("Выберите действие\n1 - Добавить запись, 2 - Показать записи");
            return Console.ReadLine();
        }

         static string GetFileName()
            {
            string FileName = @"file.txt";
            return FileName;
            }

        static void ProcessChoice(string choise)
        {

            if (choise == "1")
            {
                AddRecords(GetFileName());

            }
            else if (choise == "2")
            {
                ShowRecords(GetFileName());
            }
            else
            {
                Console.WriteLine("Вы выбрали что-то не то");
            }



        }

        static void AddRecords(string FileName) {

            string FIO, Age, Height, BirthDay, BirthPlace, line;

            int Id = 1;

            if (File.Exists(FileName))
            {
                Id = File.ReadAllLines(FileName).Length + 1;
            }

            string[] linesOfText = new string[1];// { Console.ReadLine() };
            
            Console.WriteLine("Введите ФИО:");
            FIO = Console.ReadLine();
            
            Console.WriteLine("Введите возраст:");
            Age = Console.ReadLine();
            
            Console.WriteLine("Введите рост:");
            Height = Console.ReadLine();
            
            Console.WriteLine("Введите дату рождения:");
            BirthDay = Console.ReadLine();
            
            Console.WriteLine("Введите место рождения:");
            BirthPlace = Console.ReadLine();

            line = Convert.ToString(Id) + '#' + Convert.ToString(DateTime.Now) + '#' +FIO  + "#" + Age + '#' + Height + '#' + BirthDay + '#' + BirthPlace;

            linesOfText[0] = line;

            using (StreamWriter sw = new (FileName, true, System.Text.Encoding.Unicode))
            {
                sw.WriteLine(line);
              
            }
            
            Console.WriteLine("\nЗапись добавлена\n");

        }
        static void ShowRecords(string FileName)
        {
            if (File.Exists(FileName))
            {


                using (StreamReader sr = new(FileName))
                {
                    string line;
                    Console.WriteLine($"{"Номер",6}{"Время добавления",20}{"ФИО",30}{"Возраст",30}{"Рост",10}{"Дата рождения",20}{"Место рождения",20}");

                    while ((line = sr.ReadLine()) != null)
                    {

                        string[] data = line.Split("#");
                        Console.WriteLine($"{data[0],3}{data[1],25}{data[2],37}{data[3],18}{data[4],13}{data[5],20}{data[6],20}");

                    }

                }
            }
            else
            { Console.WriteLine("База данных не существует");
            Console.ReadKey();
            
            }
            
        }
}
    }
