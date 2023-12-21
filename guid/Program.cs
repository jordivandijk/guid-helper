using guid;

try
{
    if (args.Length == 0)
    {
        ConsoleHelper.WriteInfo();
    }
    else
    {
        switch (args[0])
        {
            case "new":
                GuidHelper.Create(args);
                break;
            case "validate":
                GuidHelper.Validate(args);
                break;
            default:
                Console.WriteLine($"There is no function called {args[0]}");
                break;
        }
    }
}
catch (Exception)
{
    ConsoleHelper.WriteConsoleWithColor("Something went wrong please read the above error message", ConsoleColor.Red);
}

