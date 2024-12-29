using GameDataParser.Data;
using GameDataParser.UserInteraction;

public class ConsoleUserInteraction : IUserInteraction
{
    private readonly FileMetaData _fileMetaData;
    private readonly FileVerifier _fileVerifier;
    public ConsoleUserInteraction(FileMetaData fileMetaData, FileVerifier fileVerifier)
    {
        _fileMetaData = fileMetaData;
        _fileVerifier = fileVerifier;
    }
    public void Prompt()
    {
        bool isFileValid = false;
        do
        {
            Console.WriteLine("Enter the name of the file you want to read: ");
            _fileMetaData.FileName = Console.ReadLine();

            isFileValid = _fileVerifier.Verify(_fileMetaData.FileName);
        } while (!isFileValid);
    }
}