namespace UserFolder;

public class Controller
{
    private readonly string _path;

    public Controller()
    {
        _path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
    }
    
    public Controller(string path)
    {
        _path = path;
    }

    public string GetPath()
    {
        return _path;
    }

    public void CreateFile(string fileName)
    {
        string filePath = Path.Combine(_path, fileName, ".txt");

        if (File.Exists(filePath))
        {
            Console.WriteLine("File already exists.");
            return;
        }

        try
        {
            using StreamWriter writer = File.CreateText(filePath);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}