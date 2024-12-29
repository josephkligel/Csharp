﻿public class VideoGame
{
	public string Title { get; set; }
	public int ReleaseYear { get; set; }
	public float Rating { get; set; }

	public override string ToString()
	{
		return $"{Title}, released in {ReleaseYear}, rating: {Rating}";
	}
}
