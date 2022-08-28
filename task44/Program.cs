// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

int[] fibonnachi = new int[number];       // массив задаем
fibonnachi[0] = 0;
fibonnachi[1] = 1;
for(int i=2; i < fibonnachi.Length; i++)
{
      fibonnachi[i] = fibonnachi[i-1] + fibonnachi[i-2];  // F2 = F1 + F0  // F3= F2+ F1 // F4 = F3+ F2
}

Console.WriteLine(string.Join(" ", fibonnachi));
