//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

int getUserData(string message)
{
    Console.WriteLine(message);
    int userDate = int.Parse(Console.ReadLine()!);
    return userDate;
}
double VozvedenieVStepen(int firstNumber, int secondNumber)
{
double result = 0;
if(firstNumber == 0)
{
    result = 0;
}
if(secondNumber == 0)
{
 result = 1;
}
else
{
  result =(Math.Pow(firstNumber, secondNumber));
}
  return result;
}
int firstNumber = getUserData("Введите число А");
int secondNumber = getUserData("Введите число B");
double result = VozvedenieVStepen(firstNumber,secondNumber);
Console.WriteLine($"Число А в степени В равно {result}");
