namespace Api.Entities.Database;

public class GamingProfile
{
	public GamingProfile(string username, int ownerId, int gameId)
	{
		Username = username;
		OwnerId = ownerId;
		GameId = gameId;
	}

	public string Username { get; private set; }

    public int OwnerId { get; private set; }

    public int GameId { get; private set; }
}

