int[] arr1 = { 1, 2, 3, 5, 9 };
int[] arr2 = { 1, 2, 3, 4, 5 };
int[] arr3 = new int[arr1.Length + arr2.Length];

int i = 0;
int j = 0;
int k = 0;

while (i < arr1.Length && j < arr2.Length)
{
    arr3[k++] = arr1[i++];
    arr3[k++] = arr2[j++];
}

for (int m = 0; m < arr1.Length + arr2.Length; m++)
    Console.Write(arr3[m] + " ");