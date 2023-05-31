using UserFolder;

var userFolder = new UserFolder.Controller();

switch (Console.ReadKey().Key)
{
    case ConsoleKey.D1:
        Console.WriteLine();
        Console.Write("Enter file name: ");
        var fileName = Console.ReadLine();
        if (fileName != null) userFolder.CreateFile(fileName);
        break;
    case ConsoleKey.D2:
        Console.WriteLine();
        Console.WriteLine(userFolder.GetPath());
        break;
    default:
        Console.WriteLine();
        Console.WriteLine("Unknown key pressed");
        break;
}