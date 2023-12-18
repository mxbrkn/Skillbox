//Задание 1
//
//Объявим переменные и данные
string fullName = "Буркин Максим Александрович", email = "max-burkin@yandex.ru";
int age = 35;
double programmingSkills = 100, mathSkills = 63.99, phisicsSkills = 99;

//Выводим данные
Console.Write(
    $"Ф. И. О.: {fullName} \n" +
    $"Email: {email} \n" +
    $"Возраст: {age} \n" +
    $"Баллы по программированию: {programmingSkills} \n" +
    $"Баллы по математике: {mathSkills} \n" +
    $"Баллы по физике: {phisicsSkills}");
Console.ReadKey();

//Задание 2
//
//Объявим переменные и сразу присвоим им значения
double
    sum = programmingSkills + mathSkills + phisicsSkills,
    gpa = sum / 3;

//Выводим данные задания 2
Console.WriteLine(
    $"\n\nСумма баллов: {sum} \n" +
    $"Средний балл: {gpa: ##.##}");
Console.ReadKey();