using EntitiesCs;
public class NewAccount
{
    static void Main()
    {
        #region "cuenta1"
        Account cuenta0 = new Account(15, 20);
        informeCuenta(cuenta0);
        Console.ReadKey();
        Console.Clear();
        SavingAccount cuenta1 = new SavingAccount(20, 0, 5);
        Console.Write("Deposito: ");
        cuenta1.Deposit(decimal.Parse(Console.ReadLine()));
        cuenta1.DepositMonthlyInteres();
        #endregion
        informeCuenta(cuenta1);
    }
    private static void informeCuenta(Account cuenta0)
    {
        Console.Write($"Numero Cuenta: {cuenta0.Number}\n" +
                    $"Balance: {cuenta0.Balance}\n");
    }
    private static void informeCuenta(SavingAccount cuenta1)
    {
        informeCuenta((Account)cuenta1);
        Console.Write($"Interes mensual: {cuenta1.MonthlyInterestRate}");
    }
}