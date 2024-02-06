namespace EntitiesCs
{
    public class Account
    {
        public int Number { get; set; }
        public bool Enabled { get; set; }
        private Decimal _balance = 0;
        public decimal Balance { get { return _balance; } }
        public Account(int number, decimal balance)
        {
            //Console.Write("Numero de Cuenta: ");
            Number = number;
            _balance = balance;
        }
        public NewCustomer Customer { get; set; }
        public void Deposit(decimal value)
        {
            addBalance(value);
        }
        public void WithDraw(decimal value)
        {
            addBalance(-value);
        }
        public void addBalance(decimal value)
        {
            _balance += value;
        }
    }
}