using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Compatibility;
using KeilauksenPistelaskuri;
using NUnit.Framework;

namespace KeilauksenPistelaskuri
{
    [TestFixture]

    public class PisteLaskuriTest
    {
        PisteLaskuri laskuri;

        [SetUp]
        
        public void TestienAlustus()
        {
            laskuri = new PisteLaskuri();

        }
    }
}
