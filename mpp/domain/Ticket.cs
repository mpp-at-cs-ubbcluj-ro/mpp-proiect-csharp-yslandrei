namespace mpp.domain
{
    public class Ticket : Entity<long>
    {
        private long concertId;
        private string buyer;
        private int seats;

        public long ConcertId
        {
            get { return concertId; }
            set { concertId = value; }
        }

        public string Buyer
        {
            get { return buyer; }
            set { buyer = value; }
        }

        public int Seats
        {
            get { return seats; }
            set { seats = value; }
        }

        public Ticket(long id, long concertId, string buyer, int seats) : base(id)
        {
            this.concertId = concertId;
            this.buyer = buyer;
            this.seats = seats;
        }

        public override bool Equals(object obj)
        {
            if (this == obj)
                return true;

            if (obj == null || GetType() != obj.GetType())
                return false;

            Ticket ticket = (Ticket)obj;
            return seats == ticket.seats && concertId == ticket.concertId && buyer == ticket.buyer;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(concertId, buyer, seats);
        }
    }
}