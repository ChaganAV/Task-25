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

int PowerOfNumber(int[] array)
{
    int result = 0;
    for(int i = 0; i < array.Length; i++)
    {
        result*=array[0];
    }
    return result;
}