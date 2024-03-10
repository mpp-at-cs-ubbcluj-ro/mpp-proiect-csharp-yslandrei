namespace mpp.domain
{
    public class Account : Entity<long>
    {
        private string name;
        private string email;
        private string password;

        public Account(long id, string name, string email, string password) : base(id)
        {
            this.name = name;
            this.email = email;
            this.password = password;
        }

        public string Name
        {
            get { return name; }
        }

        public string Email
        {
            get { return email; }
        }

        public string Password
        {
            get { return password; }
        }

        public override bool Equals(object obj)
        {
            if (this == obj)
                return true;

            if (obj == null || GetType() != obj.GetType())
                return false;

            Account account = (Account)obj;
            return name == account.name && email == account.email && password == account.password;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(name, email, password);
        }
    }
}