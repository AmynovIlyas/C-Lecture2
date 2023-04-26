void FillArray(int[] collection) // void - метод, не возвращающий значения - именно поэтому мы н пишем в конце данного метода команду return
{
    int length = collection.Length;
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
    int index = 0;
    int position = -1; // -1 вводится для того, чтобы в случае отсутствия в массиве элемента со значением find, на выходе не выдавался индекс 0 (соответствующий первому элементу массива)
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

int[] array = new int[10]; // new int [] - команда создания нового массива с опрделённым количеством элементов; по умолчанию данный массив будет заполнен нулями; для того, чтобы заполнить его другими числами, нужно воспользоваться вышеописанным методом 

FillArray(array); // данный метод заполняет массив
PrintArray(array); // данный метод выводит заполненный массив
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);
