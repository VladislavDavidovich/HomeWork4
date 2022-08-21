// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.Write("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int degree(int numberA, int numberB)
{
int result = 1;
for(int i=1; i <= numberB; i++)
{
    result = result * numberA;
}
    return result;
}

  int Degree = degree(numberA, numberB);
  Console.WriteLine(Degree);
