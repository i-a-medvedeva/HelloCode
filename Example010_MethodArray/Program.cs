int[] array = { 1, 12, 31, 4,18, 15, 16, 17, 18 };

int n = array.Length; //определяет длину массива
int find =18;

int index = 0;
while (index<n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;// чтобы находил первое такое число в массиве и заканчивал работу, если надо все элементы найти, 
        //то просто без данного оператора все будет работать!
    }
    
    index++;//index=index+1;
}