
Console.Clear();
Console.WriteLine("Enter 0 to stop input");
int n = Convert.ToInt32(Console.ReadLine());
int positive = 0;
if (n > 0)
{
    positive++;
}
while (n != 0)
{
    n = Convert.ToInt32(Console.ReadLine());
    if (n > 0)
    {
        positive++;
    }
    
}
Console.WriteLine("End");
Console.WriteLine($"Count more than 0 = {positive}");