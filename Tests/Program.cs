// See https://aka.ms/new-console-template for more information


//Первое задание

Console.WriteLine("Первое задание-----------------------");

string CountPC(int number)
{
    string result = "";
    if (number == 1 || number % 10 == 1 && number > 20) result = $"{number} компьютер";
    else if ((1 < number && number < 5) || ((number % 10 > 1 && number % 10 < 5) && number > 20))
        result = $"{number} компьютерa";
    else result = $"{number} компьютеров";
    return result;
}

string count = CountPC(10);
Console.WriteLine(count);

//Второе задание
Console.WriteLine("Второе задание-----------------------");

int[] CreateArray(int[] array)
{
    List<int> result = new List<int>();
    int num = MinNumber(array);
    while (num >= 1)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % num == 0 && i == array.Length - 1)
            {
                result.Add(num);
            }
        }

        num--;
    }

    return result.ToArray();
}

int MinNumber(int[] nums)
{
    int min = nums[0];
    for (int i = 1; i < nums.Length; i++)
    {
        if (nums[i] < min)
        {
            min = nums[i];
        }
    }

    return min;
}

void ShowArray(int[] array)
{
    foreach (var i in array)
    {
        Console.WriteLine(i);
    }
}

int[] numbers = [8, 12, 4, 16];
var result = CreateArray(numbers);
ShowArray(result);

//третье задание
Console.WriteLine("Третье задание-----------------------");

List<int> CreateList(int a, int b)
{
    List<int> result = new List<int>();
    List<int> tempList = new List<int>();
    if (a < b)
    {
        for (int i = a; i <= b; i++)
        {
            tempList.Add(i);
        }
    }
    else
    {
        for (int i = b; i <= a; i++)
        {
            tempList.Add(i);
        }
    }

    foreach (var t in tempList)
    {
        for (int i = 2; i < t; i++)
        {
            if (t % i == 0)
            {
                break;
            }

            if (i == t - 1)
            {
                result.Add(t);
                break;
            }
        }
    }

    return result;
}

void ShowList(List<int> list)
{
    foreach (var v in list)
    {
        Console.WriteLine(v);
    }
}

var list = CreateList(10, 30);
ShowList(list);

//Четвертое задание
Console.WriteLine("Четвертое задание-----------------------");


void MultiplicationTable(int a)
{
    for (int i = 0; i <= a; i++)
    {
        if (i < 1) Console.Write("   ");
        else Console.Write(i + "  ");
    }

    Console.Write(" ");
    for (int i = 1; i <= a; i++)
    {
        Console.WriteLine();

        Console.Write($"{i}");
        for (int j = 1; j <= a; j++)
        {
            if (i * j / 10 < 1) Console.Write($"  {i * j}");
            else Console.Write($" {i * j}");
        }
    }
}

MultiplicationTable(8);