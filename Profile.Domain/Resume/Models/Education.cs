namespace Profile.Domain.Resume.Models
{
    public class Education : Entity
    {
        public string Institution { get; private set; }
        public string Degree { get; private set; }
        public DateTime Start { get; private set; }
        public DateTime End { get; private set; }

        private Education()
        {

        }

        public Education(string institution, string degree, DateTime start, DateTime end)
        {
            Id = Guid.NewGuid();
            Institution = institution;
            Degree = degree;
            Start = start;
            End = end;
        }
    }
}
