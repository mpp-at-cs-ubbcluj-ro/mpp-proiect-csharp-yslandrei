namespace mpp.domain
{
    public class Ticket : Entity<long>
    {
        private Concert concert;
        private string buyer;
        private int seats;

        public long Concert
        {
            get { return concert; }
            set { concert = value; }
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

        public Ticket(long id, Concert concert, string buyer, int seats) : base(id)
        {
            this.concert = concert;
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
            return seats == ticket.seats && concert == ticket.concert && buyer == ticket.buyer;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(concert, buyer, seats);
        }
    }
}