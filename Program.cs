Console.Clear();
Console.Write("Введите количество элементов массива: ");
bool isParsedN = int.TryParse(Console.ReadLine(), out int N);
if (!isParsedN)
{
    Console.WriteLine("Ошибка. Это не число!");
    return;
}

int[] array1 = new int[N];
FillArray(array1);
PrintArray(array1);
int count = EvenNumbers(array1);
Console.WriteLine($"Четных элементов в массиве - {count}");
Console.WriteLine();
Console.WriteLine($"Сумма нечетных элементов = {SumOfOddElements(array1)} ");
Console.WriteLine();
Console.WriteLine($"Разница между максимальным и минимальным значением массива = {DifMaxMin(array1)}");



int DifMaxMin(int[] array)
{
    int dif = 0, max = array[0], min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    dif = max - min;
    return dif;
}
int SumOfOddElements(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sum += array1[i];
    }
    return sum;
}
int EvenNumbers(int[] array)
{
    int countOfEven = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            countOfEven++;
        }
    }
    return countOfEven;
}
void FillArray(int[] array)
{
    Random random = new Random();
    for (var i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(100, 1000);
    }
}
void PrintArray(int[] array)
{

    Console.Write("[");
    for (var i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}]"); 
    Console.WriteLine();
}