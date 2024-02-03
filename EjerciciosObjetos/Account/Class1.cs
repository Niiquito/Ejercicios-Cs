namespace Account
{
    public class Acount
    {
        public int Number { get; set; }
        public bool Enabled { get; set; }
        private Decimal _balance = 0;
        public decimal Balance { get { return _balance; } }
        public void Deposit(Decimal value)
        {
            addBalance(value);
        }
        public void WithDraw(Decimal value)
        {
            addBalance(-value);
        }
        public void addBalance(Decimal value)
        {
            _balance+=value;
        }

    }
}