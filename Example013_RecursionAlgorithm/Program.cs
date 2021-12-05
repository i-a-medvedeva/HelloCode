//Двумерные массивы

//Пример 1 двумерный массив с типом данных - строка

/* string[,] table = new string [2,5];
// String.Empty - по умолчанию в строке будут пустые значения.
// table [0,0] table [0,1] table [0,2]  table [0,3] table [0,4]
// table [1,0] table [1,1] table [1,2]  table [1,3] table [1,4]
table [1,2] = "слово";
for (int rows=0;rows<2;rows++)
{
    for (int columns=0; columns<5;columns++) // будет перебирать индексы от 0 до 4 включительно
    {
        Console.WriteLine($"-{table[rows, columns]}-");
    }
}
 */

// ПРимер 2 двумерный массив с числами

int[,] matrix = new int[3, 4];
for (int rows = 0; rows < matrix.GetLength(0); rows++)
{
    for (int columns = 0; columns < matrix.GetLength(1); columns++)
    {
        Console.Write($"{matrix[rows, columns]} ");
    }
    Console.WriteLine(); // принудительный переход на новую строку для красоты вывода
}
