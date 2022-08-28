// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10
// рекурсия

Console.WriteLine("Введите десятичное число:");
int number = Convert.ToInt32(Console.ReadLine());

GetBinaryView(number);

void GetBinaryView(int N)
{
    if (N  <= 0) return;
    GetBinaryView(N / 2);
    Console.Write(N % 2);
}