using TextCopy;
namespace guid;

internal static class GuidHelper
{
    /// <summary>
    ///     main entryPoint for creating new Guids
    /// </summary>
    /// <param name="args"></param>
    internal static void Create(string[] args)
    {
        if (args.Length > 1)
        {
            if (int.TryParse(args[1], out int amount))
            {
                if (amount < 1000 && amount > 0)
                {
                    WriteGuids(amount);
                }
                else
                {
                    ConsoleHelper.WriteConsoleWithColor($"Please enter an amount between 0 and 1000", ConsoleColor.Red);
                }
            }
            else
            {
                ConsoleHelper.WriteConsoleWithColor($"{args[1]} is not a correct amount of guids, please enter a NUMBER between 1 and 1000", ConsoleColor.Red);
            }
        }
        else
        {
            WriteGuids(1);
        }
    }

    /// <summary>
    ///     Function that validates guids 
    /// </summary>
    /// <param name="args"></param>
    internal static void Validate(string[] args)
    {
        if (args.Length > 1)
        {
            for (int i = 1; i < args.Length; i++)
            {
                if (Guid.TryParse(args[i], out Guid result))
                {
                    ConsoleHelper.WriteConsoleWithColor($"{result} is a valid guid", ConsoleColor.Green);
                }
                else
                {
                    ConsoleHelper.WriteConsoleWithColor($"{args[i]} is not a valid guid", ConsoleColor.Red);
                }
            }
        }
        else
        {
            ConsoleHelper.WriteConsoleWithColor("please provide a Guid to validate", ConsoleColor.Red);
        }
    }

    /// <summary>
    ///     Creates and writes down new guid
    /// </summary>
    /// <param name="ammount"></param>
    internal static void WriteGuids(int ammount)
    {
        string guids = "";
        for (int i = 0; i < ammount; i++)
        {
            if (i == 0)
            {
                guids += Guid.NewGuid();
            }
            else
            {
                guids += "\n" + Guid.NewGuid();
            }
        }

        ConsoleHelper.WriteConsoleWithColor(guids, ConsoleColor.Green);
        ClipboardService.SetText(guids);

        Console.WriteLine("Guid(s) have been copied to your clipboard.");
    }
}
