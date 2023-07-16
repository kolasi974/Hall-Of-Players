namespace Api.Entities.Database;

public class Service
{
	public Service(int id, string label, string image)
	{
		Id = id;
		Label = label;
		Image = image;
	}

	public int Id { get; private set; }

	public string Label { get; private set; }

	public string Image { get; private set; }
}

