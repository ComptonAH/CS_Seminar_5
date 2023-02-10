int[] Array = new int[123];

for (int i = 0; i < Array.Length; i++)
{
    Array[i] = new Random().Next(180);
}
int count = 0;
foreach (int element in Array)
{
    if (element > 9 && element < 100)
    {
        count++;
    }
}
Console.WriteLine(count);