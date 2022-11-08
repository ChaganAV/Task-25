int size = 2;
int[] array = new int[size];

Console.WriteLine("Введите два числа");
for(int i = 0; i < array.Length; i++)
{
    array[i] = ReadInline(">>");
}

Console.WriteLine($"{PowerOfNumber(array)}");

int ReadInline(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int PowerOfNumber(int[] arr)
{
    int result = 1;
    for(int i = 0; i < arr[1]; i++)
    {
        result*=arr[0];
    }
    return result;
}