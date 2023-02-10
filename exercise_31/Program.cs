int[] Array = new int[12];

for (int i = 0; i < Array.Length; i++)
{
    Array[i] = new Random().Next(-10,10);
    Console.Write($"{Array[i]} ");
}

int PosResult = 0;
int NegatResult = 0;

foreach (int element in Array)
{
    if (element>0) PosResult = PosResult + element;
    else NegatResult = NegatResult - element;
}

// Для наглядности добавлены выводы значений в консоль
Console.WriteLine();
Console.WriteLine(PosResult);
Console.WriteLine(~NegatResult);