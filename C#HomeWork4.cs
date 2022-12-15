/*// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int Exponentiation(int numA, int numB)
{
    int result = numA;
    for (int count = 2; count <= numB; count++)
    {
        result = result * numA;
    }
    return result;
}

Console.WriteLine("Input a number A ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a number B ");
int numberB = Convert.ToInt32(Console.ReadLine());
int result = Exponentiation(numberA, numberB);
Console.WriteLine($"Number {numberA} to the power of {numberB} is {result}");
*/

/*// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int NumberSize(int startNumber)
{
    int count = 0;
    while(startNumber > 0)
    {
        startNumber = startNumber / 10;
        count++;
    }
    return count;
}

int[] ArrayFilling(int[] array, int startNumber, int size)
{
    int i = 0;
    while(i < size)
    {
        array[i] = startNumber % 10;
        startNumber /= 10;
        i++;
    }
    return array;
}

void SumOfArrayIndices(int[] array, int size)
{
    int i = 0;
    int sum = 0;
    while(i < size)
    {
        sum += array[i];
        i++;
    }
    Console.WriteLine($"sum is {sum}");
}

Console.WriteLine("Input a number ");
int number = Convert.ToInt32(Console.ReadLine());
int size = NumberSize(number);
int[] array = new int[size];
int[] filledArray = ArrayFilling(array, number, size);
SumOfArrayIndices(filledArray, size);
*/

/*// Напишите программу, которая задаёт массив из N элементов и выводит их на экран.

int[] CreatingArray(int size)
{
   int[] array = new int[size];

   for(int i = 0; i < size; i++)
   {
        array[i] = new Random().Next(-1000, 1001);
   }
   return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}.");
}

Console.WriteLine("Input a number ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = CreatingArray(size);
ShowArray(array);
*/