// Задача 39: Напишите программу, которая перевернёт одномерный 	
// массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)	
// [1 2 3 4 5] -> [5 4 3 2 1]	
// [6 7 3 6] -> [6 3 7 6]	

const int SIZE = 5;	                                 // размер (массива) = 5
const int LEFT_RANGE = -10;	                         // (от) -10 (до) 10 (диапозон массива) 
const int RIGHT_RANGE = 10;

int[] arr = RandomArray(SIZE, LEFT_RANGE, RIGHT_RANGE);	  //// вызов массива с аргументами (констант см.выше)
Console.WriteLine($"Исходный массив {string.Join(", ", arr)}");
ReverseArray(arr);	                                    // вызов метода для реверсива массива
Console.WriteLine($"Развернутый массив {string.Join(", ", arr)}");

int[] RandomArray(int size, int leftRange, int rightRange)
{                                     // RandomArray - массив для заполнения случайными числами (функция)
                                      // аргументы левая граница, правая граница
    int[] array = new int[size];
    Random rand = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(leftRange, rightRange + 1);   // +1 что б вошел диапозон случайных чисел и справо	
    }

    return array;
}

void ReverseArray(int[] array)	                     // переворот массива - в аргументе массив для переворота
{
    for (int i = 0; i < array.Length / 2; i++)       // 50:02 переворот массива array.Length / 2 - число перестановок от длины массива

    {
        int temp = array[i];                         // меняем местами симитричные пары массива (слева и справа)

        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }
}
