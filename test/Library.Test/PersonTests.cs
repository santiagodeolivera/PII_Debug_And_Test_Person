using NUnit.Framework;

using UnitTestAndDebug;

namespace Tests
{
    public class Tests
    {
        private string initialName;
        private string initialId;
        private Person person;

        [SetUp]
        public void Setup()
        {
            this.initialName = "Santiago De Olivera";
            this.initialId = "52672887";
            this.person = new Person(initialName, initialId);
        }

        [Test]
        public void TestNameAssignment()
        {
            string newName = "Roberto Sánchez";

            this.person.Name = newName;

            Assert.AreEqual(this.person.Name, newName);
        }

        [Test]
        public void TestNameValidationNull()
        {
            string newName = null;

            this.person.Name = newName;

            Assert.AreEqual(this.person.Name, initialName);
        }

        [Test]
        public void TestNameValidationEmpty()
        {
            string newName = "";

            this.person.Name = newName;

            Assert.AreEqual(this.person.Name, initialName);
        }

        [Test]
        public void TestIdAssignment()
        {
            string newId = "00000000";

            this.person.ID = newId;

            Assert.AreEqual(this.person.ID, newId);
        }

        [Test]
        public void TestIdValidationLength()
        {
            string newId = "0000001";

            this.person.ID = newId;

            Assert.AreEqual(this.person.ID, initialId);
        }

        [Test]
        public void TestIdValidationCheck()
        {
            string newId = "00000001";

            this.person.ID = newId;

            Assert.AreEqual(this.person.ID, initialId);
        }
    }
}