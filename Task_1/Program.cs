// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

System.Console.WriteLine("Введите пятизначное число: ");
int[] array = new int [5];

for (int i = 0; i < array.Length; i++)
{
    array[i] = Convert.ToInt32(Console.Read());
}

if (array[0] == array[4] && array[1] == array[3])
{
    System.Console.WriteLine("Число является палиндромом");
}
else System.Console.WriteLine("Число не является палиндромом");