int[] arr = new int[4];

Random rnd = new Random();

int a = 0;

Console.Write("[");
for (int i = 0;i < arr.Length; i++)
{
    arr[i] = rnd.Next(-1000, 1001);
    Console.Write(arr[i]);
    Console.Write(", ");
}
Console.Write("] -> ");
for (int i = 1; i < arr.Length; i += 2)
{
    a = a + arr[i];
}
Console.WriteLine(a);