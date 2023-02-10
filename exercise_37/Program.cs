// Solution for a particular array! Common solution will have 1 more cycle to fill an empty array up.
int[] Array = {1,2,3,4,5,6};
int[] NewArray = new int[Array.Length];
for (int i = Array.Length-1, j = 0; j < Array.Length; j++,i--)
{
    NewArray[j] = Array[i];
}

if (Array.Length%2 != 0)
{
    double ArrLen = Array.Length;
    int ArrayLength = Convert.ToInt32(Math.Round(ArrLen/2)) + 1;
    for (int i = 0; i < ArrayLength; i++)
    {
        if (i != ArrayLength-1)
        {
            Console.Write($"{NewArray[i]*Array[i]} ");
        }
        else 
        {
            Console.Write($"{NewArray[i]} ");
        }    
    }
}
else
{
    for (int i = 0; i < Array.Length/2; i++)
    {
        Console.Write($"{NewArray[i]*Array[i]} ");
    }
}