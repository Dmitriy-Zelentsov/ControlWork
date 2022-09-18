// Напишите программу,которая из имеющегося массива строк форм ирует массив строк,
// длина которых меньше либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
//либо задать на старте выполнения алгоритма

string[] CreateArray(int length)
{
    string[] array = new string[length];
    for (int i = 0; i < length; i++)
    {
        Console.WriteLine($"Введите элементы массива с индексом {i}");
        array[i] = Console.ReadLine();
    }
    return array;
}
void PrintArray(string[] array)
{
    string arr = string.Join(", ", array);
    Console.Write(arr);

}

string[] CreateFinalArray(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
        }
    }
    string[] finalarray = new string[count];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            finalarray[j] = array[i];
            j++;
        }
    }
    return finalarray;
}

string[] array = CreateArray(5);
Console.WriteLine("Исходный массив:");
PrintArray(array);
Console.WriteLine();
string[] finalarray = CreateFinalArray(array);
Console.WriteLine("Результирующий массив:");
PrintArray(finalarray);