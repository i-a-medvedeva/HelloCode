//Двумерные массивы

//Пример 1 двумерный массив с типом данных - строка

string[,] table = new string [2,5];
table [1,2] = "слово";
for (int rows=0;rows<2;rows++)
{
    for (int columns=0; columns<5;columns++) // будет перебирать индексы от 0 до 4 включительно
    {
        Console.WriteLine($"-{table[rows, columns]}-");
    }
}
