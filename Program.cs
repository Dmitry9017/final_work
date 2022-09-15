/*Написать программу, которая из имеющегося массива строк формирует массив из строк,
длина которых меньше или равна 3 символам.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.*/

Console.Write("Введите количество значений в массиве: ");
int number = int.Parse(Console.ReadLine());

string[] array = GetArray(number);
PrintArray(array);

//Метод создания массива
string[] GetArray(int length)
{
    string[] array = new string[length];

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i + 1} значение массива: ");
        string userUnswer = Console.ReadLine();
        array[i] = userUnswer;
    }
    return array;
}
//Метод вывода массива на печать
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }
}