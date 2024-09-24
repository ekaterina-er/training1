// See https://aka.ms/new-console-template for more information
//Задание 1
//Вывод и ввод данных в консоль
Console.WriteLine("Требуется выполнить ввод следующих данных:");
Console.WriteLine("1.Имя");
string? name = Console.ReadLine();
Console.WriteLine("2.Фамилия");
string? surname = Console.ReadLine();
Console.WriteLine("3.Отчество");
string? patronymic = Console.ReadLine();
//вывод полученного значения на экран
string str = $"Имя:{name} Фамилия:{surname} Отчество:{patronymic}";
Console.WriteLine(str);
Console.ReadKey();
