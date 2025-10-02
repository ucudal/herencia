namespace Library
{
    public abstract class Driver : User
    {
        public Driver(string calification, string vehicle, string biografy, string name, string lastname, string ID) :
            base(name, lastname, ID)
        {
            this.Calification = calification;
            this.Vehicle = vehicle;
            this.Biografy = biografy;
        }

        public string Vehicle { get; set; }
        public string Calification { get; set; }
        public string Biografy { get; set; }
    }
}