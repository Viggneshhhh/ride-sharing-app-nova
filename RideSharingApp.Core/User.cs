namespace RideSharingApp.Core
{

    public enum UserType
    {
        Driver,
        Rider
    }
    public class User
    {
        public Guid Id { get; } = Guid.NewGuid();
        public string Name { get; set; }
        public UserType Type { get; set; }

        public Location? CurrentLocation { get; set; }

        public User(string name, UserType type) 
        { 
            Name = name;
            Type = type;
        }
    }
}
