namespace Api.Entities.Database;

	public class User
	{
		public User(int id, string name, string image)
		{
            Id = id;    
            Name = name;
            Image = image;
		}

        public int Id { get; private set; }

        public string Name { get; private set; }

        public string Image { get; private set; }
    }


