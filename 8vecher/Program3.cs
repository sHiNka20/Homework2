double[] arr = new double[4];

Random rnd = new Random();


Console.Write("[");
for (int i = 0;i < arr.Length; i++)
{
    arr[i] = rnd.Next(-500, 501);
    arr[i] += rnd.NextDouble();
    Console.Write(arr[i]);
    Console.Write(", ");
}
Console.Write("] -> ");

double max = arr[0];
double min = arr[0];

for (int i = 1;i < arr.Length;i++)
{
    if (arr[i] > max)
        max = arr[i];
}

for (int i = 1;i < arr.Length;i++)
{
    if (arr[i] < min)
        min = arr[i];
}
Console.Write($"{max} - {min} = ");
Console.WriteLine(max-min);