// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.WriteLine("Ведите число ");
int number = Convert.ToInt32(Console.ReadLine());
string firstgNumber = Convert.ToString(number);
int sum = 0;

for(int i = 0; i < firstgNumber.Length; i++)
{
    string temp = Convert.ToString(firstgNumber[i]);
    sum += Convert.ToInt32(temp);
}
Console.WriteLine(sum);