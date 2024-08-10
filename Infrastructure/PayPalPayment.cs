namespace Infrastructure;

public class PayPalPayment : IPaymentMethod
{
    public void Pay(decimal amount)
    {
        if (amount > 0)
        {
            Console.WriteLine(amount);
        }
    }
}