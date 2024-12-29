﻿public class GamesPrinter : IGamesPrinter
{
	private readonly IUserInteractor _userInteractor;

	public GamesPrinter(IUserInteractor userInteractor)
	{
		_userInteractor = userInteractor;
	}

	public void Print(List<VideoGame>? videoGames)
	{
		if (videoGames.Count > 0)
		{
			_userInteractor.PrintMessage("\nLoaded games are:");
			foreach (VideoGame videoGame in videoGames)
			{
				_userInteractor.PrintMessage(videoGame.ToString());
			}
		}
		else
		{
			Console.WriteLine("No games are present in the input file.");
		}
	}
}
