// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();

int ThreeNumber(string str)
{
    System.Console.WriteLine(str);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int[] AddArrayWithRundomNumbers(int size, int leftRange, int rightRange)
{
    int[] arr = new int[size];
    Random rand =  new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange + 1);
    }
    return arr;
}

int SomeNumber(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] % 2 == 0) 
        {
            count++;
        }
    }
    return count;
}


const int leftRange = 100;
const int rightRange = 999;
int lenghtArr = ThreeNumber("Введите размер масива");
int[] arrey = AddArrayWithRundomNumbers(lenghtArr, leftRange, rightRange);
System.Console.WriteLine('[' + string.Join(", ", arrey) + ']');
int even = SomeNumber(arrey);
System.Console.WriteLine($"Количество чётных чисел в массиве: - {even}");
