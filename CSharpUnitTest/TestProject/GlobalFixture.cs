using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class GlobalFixture : IDisposable
    {
        public GlobalFixture()
        {
            Console.WriteLine("GlobalFixture : constructor()");
        }

        public void Dispose()
        {
            Console.WriteLine("GlobalFixture : Dispose()");
        }
    }

    // 더미 클래스
    [CollectionDefinition("GlobalFixture")]
    public class GlobalFixtureCollection : ICollectionFixture<GlobalFixture>
    {
    }
}
