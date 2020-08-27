using Lesson10;
using NUnit.Framework;

namespace Lesson10Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Card card = new Card("")
            {
                Status = CardStatus.RESOLVED
            };

            //card.Status = CardStatus.DONE;
            Assert.Throws<InvalidStatusException>(() => card.Status = CardStatus.DONE);
        }
    }
}