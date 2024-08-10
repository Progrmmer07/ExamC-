namespace Infrastructure;

public class CreditCard : IPaymentMethod
{
    public void Pay(decimal amount)
    {
        if (amount > 0)
        {
            Console.WriteLine(amount);
        }
    }
}