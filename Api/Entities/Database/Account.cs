namespace Api.Entities.Database;

public class Account
{
	public Account(string email, string password, int ownerId, int serviceId)
	{
		Email = email;
		Password = password;
		OwnerId = ownerId;
		ServiceId = serviceId;
	}

    public string Email { get; private set; }

    public string Password { get; private set; }

    public int OwnerId { get; private set; }

    public int ServiceId { get; private set; }
}

