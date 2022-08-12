Console.Clear();
void FillArray(int[] collection)
{
    int length = collection.Length; //получаем длину массива
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    } 
}
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index =0;
    int position = -1; //искуственный прием - если элемента нет (вводим индекс больший, чем есть в массиве)

    while(index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
    }
    index++;
    return position;
}

int[] array = new int[10]; //создать новый массив в котором 10 эл-тов

FillArray(array);          //метод который заполнил нам массив
array[4] = 4;              // принудительно заменили значение на 4 позиции массива
array[6] = 4;  
PrintArray(array);         //метод который распечатывает нам массив
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);