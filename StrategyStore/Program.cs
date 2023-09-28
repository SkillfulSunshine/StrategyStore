Console.OutputEncoding = System.Text.Encoding.UTF8;

IPaymentStrategy creditCardPayment = new CreditCardPayment("2352-1212-3535-9598", "Mark Smith", CurrencyCodes.UnitedStatesDollar);
IPaymentStrategy payPalPayment = new PayPalPayment("mark.smith@gmail.com", CurrencyCodes.Euro);

IPromotionStrategy fixedDiscount = new FixedDiscount(10m);
IPromotionStrategy percentageDiscount = new PercentageDiscount(20m);

IMessageDisplayStrategy defaultMessageDisplay = new DefaultMessageDisplay();
IMessageDisplayStrategy symbolMessageDisplay = new SymbolMessageDisplay();

Product product1 = new("Laptop", 1000m);
Product product2 = new("Phone", 500m);

ShoppingCart cart1 = new(creditCardPayment, fixedDiscount, symbolMessageDisplay);
ShoppingCart cart2 = new(payPalPayment, percentageDiscount, defaultMessageDisplay);

cart1.Checkout(new Product[] { product1, product2 });
cart2.Checkout(new Product[] { product1, product2 });
