// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

const int SIZE = 8;
const int LEFT_RANGE = 100;
const int RIGHT_RANGE = 999;

int[] array = new int[SIZE];


int[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRange)
{
    Random rand = new Random();
    int[] arr = new int[size];
    for( int i = 0 ; i<size; i++)
    { 
        arr[i] = rand.Next(leftRange, rightRange + 1); // [100; 1000)
    }
    return arr;
}

int number = Convert.ToInt32(Console.ReadLine());
int count = 2;

while (count <= number)
{
    Console.Write(count + " ");
    count = count + 2;
}

array = FillArrayWithRandomNumbers(8, 100, 999);
Console.WriteLine('[' + string.Join(", ", array) + ']');

Console.WriteLine($"Количество чётных чисел в массиве: ");