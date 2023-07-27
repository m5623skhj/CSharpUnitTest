namespace UnitTestProject
{
    public class AddTest
    {
        Test_Add test = new Test_Add();

        [Fact]
        public void Add()
        {
            Assert.NotNull(test);

            Assert.Equal("Add", test.name);
            Assert.Equal(300, test.Add(100, 200));
        }
    }
}
