namespace Library
{
    public class Passanger : User
    {
        public Passanger(string calification, string name, string lastname, string ID) :
            base(name, lastname, ID)
        {
            this.Calification = calification;
        }

        public string Calification { get; set; }

    }
}