namespace Library
{
    public abstract class User 
    {
        public User(string name, string lastname, string ID)
        {
            this.Name = name;
            this.Lastname = lastname;
            this.Id = ID;
        }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Id { get; set; }
    }
}