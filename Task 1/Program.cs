// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
string number = Console.ReadLine();

int length = number.Length;
int index = 0;

if (length == 5)
{
    if (number[index] == number[length - 1 - index])
        {
            Console.WriteLine("Число является полиндромом");
            index++;
        }
        else
        {
            Console.WriteLine("Число не является полиндромом");
        }
    }
else
{
    Console.WriteLine("Введите корректное пятизначное число");
}
