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
        public void GivenModifyValues_returnInteger()
        {
            int expected = 0;
            int actual = address.EditDataTable("Sharama", "Firstname");
            Assert.AreEqual(actual, expected);
        }

        [Test]
        public void GivenDeleteQuery_returnInteger()
        {
            int expected = 1;
            int actual = address.DeleteRowInDataTable("Hari");
            Assert.AreEqual(actual, expected);
        }
        public void GivenRetrieveQuery_BasedOnCityandState_returnString()
        {
            string expected = "Shyam Hari";
            string actual = address.RetrieveBasedOnCityorState("valsad", "Maharashtra");
            Assert.AreEqual(expected, actual);
        }
    }
}