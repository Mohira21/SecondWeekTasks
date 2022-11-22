int[] arr = { 10, 324, 45, 90, 9808 };

int largest()
{
    int i;

    int max = arr[0];

    for (i = 1; i < arr.Length; i++)
        if (arr[i] > max)
            max = arr[i];

    return max;
}

    Console.WriteLine("Largest in given array is " + largest());