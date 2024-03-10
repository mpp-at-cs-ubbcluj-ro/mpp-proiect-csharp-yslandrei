namespace mpp.domain
{
    public class Concert : Entity<long>
    {
        private string artist;
        private DateTime date;
        private string location;
        private int availableTickets;

        public Concert(long id, string artist, DateTime date, string location, int availableTickets) : base(id)
        {
            this.artist = artist;
            this.date = date;
            this.location = location;
            this.availableTickets = availableTickets;
        }

        public string Artist
        {
            get { return artist; }
            set { artist = value; }
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public string Location
        {
            get { return location; }
            set { location = value; }
        }

        public int AvailableTickets
        {
            get { return availableTickets; }
            set { availableTickets = value; }
        }

        public override bool Equals(object obj)
        {
            if (this == obj)
                return true;

            if (obj == null || GetType() != obj.GetType())
                return false;

            var concert = (Concert)obj;
            return availableTickets == concert.availableTickets && artist == concert.artist && date == concert.date && location == concert.location;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(artist, date, location, availableTickets);
        }
    }
}