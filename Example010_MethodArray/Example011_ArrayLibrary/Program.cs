void FillArray (int[] collection)
{
    int length=collection.Length;
    int index =0;
    while(index<length)
    {
        collection[index]=new Random().Next(1,10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while(position<count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf (int[] collection, int find)
{
    int count = collection.Length;
    int index =0;
    int position = -1;// чтобы при отсутсвии элемента в массиве выдавало -1, а не 0 (что соответ 1ому элем массива)
    while(index<count)
    {
        if(collection[index]==find)
        {
            position=index;
            break;//чтобы закончить после первого найденного элемента
        }
        index++;
    }
    return position;
}

int[] array = new int [10];

FillArray(array);
//array[1]=4;//принудительно на 2ую позицию - индекс=1, поставили значение 4, уже после рандомного заполнения массива
PrintArray(array);

Console.WriteLine();//чтобы выводил пустую строкуб отделяющую массив от позиции

int pos = IndexOf(array, 4);
Console.WriteLine(pos);
