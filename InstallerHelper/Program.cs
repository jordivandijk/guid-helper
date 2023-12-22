
string? oldPath = Environment.GetEnvironmentVariable("PATH", EnvironmentVariableTarget.Machine);
string programFiles = Environment.ExpandEnvironmentVariables("%ProgramW6432%");

if (!string.IsNullOrEmpty(oldPath))
{
    Environment.SetEnvironmentVariable("PATH", oldPath + $"{programFiles}\\JordIT\\guid\\", EnvironmentVariableTarget.Machine);
}
else
{
    Console.WriteLine("Something went wrong while adding the program to the PATH variables");
    Console.ReadLine();
}
