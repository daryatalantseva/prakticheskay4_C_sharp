/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */
// Заполнение массива и вывод 
void FillArray(int[] collection)
{
    int Length = collection.Length;
    int index = 0;
    while (index < Length)
    {
        collection[index] = new Random().Next(1, 100);
        index++;
    }

}
void PrintArray (int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(" "+col[position]);
        position++;
    }
}


int[] array = new int[8];
Console.WriteLine("Массив заполненный случайными числами и выведен на экран");
FillArray(array);
PrintArray(array);


