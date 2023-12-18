using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork07
{
    internal class Repository
    {
        public Worker[] GetAllWorkers(string FileName)
        {
            // здесь происходит чтение из файла
            // и возврат массива считанных экземпляров

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
            {
                Console.WriteLine("База данных пока пуста, но вы можете добавить запись!");
                Console.ReadKey();
            }

        public Worker GetWorkerById(int id)
        {
            // происходит чтение из файла, возвращается Worker
            // с запрашиваемым ID
        }

        public void DeleteWorker(int id)
        {
            // считывается файл, находится нужный Worker
            // происходит запись в файл всех Worker,
            // кроме удаляемого
        }

        public void AddWorker(Worker worker)
        {
                // присваиваем worker уникальный ID,
                // дописываем нового worker в файл

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

                line = Convert.ToString(Id) + '#' + Convert.ToString(DateTime.Now) + '#' + FIO + "#" + Age + '#' + Height + '#' + BirthDay + '#' + BirthPlace;

                linesOfText[0] = line;

                using (StreamWriter sw = new(FileName, true, System.Text.Encoding.Unicode))
                {
                    sw.WriteLine(line);

                }

                Console.WriteLine("\nЗапись добавлена\n");
            }

        public Worker[] GetWorkersBetweenTwoDates(DateTime dateFrom, DateTime dateTo)
        {
            // здесь происходит чтение из файла
            // фильтрация нужных записей
            // и возврат массива считанных экземпляров
        }
    }
}
