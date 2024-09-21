
namespace Opgave1
{
    public class Trophy
    {
        private string? _competition;
        public int Id { get; set; }
        public string? Competition
        {
            get { return _competition; }
            set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentException("Competition must be at least 2 characters long");
                }
            }
        }
    }
}
