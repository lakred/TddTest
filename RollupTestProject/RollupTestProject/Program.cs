// See https://aka.ms/new-console-template for more information
using RollupTestProject;

Console.WriteLine("Example 1");
var products = new List<Product>()
            {
                new Product { GTIN = "G1", Variant = "V1", ProductName = "P1", Price = 100 },
                new Product { GTIN = "G2", Variant = "V1", ProductName = "P1", Price = 100 },
                new Product { GTIN = "G3", Variant = "V2", ProductName = "P1", Price = 100 },
                new Product { GTIN = "G4", Variant = "V2", ProductName = "P1", Price = 100 },
            };
    var rollup = new RollupPrice(products);
    var result = rollup.GetLowestPrices();
    foreach (var entry in result)
    {
        Console.WriteLine($"Level: {entry.Key}, Price: {entry.Value}");
    }


Console.WriteLine("\nExample 2");
    var productsE2 = new List<Product>()
            {
                new Product { GTIN = "G1", Variant = "V1", ProductName = "P1", Price = 50 },
                new Product { GTIN = "G2", Variant = "V1", ProductName = "P1", Price = 100 },
                new Product { GTIN = "G3", Variant = "V2", ProductName = "P1", Price = 100 },
                new Product { GTIN = "G4", Variant = "V2", ProductName = "P1", Price = 100 }
            };
    var rollupE2 = new RollupPrice(productsE2);
    var resultE2 = rollupE2.GetLowestPrices();
    foreach (var entry in resultE2)
    {
        Console.WriteLine($"Level: {entry.Key}, Price: {entry.Value}");
    }

Console.WriteLine("\n1.1) 5 GTIN - 2 Variant - 1 Product");
var products1_1 = new List<Product>()
        {
            new Product { GTIN = "G1", Variant = "V1", ProductName = "P1", Price = 100 },
            new Product { GTIN = "G2", Variant = "V1", ProductName = "P1", Price = 100 },
            new Product { GTIN = "G3", Variant = "V2", ProductName = "P1", Price = 100 },
            new Product { GTIN = "G4", Variant = "V2", ProductName = "P1", Price = 100 },
            new Product { GTIN = "G5", Variant = "V2", ProductName = "P1", Price = 100 }
        };
var rollup1_1 = new RollupPrice(products1_1);
var result1_1 = rollup1_1.GetLowestPrices();
foreach (var entry in result1_1)
{
    Console.WriteLine($"Level: {entry.Key}, Price: {entry.Value}");
}


Console.WriteLine("\n1.2) 5 GTIN - 3 Variant - 1 Product");
var products1_2 = new List<Product>()
        {
            new Product { GTIN = "G1", Variant = "V1", ProductName = "P1", Price = 100 },
            new Product { GTIN = "G2", Variant = "V1", ProductName = "P1", Price = 100 },
            new Product { GTIN = "G3", Variant = "V2", ProductName = "P1", Price = 100 },
            new Product { GTIN = "G4", Variant = "V2", ProductName = "P1", Price = 100 },
            new Product { GTIN = "G5", Variant = "V3", ProductName = "P1", Price = 100 }
        };
var rollup1_2 = new RollupPrice(products1_2);
var result1_2 = rollup1_2.GetLowestPrices();
foreach (var entry in result1_2)
{
    Console.WriteLine($"Level: {entry.Key}, Price: {entry.Value}");
}


Console.WriteLine("\n1.3) 5 GTIN - 2 product");
var products1_3 = new List<Product>()
        {
            new Product { GTIN = "G1", Variant = "V1", ProductName = "P1", Price = 100 },
            new Product { GTIN = "G2", Variant = "V1", ProductName = "P1", Price = 100 },
            new Product { GTIN = "G3", Variant = "V2", ProductName = "P1", Price = 100 },
            new Product { GTIN = "G4", Variant = "V2", ProductName = "P1", Price = 100 },
            new Product { GTIN = "G5", Variant = "V3", ProductName = "P2", Price = 100 }
        };
var rollup1_3 = new RollupPrice(products1_3);
var result1_3 = rollup1_3.GetLowestPrices();
foreach (var entry in result1_3)
{
    Console.WriteLine($"Level: {entry.Key}, Price: {entry.Value}");
}

Console.WriteLine("\n2) NULL");
var products2 = new List<Product>()
        {
            new Product { GTIN = "G1", Variant = "V1", ProductName = "P1", Price = null },
            new Product { GTIN = "G2", Variant = "V1", ProductName = "P1", Price = 100 },
            new Product { GTIN = "G3", Variant = "V2", ProductName = "P1", Price = 100 },
            new Product { GTIN = "G4", Variant = "V2", ProductName = "P1", Price = 100 },
        };
var rollup2 = new RollupPrice(products2);
var result2 = rollup2.GetLowestPrices();
foreach (var entry in result2)
{
    Console.WriteLine($"Level: {entry.Key}, Price: {entry.Value}");
}

Console.WriteLine("\n3)  DIFFERENT PRICES FROM ONE BRANCH");
var products3 = new List<Product>()
        {
            new Product { GTIN = "G1", Variant = "V1", ProductName = "P1", Price = 50 },
            new Product { GTIN = "G2", Variant = "V1", ProductName = "P1", Price = 100 },
            new Product { GTIN = "G3", Variant = "V2", ProductName = "P1", Price = 100 },
            new Product { GTIN = "G4", Variant = "V2", ProductName = "P1", Price = 100 },
        };
var rollup3 = new RollupPrice(products3);
var result3 = rollup3.GetLowestPrices();
foreach (var entry in result3)
{
    Console.WriteLine($"Level: {entry.Key}, Price: {entry.Value}");
}

Console.WriteLine("\n3)  DIFFERENT PRICES FROM ONE BRANCH");
var products4 = new List<Product>()
        {
            new Product { GTIN = "G1", Variant = "V1", ProductName = "P1", Price = 50 },
            new Product { GTIN = "G2", Variant = "V1", ProductName = "P1", Price = 70 },
            new Product { GTIN = "G3", Variant = "V2", ProductName = "P1", Price = 100 },
            new Product { GTIN = "G4", Variant = "V2", ProductName = "P1", Price = 90 },
        };
var rollup4 = new RollupPrice(products4);
var result4 = rollup4.GetLowestPrices();
foreach (var entry in result4)
{
    Console.WriteLine($"Level: {entry.Key}, Price: {entry.Value}");
}