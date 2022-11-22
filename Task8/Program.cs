void perfectSquares(int i)
{
    
        if (Math.Sqrt(i) == (int)Math.Sqrt(i))
            Console.Write(i + " ");
    
}
    int a = 2, b = 100;
   // perfectSquares(a, b);

int[] arr = { 2, 4, 5, 6, 7, 8, 9, 25, 70, 80, 35, 12 };
for(int i = 0; i < arr.Length; i++)
{
    perfectSquares((int)arr[i]);
}
