using CShrpPractice;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TypeTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TwoVarsValues()
        {
            var book1 = GetBook("Book 1");
            var book2 = GetBook("Book 2");

            Assert.AreEqual("Book 1", book1.name);
            Assert.AreEqual("Book 2", book2.name);
            Assert.AreNotSame(book1, book2); // Asserts that book1 and book2 are NOT The same object that they are different objects
        }

        [TestMethod]
        public void TwoVarsCanReferenceSamenameValue()
        {
            var book1 = GetBook("Book 1");
            var book2 = book1; // Variables hold VALUES. Those values can be REFERENCES or POINTERS to an object out there on my computer
       
            Assert.AreEqual("Book 1", book1.name); // This tells us that 'Book 1' is EQUAL to the contents of book1.name
            Assert.AreEqual("Book 1", book2.name); // and that since book2 is pointing to the same object book1 we will get the contents of Book 1
            Assert.IsTrue(object.ReferenceEquals(book1, book2)); // same assert as line above- tests to see if object references same object
        }

        [TestMethod]
        public void TwoVarsCanReferenceSameObject()
        {
            var book1 = GetBook("Book 1");
            var book2 = book1; // Variables hold VALUES. Those values can be REFERENCES or POINTERS to an object out there on my computer

            Assert.AreSame(book1, book2);//Asserts if the two objects are REFFERING TO THE SAME OBJECT IN MEMEORY!
        }

        [TestMethod]
        public void Test1() 
        {
            var book1 = GetBook("Book 1");
            SetName(book1, "New Name");

            Assert.AreEqual("New Name", book1.name);
        }

        private void SetName(Book book, string name)
        {
            book.name = name;
        }

        public Book GetBook(string name)
        {
            return new Book(name);
        }
    }
}
