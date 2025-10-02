using System.Collections.Generic;

namespace Library
{
    public class Driver_Repository : BaseRepository
    {
        private List<Driver> Drivers = new List<Driver>();

        public void AddDriver(Driver driver)
        {
            Drivers.Add(driver);
        }
    }
}