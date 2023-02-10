int[] Array = {6,7,19,345,3};
Console.WriteLine("Enter a digit you want to check: ");
int n = Int32.Parse(Console.ReadLine());

int ForCompare=0;
foreach (int element in Array)
{
    if (element == n)
    {
        Console.WriteLine("Your number is contained in array");
        ForCompare = n;
        break;
    }
}
if (ForCompare != n) Console.WriteLine("Your number is NOT contained in array");