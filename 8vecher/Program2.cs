int[] arr = new int[4];

Random rnd = new Random();

int chet = 0;
Console.Write("[");
for(int i = 0; i < arr.Length;i++)
{
    arr[i] = rnd.Next(100, 1000);
    Console.Write(arr[i]);
    Console.Write(", ");
}
Console.Write("] -> ");
for(int i =0; i < arr.Length;i++)
{
    if (arr[i] % 2 == 0)
        chet++;
}
Console.WriteLine(chet);