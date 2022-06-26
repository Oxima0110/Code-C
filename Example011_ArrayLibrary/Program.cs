// метод заполнение массива
void FillArray (int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}
// метод печать массива
void PrintArray (int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}
// метод нахождения заданного числа
int InexOf (int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}
// задаем длину массива в 10
int[] array = new int[10];
FillArray(array);
PrintArray(array);
Console.WriteLine();
int pos = InexOf(array, 4);
Console.WriteLine(pos);