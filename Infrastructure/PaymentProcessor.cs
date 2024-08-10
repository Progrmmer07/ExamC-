﻿namespace Infrastructure;

public class PaymentProcessor : IPaymentMethod
{
    public void Pay(decimal amount)
    {
        if (amount > 0)
        {
            Console.WriteLine(amount);
        }
    }
}