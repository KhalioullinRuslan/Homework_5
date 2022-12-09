// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();

int DiffNumber(string str)
{
    System.Console.WriteLine(str);
    int number = Int32.Parse(Console.ReadLine());
    return number;
}

int[] DiffArrWithRandomNumbers(int lenght, int min, int max)
{
    int[] arr = new int[lenght];
    Random rand = new Random();
    for (int i = 0; i < lenght; i++)
    {
        arr[i] = rand.Next(min, max); 
    }
    return arr;
}

void FindMinMax(int[] arr, out int min, out int max)
{
    min = arr[0];
    max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < min)
            min = arr[i];
        if (arr[i] > max)
            max = arr[i];
    }
}

const int leftRange = 0;
const int rightRange = 100;
int arrLenght = DiffNumber("Введите размер масива");

    int[] arrey = DiffArrWithRandomNumbers(arrLenght, leftRange, rightRange);
    System.Console.WriteLine('[' + string.Join("; ", arrey) + ']');
    FindMinMax(arrey, out int min, out int max);
    System.Console.WriteLine($"Разница между минимальным значением({min}) и максимальным значением ({max}) равна: {max - min}");

