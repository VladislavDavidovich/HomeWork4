
// Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] array = new int [number];

for(int i = 0; i < array.Length; i++)
{
    array[i] =  new Random().Next(-100,100);
    Console.Write(array[i] + " ");
}
















//int [] = new Random();

//for(int i = 0; i<arr.Length; i++)

//arr[i] = rand.Next(-10,10);