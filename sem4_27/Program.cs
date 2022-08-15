/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */
int sum_cifr(int N)
{
  int a;
  int sum = 0;
  do
  {
    a = N % 10;
    sum = sum + a;
    N = N / 10;
  } while (N > 0);
    
    return sum;
}

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int rez = sum_cifr(N);
Console.WriteLine("Сумма цмфр числа " + N + " равна " + rez);
