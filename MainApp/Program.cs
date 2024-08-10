using Infrastructure;

IPaymentMethod payment = new PaymentProcessor();
payment.Pay(100);

IPaymentMethod payment2 = new CreditCard();
payment2.Pay(200);

IPaymentMethod payment3 = new PayPalPayment();
payment3.Pay(300);