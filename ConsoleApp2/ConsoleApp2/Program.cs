using System;

public interface IDiscountStrategy
{
    double ApplyDiscount(double amount);
}

public class RegularCustomerDiscount : IDiscountStrategy
{
    public double ApplyDiscount(double amount)
    {
        return amount;
    }
}

public class SilverCustomerDiscount : IDiscountStrategy
{
    public double ApplyDiscount(double amount)
    {
        return amount * 0.9;
    }
}

public class GoldCustomerDiscount : IDiscountStrategy
{
    public double ApplyDiscount(double amount)
    {
        return amount * 0.8;
    }
}

public class DiscountCalculator
{
    private readonly IDiscountStrategy _discountStrategy;
    
    public DiscountCalculator(IDiscountStrategy discountStrategy)
    {
        _discountStrategy = discountStrategy;
    }

    public double CalculateDiscount(double amount)
    {
        return _discountStrategy.ApplyDiscount(amount);
    }
}

class Program
{
    static void Main(string[] args)
    {
        IDiscountStrategy silverStrategy = new SilverCustomerDiscount();
        DiscountCalculator silverDiscountCalculator = new DiscountCalculator(silverStrategy);
        double silverDiscountedAmount = silverDiscountCalculator.CalculateDiscount(100);
        Console.WriteLine("Silver customer discount: " + silverDiscountedAmount);
        
        IDiscountStrategy goldStrategy = new GoldCustomerDiscount();
        DiscountCalculator goldDiscountCalculator = new DiscountCalculator(goldStrategy);
        double goldDiscountedAmount = goldDiscountCalculator.CalculateDiscount(100);
        Console.WriteLine("Gold customer discount: " + goldDiscountedAmount);
        
        IDiscountStrategy regularStrategy = new RegularCustomerDiscount();
        DiscountCalculator regularDiscountCalculator = new DiscountCalculator(regularStrategy);
        double regularDiscountedAmount = regularDiscountCalculator.CalculateDiscount(100);
        Console.WriteLine("Regular customer discount: " + regularDiscountedAmount);
    }
}
