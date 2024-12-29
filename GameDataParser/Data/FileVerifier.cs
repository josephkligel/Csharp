using GameDataParser.Data;

public class FileVerifier: IFileVerify
{
    private FileMetaData fileMetaData { get; init; }

    public FileVerifier(FileMetaData fileMetaData)
    {
        this.fileMetaData = fileMetaData;
    }

    public bool Verify(string fileName)
    {
        if (fileMetaData.FileName == null)
        {
            Console.WriteLine("File name cannot be null.");
            return false;
        }
        else if (fileMetaData.FileName == "")
        {
            Console.WriteLine("File name cannot be empty.");
            return false;
        }
        else if (!File.Exists(fileMetaData.FileName))
        {
            Console.WriteLine("File not found");
            return false;
        }
        else
        {
            return true;
        }
    }
}