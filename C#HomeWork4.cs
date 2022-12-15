// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

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