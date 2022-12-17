// Майборода А.А. Вар 3 - Высокий уровень
var columnsNumber = int.Parse(Console.ReadLine());
var rowsNumber = int.Parse(Console.ReadLine());

var array = new int[columnsNumber, rowsNumber];
var random = new Random();
Console.WriteLine('\n');

// Заполняем числами и выводим
for (var columnIndex = 0; columnIndex < columnsNumber; columnIndex++)
{
    for (var rowIndex = 0; rowIndex < rowsNumber; rowIndex++)
    {
        array[columnIndex, rowIndex] = random.Next(0, 101);
        Console.Write($"{array[columnIndex, rowIndex]} ");
    }

    Console.WriteLine();
}

Console.WriteLine();

// Умножаем на 3 и выводим
for (var columnIndex = 0; columnIndex < columnsNumber; columnIndex++)
{
    for (var rowIndex = 0; rowIndex < rowsNumber; rowIndex++)
    {
        array[columnIndex, rowIndex] *= 3;
        Console.Write($"{array[columnIndex, rowIndex]} ");
    }

    Console.WriteLine();
}

Console.WriteLine();

// Меняем знак и выводим
for (var columnIndex = 0; columnIndex < columnsNumber; columnIndex++)
{
    for (var rowIndex = 0; rowIndex < rowsNumber; rowIndex++)
    {
        array[columnIndex, rowIndex] *= -1;
        Console.Write($"{array[columnIndex, rowIndex]} ");
    }

    Console.WriteLine();
}