
void Swaps (string[] n)
{
    if (n.Length == 1)
    {
        Console.WriteLine(n);
    }
    else if (n.Length == 2)
    {
        Console.WriteLine($"[{string.Join(", ", n)}]");
        string a = n[0];
        n[0] = n[1];
        n[1] = a;
        Console.WriteLine($"[{string.Join(", ", n)}]");
    }
    else 
    {
        for (int count = 0; count < n.Length; count++)
        {    
            for (int i = 1; i < n.Length; i++) 
            {
                string b = n[n.Length - 1];
                n[n.Length - 1] = n[n.Length - 1 - i];
                n[n.Length - 1 - i] = b;
                Console.WriteLine($"[{string.Join(", ", n)}]");
            }
              
        }    
        
    } 
}

Console.Clear();
string[] n = { "A", "B", "C", "D", "F" };
Swaps(n);



//  A B C D 
//  B A C D
//  C A B D
//  D A B C

    // for (int i = 0; i < n.Length; i++)
    // {
    //     string a = n[n.Length - 1];
    //     n[n.Length - 1] = n[n.Length - 1 - i];
    //     n[n.Length - 1 - i] = a;
    //     Console.WriteLine($"[{string.Join(", ", n)}]");
    //     if (n.Length - 1 - i == 0)
    //     {
    //         for (int j = 0; j < n.Length - 1; j++)
    //         {
    //             string b = n[j + 1];
    //             n[j + 1] = n[j];
    //             n[j] = b;
    //             Console.WriteLine($"[{string.Join(", ", n)}]");
    //         }
    //     }
    // }