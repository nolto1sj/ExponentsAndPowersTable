bool loop = true;
while (loop)
{
    try
    {
        Console.WriteLine("Learn our squares and cubes!\n");

        Console.Write("Enter an integer: ");
        int input = int.Parse(Console.ReadLine());
        Console.WriteLine(string.Format($"{"Number",0} {"Squared",15} {"Cubed",15}"));
        Console.WriteLine(string.Format($"{"=======",0} {"=======",14} {"=======",17}"));
        for (int i = 1; i <= input; i++)
        {
            int s = i * i;
            int c = i * i * i;
            if (c > 99)
            {
                Console.WriteLine(string.Format($"{i,0} {s,15} {c,18}"));
            }
            else if (c > 9)
            {
                if (s > 9)
                {
                    Console.WriteLine(string.Format($"{i,0} {s,15} {c,17}"));
                }
                else Console.WriteLine(string.Format($"{i,0} {s,14} {c,18}"));
            }
            else
            {
                Console.WriteLine(string.Format($"{i,0} {s,14} {c,17}"));
            }
        }
        Console.WriteLine("\nType 'continue' to continue.");
        var response = Console.ReadLine();
        while(response != "continue")
        {
            Console.WriteLine("Goodbye!");
            Thread.Sleep(1500);
            response = "continue";
            loop = false;
        }
        Console.Clear();
    }
    catch
    {
        Console.WriteLine("Please enter a valid input.");
        Thread.Sleep(1000);
        Console.Clear();
    }
}
