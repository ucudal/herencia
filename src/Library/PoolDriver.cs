namespace Library
{
    public class PoolDriver : Driver
    {
        public PoolDriver(string capacity, string calification, string vehicle, string biografy, string name, string lastname, string ID) :
            base(calification, vehicle, biografy, name, lastname, ID)
        {
            this.Capacity = capacity;
        }

        public string Capacity { get; set; }
    }
}