using NUnit.Framework;
using LabaTest3;

namespace NUnitTest
{
    public class Tests
    {
        [TestFixture]
        public class sinTest
        {
            [Test]
            public void Test1()
            {
                var actual = Program.sin(2);

                Assert.AreEqual(0.909297, actual, 0.0001);
            }
        }

        [TestFixture]
        public class cosTest
        {
            [Test]
            public void Test1()
            {
                var actual = Program.cos(2);

                Assert.AreEqual(-0.416147, actual, 0.0001);
            }
        }

        [TestFixture]
        public class lnTest
        {
            [Test]
            public void Test1()
            {
                var actual = Program.ln(2);

                Assert.AreEqual(0.693147, actual, 0.0001);
            }
        }

        [TestFixture]
        public class absTest
        {
            [Test]
            public void Test1()
            {
                var actual = Program.abs(-2);

                Assert.AreEqual(2, actual, 0.0001);
            }

            [Test]
            public void Test2()
            {
                var actual = Program.abs(2);

                Assert.AreEqual(2, actual, 0.0001);
            }
        }

        [TestFixture]
        public class powTest
        {
            [Test]
            public void Test1()
            {
                var actual = Program.pow(2,3);

                Assert.AreEqual(9, actual, 0.0001);
            }
        }

        [TestFixture]
        public class faktTest
        {
            [Test]
            public void Test1()
            {
                var actual = Program.fakt(2);

                Assert.AreEqual(2, actual, 0.0001);
            }
        }

        [TestFixture]
        public class FunkTest
        {
            [Test]
            public void TestMinus()
            {
                var actual = Program.funkVar3(-2);

                Assert.AreEqual(0.291263, actual, 0.0001);
            }

            [Test]
            public void TestPlus()
            {
                var actual = Program.funkVar3(2);

                Assert.AreEqual(-0.288451, actual, 0.0001);
            }
        }
    }
}