
int[] arr = { 1, 5, 10, 15, 20, 25 };
printArray(arr, 6);
rvereseArray(arr, 0, 5);
Console.Write("Reversed array is \n");
printArray(arr, 6);

void rvereseArray(int[] arr,
                    int a, int b)
{
    int temp;

    while (a < b)
    {
        temp = arr[a];
        arr[a] = arr[b];
        arr[b] = temp;
        a++;
        b--;
    }
}

void printArray(int[] arr,
                        int size)
{
    for (int i = 0; i < size; i++)
        Console.Write(arr[i] + " ");

    Console.WriteLine();
}
