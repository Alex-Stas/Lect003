// // Упорядочить массив от минимума к максимуму 

// int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

// void PrintArray(int[] array)
// {
//     int count = array.Length;
//     for (int i = 0; i < count; i++)
//     {
//         // Console.WriteLine(array[i]);
//         Console.Write($"{array[i]} ");

//     }
//     Console.WriteLine();
// }

// void SelctionSort(int[] array)
// {
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         int minPosition = i;

//         for (int j = i + 1; j < array.Length; j++)
//         {
//             if (array[j] < array[minPosition]) minPosition = j;
//         }
//         // 
//         // 
//         int temporary = array[i];
//         array[i] = array[minPosition];
//         array[minPosition] = temporary;
//     }


// }

// PrintArray(arr);
// SelctionSort(arr);
// PrintArray(arr);

// Упорядочить массив от максимума к минимуму 

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        // Console.WriteLine(array[i]);
        Console.Write($"{array[i]} ");

    }
    Console.WriteLine();
}

void SelctionSortMax(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[maxPosition]) maxPosition = j;
        }
        // 
        // 
        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
    }


}

PrintArray(arr);
SelctionSortMax(arr);
PrintArray(arr);