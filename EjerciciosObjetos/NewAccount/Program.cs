using EntitiesCs;
public class NewAccount
{
    static void Main()
    {
        Bank bank = new Bank();
        #region "Customer0"
        DateTime birthDay = DateTime.Now;
        Console.Write("Nombre: ");
        NewCustomer customer0 = new NewCustomer("", 0, birthDay);
        bank.AddCustomer(customer0);
        mostrarClientes(bank);
        Console.ReadKey();
        Console.Clear();
        #endregion
        #region "cuenta1"
        //Account cuenta0 = new Account(15, 20);
        //informeCuenta(cuenta0);
        //Console.ReadKey();
        //Console.Clear();
        SavingAccount cuenta1 = new SavingAccount(20, 20, 5);
        cuenta1.Customer = customer0;
        //Console.Write("Deposito: ");
        //cuenta1.Deposit(decimal.Parse(Console.ReadLine()));
        cuenta1.DepositMonthlyInteres();
        #endregion
        informeCuenta(cuenta1);
    }

    private static void mostrarClientes(Bank bank)
    {
        Console.WriteLine("\nLista de Clientes \n");
        foreach (NewCustomer item in bank.GetCustomer())
            Console.WriteLine(item.Name);
    }

    private static void informeCuenta(Account cuenta1)
    {
        Console.Write($"\nNumero Cuenta: {cuenta1.Number}\n" +
            $"Nombre Cliente: {cuenta1.Customer.Name}\n" +
            $"DNI: {cuenta1.Customer.Dni}\n" +
            $"Fecha Nacimiento: {cuenta1.Customer.BirthDay}\n" +
            $"Edad: {cuenta1.Customer.Age}\n" +
            $"Nacionalidad: {cuenta1.Customer.Nationality}\n" +
            $"Balance: {cuenta1.Balance}\n");
    }
    private static void informeCuenta(SavingAccount cuenta1)
    {
        informeCuenta((Account)cuenta1);
        Console.Write($"Interes mensual: {cuenta1.MonthlyInterestRate}\n");
    }
}