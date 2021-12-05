//Метод 1 ничего не принимает (никаких аргументов) и ничего не возвращает (void)

// void Method1()
// {
//     Console.WriteLine("Автор текста - ........");
// }
// Method1();

//Метод 2 - ничего не возвращает (void), но может принимать аргументы

// void Method2 (string msg)
// {
//     Console.WriteLine(msg);
// }
// Method2("текст сообщения");

// void Method21 (string msg, int count)
// {
//     int i=0;
//     while(i<count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
// Method21(msg: "Новый текст", count: 4);

//Метод 3 - что то возвращает (return), но никакие аргументы не принимает

// int Method3()
// {
//     return DateTime.Now.Year;
// }
// int year=Method3();
// Console.WriteLine(year);

//Метод 4 - что-то принимает и что-то возвращает (return)

/* string Method4(int count, string text)
{
    // int i=0;
    // string result = String.Empty; //задано значение пустая строка, можно также ="";
    // while (i<count)
    // {
    //     result=result+text;
    //     i++;
    // }
    // return result;
    //}
    //string res=Method4(10, "asdf");//10 раз напечатает текст
    //Console.WriteLine(res);
    string result=String.Empty;//тоже что выше, только с использованием циклв for
    for (int i=0; i<count;i++)
    {
        result=result+text;
    }
    return result;
}

string res=Method4(10, "z");//10 раз напечатает текст
Console.WriteLine(res); */

//5. Вывод таблицы умножения на экран
/* 
for (int i=2; i<=10; i++)
{
    for (int j=2; j<=10; j++)
    {
        Console.WriteLine($"{i}*{j}={i*j}");
    }
    Console.WriteLine(); //выводит пустую строку для разрывов страницы
} */




/* //Задача 1. Дан текст. В тексте нужно все пробелы заменить черточками, 
//маленькие буквы "к" заменить большими "К", а большие "С" заменить маленькими"с".
string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            +"ежели бы вас послали вместо нашего милого Винценгероде,"
            +"вы бы взяли приступом согласие прусского короля."
            +"Вы так красноречивы. Вы дадите мне чаю?";

string Replace (string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int lenght = text.Length;
    for(int i=0; i<lenght;i++)
    {
        if(text[i]==oldValue) result = result + $"{newValue}";
        else result=result+$"{text[i]}";
    }
    return result;
}             

string newText=Replace (text, ' ','|');
Console.WriteLine(newText);

Console.WriteLine();

newText=Replace(newText,'к', 'К');
Console.WriteLine(newText);

Console.WriteLine();

newText=Replace(newText,'с','С');
Console.WriteLine(newText); */


//РАБОТА С МАССИВАМИ
//Задача 2 Упорядочить массив (сортировка методом выбора, методом минимакса)

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };
void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}

PrintArray(arr);

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)                    //эта строка и 3 след находит позицию 
        {                                                      // минимального элемента в массиве
            if (array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];             // эта строка и две след меняют местами
        array[i] = array[minPosition];          // рассматриваемую i позицию с позицией, где расположен 
        array[minPosition] = temporary;         // минимальный элемент массива
    }
}

SelectionSort(arr);
PrintArray(arr);


