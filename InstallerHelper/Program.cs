try
{
    string? oldPath = Environment.GetEnvironmentVariable("PATH", EnvironmentVariableTarget.Machine);
    string programFiles = Environment.ExpandEnvironmentVariables("%ProgramW6432%");

    if (!string.IsNullOrEmpty(oldPath))
    {
        Environment.SetEnvironmentVariable("PATH", oldPath + $"{programFiles}\\JordIT\\guid\\", EnvironmentVariableTarget.Machine);
        return 0;
    }
    else
    {
        Console.Error.WriteLine("Could not get acces to your path variables, make sure you run this as admin.");
        return 1;
    }
}
catch(Exception ex) 
{
    Console.Error.WriteLine(ex.ToString());
    return 1;
}
