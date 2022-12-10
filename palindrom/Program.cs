// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

int palindrom (){
    Console.WriteLine("Введите пятизначное число");
    int entered_dgit = Convert.ToInt32(Console.ReadLine());
    int first_digit = entered_dgit / 10000;
    int last_digit = entered_dgit % 10;
   if (first_digit == last_digit){
    Console.Write("Да число палиндром > ");
    return entered_dgit;
   } else
    Console.Write("Нет число не палиндром > ");
    return entered_dgit;
   }
int res = palindrom();
Console.WriteLine(res);
