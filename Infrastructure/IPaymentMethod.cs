﻿namespace Infrastructure;

public interface IPaymentMethod
{
    public void Pay(decimal amount);
}