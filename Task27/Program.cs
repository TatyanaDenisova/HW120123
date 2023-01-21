// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12


int getUserData(string message)
{
    Console.WriteLine(message);
    int userDate = int.Parse(Console.ReadLine()!);
    return userDate;
}

int getSumOfDigit(int number)
{
    int sum = 0;
    while (number != 0)
    {
        sum = sum + number % 10;
        number = number / 10;
    }
    return sum;
}

int number = getUserData("Введите число");
int sum = getSumOfDigit(number);
Console.WriteLine(sum);