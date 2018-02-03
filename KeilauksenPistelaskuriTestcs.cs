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

        //Tässä on laskurin  10 ruutua.
        public class KeilausLaskuri
        {

            private readonly Frame[] _frames = new Frame[10];
            private int _currentFrame;


            private Frame LastFrame { get { return _frames[_currentFrame - 1]; } }
            private Frame TwoFramesAgo { get { return _frames[_currentFrame - 2]; } }

            public int Score { get; private set; }



            public void BowlFrame(Frame frame)
            {

            }

        }

    }
}
    

