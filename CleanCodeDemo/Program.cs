﻿IProductService productService = new ProductManager(new FakeBankService());
productService.Sell(new Product { Id = 1, Name = "Laptop", Price = 1000 },
    new Customer { Id = 1, Name = "Yağız", IsStudent = true, IsOfficer = false });


class Customer : IEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public bool IsStudent { get; set; }
    public bool IsOfficer { get; set; }
}

interface IEntity
{

}

class Product : IEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
}

class ProductManager : IProductService
{
    private IBankService _bankService;

    public ProductManager(IBankService bankService)
    {
        _bankService = bankService;
    }

    public void Sell(Product product, Customer customer)
    {
        decimal price = product.Price;
        if (customer.IsStudent)
        {
            price = product.Price * (decimal)0.90;
        }
        if (customer.IsOfficer)
        {
            price = product.Price * (decimal)0.80;
        }

        price = _bankService.ConvertRate(new CurrencyRate { Currency = 1, Price = price });
        Console.WriteLine(price);
    }
}

interface IProductService
{
    void Sell(Product product, Customer customer);
}

class FakeBankService :IBankService
{
    public decimal ConvertRate(CurrencyRate currencyRate)
    {
        return currencyRate.Price / (decimal)5.30;
    }
}

interface IBankService
{
    decimal ConvertRate(CurrencyRate currencyRate);
}

class CurrencyRate
{
    public decimal Price { get; set; }
    public int Currency { get; set; }
}

class CentralBankAdapter : IBankService
{
    public decimal ConvertRate(CurrencyRate currencyRate)
    {
        CentralBankService centralBankService = new();
        return centralBankService.ConvertCurrency(currencyRate);
    }
}

class CentralBankService
{
    public decimal ConvertCurrency(CurrencyRate currencyRate)
    {
        return currencyRate.Price/(decimal)5.28;
    }
}