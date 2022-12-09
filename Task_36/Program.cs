// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();

int OddNumber(string str)
{
    System.Console.WriteLine(str);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int[] OddArrWithRandomNumbers(int lenght, int min, int max)
{
    int[] arr = new int [lenght];
    Random rand = new Random();
    for (int i = 0; i < lenght; i++)
    {
        arr[i] = rand.Next(min, max);
    }
    return arr;
}

void SumNumber(int[] arr, out int sum1, out int sum2) 
{
    sum1 = 0;
    sum2 = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(i % 2 == 1)
            sum1 += arr[i];
        else
            sum2 += arr[i];
    }

}

const int leftRange = -100;
const int rightRange = 100;
int arrLenght = OddNumber("Введите размер масива");
int[] arrey = OddArrWithRandomNumbers(arrLenght, leftRange, rightRange);
System.Console.WriteLine('[' + string.Join(", ", arrey) + ']');
SumNumber(arrey, out int sum1, out int sum2); 
System.Console.WriteLine($"Сумма элементов стоящих на нечетной позиции = {sum2}"); // на четной = {sum2}


