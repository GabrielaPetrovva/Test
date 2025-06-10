# Test
BubbleSort
Последователна поредица от най-малкото число. Даден е масив с цели числа, масивът трябва да се сортира във възходящ ред, намира най-дългата поредица от последователни числа и отпечатва дължината на поредицата. Отпечатва се подредения масив, най-дългата поредица от числа и дължината на поредицата. 
Част от кода: 
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
        if (numbers[minNumber + 1] < minNumber)
        Щ   
        }
        int c = numbers[i];
        numbers[i] = numbers[minNumber];
        numbers[minNumber] = c;
        }
}
Console.Write("Подреден масив: ");
Console.WriteLine(string.Join(" ", numbers));
                                                                                                                                                                                                Габриела Стефанова

                                                                                                                                              
