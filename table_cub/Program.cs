// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void Cube_table(int number){
    for(int i = 1; i <= number; i++){
        Console.Write((i * i) * i + " ");
     
    }
}
Console.WriteLine("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());
Cube_table(num);