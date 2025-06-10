int[] numbers = {4, 3, 2, 36, 6, 12, 11, 23, 5, 8, 1, 7};

for (int i = 0; i < numbers.Length; i++)
{
    int minNumber = i;

    for (int j = 0; j < numbers.Length; j++)
    {
        if (numbers[minNumber] < numbers[j])
        {
            minNumber = j;
        }

        int c = numbers[i];
        numbers[i] = numbers[minNumber];
        numbers[minNumber] = c;
    }
}
Console.Write("Подреден масив: ");
Console.WriteLine(string.Join(" ", numbers));