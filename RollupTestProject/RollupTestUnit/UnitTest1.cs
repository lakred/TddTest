using RollupTestProject;
namespace RollupTestUnit
{
    public class UnitTest1
    {
        [Fact]
        public void TestExample1()
        {
            var input = new List<Product>()
        {
            new Product { GTIN = "G1", Variant = "V1", ProductName = "P1", Price = 100 },
            new Product { GTIN = "G2", Variant = "V1", ProductName = "P1", Price = 100 },
            new Product { GTIN = "G3", Variant = "V2", ProductName = "P1", Price = 100 },
            new Product { GTIN = "G4", Variant = "V2", ProductName = "P1", Price = 100 },
        };
            var rollup = new RollupPrice(input);
            var result = rollup.GetLowestPrices();

            Assert.Equal(100, result["P1"]);
        }
        [Fact]
        public void TestExample2()
        {
            var input = new List<Product>
            {
            new Product { GTIN = "G1", Variant = "V1", ProductName = "P1", Price = 50 },
            new Product { GTIN = "G2", Variant = "V1", ProductName = "P1", Price = 100 },
            new Product { GTIN = "G3", Variant = "V2", ProductName = "P1", Price = 100 },
            new Product { GTIN = "G4", Variant = "V2", ProductName = "P1", Price = 100 }
        };

            var rollup = new RollupPrice(input);
            var result = rollup.GetLowestPrices();

            Assert.Equal(50, result["P1"]);
            Assert.Equal(100, result["G2"]);
            Assert.Equal(100, result["V2"]);
        }

        [Fact]
        public void TestRequirement1()
        {
            var input = new List<Product>
            {
            new Product { GTIN = "G1", Variant = "V1", ProductName = "P1", Price = 100 },
            new Product { GTIN = "G2", Variant = "V1", ProductName = "P1", Price = 100 },
            new Product { GTIN = "G3", Variant = "V2", ProductName = "P1", Price = 100 },
            new Product { GTIN = "G4", Variant = "V2", ProductName = "P1", Price = 100 },
            };

            var rollup = new RollupPrice(input);
            var result = rollup.GetLowestPrices();

            Assert.Equal(100, result["P1"]);
           
        }
        [Fact]
        public void TestRequirement1_1()
        {
            var input = new List<Product>
            {
            new Product { GTIN = "G1", Variant = "V1", ProductName = "P1", Price = 100 },
            new Product { GTIN = "G2", Variant = "V1", ProductName = "P1", Price = 100 },
            new Product { GTIN = "G3", Variant = "V2", ProductName = "P1", Price = 100 },
            new Product { GTIN = "G4", Variant = "V2", ProductName = "P1", Price = 100 },
            new Product { GTIN = "G5", Variant = "V2", ProductName = "P1", Price = 100 },
        };
            var rollup = new RollupPrice(input);
            var result = rollup.GetLowestPrices();

            Assert.Equal(100, result["P1"]);
        }
        [Fact]
        public void TestRequirement1_2()
        {
            var input = new List<Product>
            {
            new Product { GTIN = "G1", Variant = "V1", ProductName = "P1", Price = 100 },
            new Product { GTIN = "G2", Variant = "V1", ProductName = "P1", Price = 100 },
            new Product { GTIN = "G3", Variant = "V2", ProductName = "P1", Price = 100 },
            new Product { GTIN = "G4", Variant = "V2", ProductName = "P1", Price = 100 },
            new Product { GTIN = "G5", Variant = "V3", ProductName = "P1", Price = 100 },
        };
            var rollup = new RollupPrice(input);
            var result = rollup.GetLowestPrices();

            Assert.Equal(100, result["P1"]);
        }
        [Fact]
        public void TestRequirement1_3()
        {
            var input = new List<Product>
            {
            new Product { GTIN = "G1", Variant = "V1", ProductName = "P1", Price = 100 },
            new Product { GTIN = "G2", Variant = "V1", ProductName = "P1", Price = 100 },
            new Product { GTIN = "G3", Variant = "V2", ProductName = "P1", Price = 100 },
            new Product { GTIN = "G4", Variant = "V2", ProductName = "P1", Price = 100 },
            new Product { GTIN = "G5", Variant = "V3", ProductName = "P2", Price = 100 },
        };
            var rollup = new RollupPrice(input);
            var result = rollup.GetLowestPrices();

            Assert.Equal(100, result["P1"]);
            Assert.Equal(100, result["P2"]);
        }
        [Fact]
        public void TestRequirement2()
        {
            var input = new List<Product>
            {
            new Product { GTIN = "G1", Variant = "V1", ProductName = "P1", Price = null },
            new Product { GTIN = "G2", Variant = "V1", ProductName = "P1", Price = 100 },
            new Product { GTIN = "G3", Variant = "V2", ProductName = "P1", Price = 100 },
            new Product { GTIN = "G4", Variant = "V2", ProductName = "P1", Price = 100 },
        };
            var rollup = new RollupPrice(input);
            var result = rollup.GetLowestPrices();

            Assert.Equal(100, result["G2"]);
            Assert.Equal(100, result["V2"]);
        }
        [Fact]
        public void TestRequirement3()
        {
            var input = new List<Product>
            {
            new Product { GTIN = "G1", Variant = "V1", ProductName = "P1", Price = 50 },
            new Product { GTIN = "G2", Variant = "V1", ProductName = "P1", Price = 100 },
            new Product { GTIN = "G3", Variant = "V2", ProductName = "P1", Price = 100 },
            new Product { GTIN = "G4", Variant = "V2", ProductName = "P1", Price = 100 },
        };
            var rollup = new RollupPrice(input);
            var result = rollup.GetLowestPrices();

            Assert.Equal(50, result["P1"]);
            Assert.Equal(100, result["V2"]);
            Assert.Equal(100, result["G2"]);
           
        }
        [Fact]
        public void TestRequirement4()
        {
            var input = new List<Product>
            {
            new Product { GTIN = "G1", Variant = "V1", ProductName = "P1", Price = 50 },
            new Product { GTIN = "G2", Variant = "V1", ProductName = "P1", Price = 70 },
            new Product { GTIN = "G3", Variant = "V2", ProductName = "P1", Price = 100 },
            new Product { GTIN = "G4", Variant = "V2", ProductName = "P1", Price = 90 },
        };
            var rollup = new RollupPrice(input);
            var result = rollup.GetLowestPrices();

            Assert.Equal(50, result["P1"]);
            Assert.Equal(90, result["V2"]);
            Assert.Equal(70, result["G2"]);
            Assert.Equal(100, result["G3"]);

        }
    }
}