using GameDataParser.Data;
using System.Text.Json;

namespace GameDataParser.Models
{
    public class GamesRepository : IJsonRepository
    {

        public List<Game> Games { get; set; } = new List<Game>();

        public readonly FileMetaData _fileMetaData;

        public readonly Logger _logger;

        public GamesRepository(FileMetaData fileMetaData, Logger logger)
        {
            _fileMetaData = fileMetaData;
            _logger = logger;
        }

        public void GetItems()
        {
            string jsonString = File.ReadAllText(_fileMetaData.FileName);
            try
            {
                Games = JsonSerializer.Deserialize<List<Game>>(jsonString);
            }
            catch (JsonException ex)
            {
                throw new JsonException($"JSON in the {_fileMetaData.FileName} was not in a valid format. JSON body: {File.ReadAllText(_fileMetaData.FileName)}");
            }
            catch (Exception ex)
            {
                _logger.Log(ex);
            }
        }
    }
}