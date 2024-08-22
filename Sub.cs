Random random = new Random();
int daysUntilExpiration = random.Next(12) ;
int discountPercentage = 0;

if (daysUntilExpiration == 0)
{
    Console.WriteLine("Your subscription has expired.");
}

else if (daysUntilExpiration == 1)
{
    Console.WriteLine($"Your subscription ends in 1 day");
    discountPercentage = 7;
}

else if (daysUntilExpiration <= 5)
{
    Console.WriteLine($"Your subscription ends in {daysUntilExpiration} days");
    discountPercentage = 15;
}

else if (daysUntilExpiration <= 10)
{
    Console.WriteLine("Your subscription will expire soon. Renew Now!");
    discountPercentage = 30;
}

if (discountPercentage > 0)
{
    Console.WriteLine($"Renew now and save {discountPercentage}%");
}