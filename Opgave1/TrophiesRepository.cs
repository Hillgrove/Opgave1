
namespace Opgave1
{
    class TrophiesRepository
    {
        private List<Trophy> _trophies = new List<Trophy>();

        public List<Trophy> Get()
        {
            // TODO: Implement this method
            // Returnerer en kopi af listen af alle Trophy objekter: Brug en copy constructor.
            // Get() skal give mulighed for at filtrere på Year.
            // Get() skal give mulighed for at sortere på Competition eller Year
            throw new NotImplementedException();
        }

        public Trophy GetById(int id)
        {
            // TODO: Implement this method
            // Returnerer Trophy objektet med det angivne id - eller null.
            throw new NotImplementedException();
        }

        public Trophy Add(Trophy trophy)
        {
            // TODO: Implement this method
            // Tilføj id til trophy objektet. Tilføjer trophy til listen. Returnerer Trophy objektet
            throw new NotImplementedException();
        }

        public Trophy? Remove(int id)
        {
            // TODO: Implement this method
            // Sletter Trophy objektet med det angivne id. Returnerer Trophy objektet - eller null.
            throw new NotImplementedException();
        }

        public Trophy? Update(int id, Trophy trophy)
        {
            // TODO: Implement this method
            // Trophy objektet med det angivne id opdateres med values.
            // Returnerer det opdaterede Trophy objekt - eller null.
            throw new NotImplementedException();
        }
    }
}
