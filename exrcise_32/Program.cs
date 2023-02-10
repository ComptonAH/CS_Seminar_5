int[] Array = new int[new Random().Next(3,7)];
int[] NewArray = new int[Array.Length];

for (int i = 0; i < Array.Length; i++)
{
    Array[i] = new Random().Next(-11,11);
    Console.Write($"{Array[i]} ");
    NewArray[i] = -Array[i];
    Console.WriteLine($"{NewArray[i]} ");
}
