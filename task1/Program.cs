/*Задача 43: Напишите программу, которая найдёт 
точку пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2;
 значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

int getNumberFromUser(string message)
{
    int result = 0;
    Console.WriteLine(message);
    result = Convert.ToInt32(Console.ReadLine());
    return result;
}

double FindPoint (double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1)/ (k1-k2);
    double y = k1 * x +b1;
    Console.WriteLine($" Точка пересечения - {x} , {y}");
    return x;

}
int b1 = getNumberFromUser(" Введите координаты В1");
int k1 = getNumberFromUser(" Введите координаты K1");
int b2 = getNumberFromUser(" Введите координаты В2");
int k2 = getNumberFromUser(" Введите координаты K2");

double final = FindPoint (b1, k1, b2, k2);
