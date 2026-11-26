using System;
using LibraryLib;

// Создаём объект библиотеки.
LibraryFunctions library = new LibraryFunctions();

// Выводим название библиотеки.
Console.WriteLine("Название: " + library.GetLibraryName());

// Выводим главного библиотекаря.
Console.WriteLine("Главный библиотекарь: " +
    library.GetChiefLibrarian());

// Изменяем главного библиотекаря.
Console.WriteLine("\nИзменение главного библиотекаря:");
bool changed = library.SetChiefLibrarian("Петров П.С.");
Console.WriteLine("Изменение выполнено: " + changed);

// Генерируем код книги.
Console.WriteLine("\nКод книги:");
string bookCode = library.GenerateBookCode("FIC", 123);
Console.WriteLine(bookCode);

// Выводим список сотрудников.
Console.WriteLine("\nСписок сотрудников:");
foreach (string employee in library.GetStaff())
{
    Console.WriteLine(employee);
}

// Добавляем нового сотрудника.
Console.WriteLine("\nДобавление сотрудника:");
library.AddStaff("Смирнов А.А.");

// Проверяем обновлённый список.
Console.WriteLine("\nОбновлённый список сотрудников:");
foreach (string employee in library.GetStaff())
{
    Console.WriteLine(employee);
}

Console.ReadKey();