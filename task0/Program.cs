/*Задача 41: Пользователь вводит с клавиатуры M чисел.
 Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

int[] UserArray(int length, int start, int end)
{
    Console.WriteLine(" Введите количество чисел");
    length = int.Parse(Console.ReadLine());
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($" Введите число под индесом {i}");
        array[i] = int.Parse(Console.ReadLine());
    }
    return array;

}
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(",");
        }
    }
    Console.Write("]");
}

int PositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }

    }
    return count;
}
int[] lastarray = UserArray(5, -10, 10);
PrintArray(lastarray);
int result = PositiveNumbers(lastarray);
Console.WriteLine($" Положительных моментов {result} штук ");