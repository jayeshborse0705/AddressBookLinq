using AddressBookLinq;

namespace Address
{
    public class Tests
    {
        AddressBook address = new AddressBook();

        [SetUp]
        public void Setup()
        {
            address = new AddressBook();
        }

        [Test]
        public void GivenInsertValues_returnInteger()
        {
            int expected = 2;
            int actual = address.AddValues();
            Assert.AreEqual(actual, expected);
        }
    }
}