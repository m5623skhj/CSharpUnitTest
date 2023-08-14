namespace UnitTestProject
{
    public class AddTestFixture : IDisposable
    {
        public AddTestFixture()
        {
            Console.WriteLine("AddTestFixture constructor()");
        }

        public void Dispose() 
        {
            Console.WriteLine("AddTestFixture Dispose()");
        }
    }

    [Collection("GlobalFixture")]
    public class AddTest : IDisposable, IClassFixture<AddTestFixture>
    {
        public AddTest()
        {
            Console.WriteLine("AddTest constructor()");
        }

        public void Dispose()
        {
            Console.WriteLine("AddTest Dispose()");
        }

        Test_Add test = new Test_Add();

        [Fact]
        public void Add()
        {
            Console.WriteLine("Call Add()");
            Assert.NotNull(test);

            Assert.Equal("Add", test.name);
            Assert.Equal(300, test.Add(100, 200));
        }

        [Fact]
        public void Temp()
        {
            Console.WriteLine("Call temp()");
        }
    }
}
