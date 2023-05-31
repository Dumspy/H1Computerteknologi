using UserFolder;

var userFolder = new Controller();
Console.WriteLine(userFolder.GetPath());

int number = 0;

while (true)
{
    // Increase the number by one
    number++;

    // Print the current number
    Console.WriteLine(number);

    // Wait for one second
    Thread.Sleep(1000);
}