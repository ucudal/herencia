using System.Collections.Generic;

namespace Library
{
    public class Passanger_Repository : BaseRepository
    {
        private List<Passanger> Passangers = new List<Passanger>();

        public void AddPaaanger(Passanger passanger)
        {
            Passangers.Add(passanger);
        }
    }
}