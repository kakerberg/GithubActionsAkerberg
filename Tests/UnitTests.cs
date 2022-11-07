using System;
using NUnit.Framework;

namespace GithubActionsLab
{
    [TestFixture]
    public class Math
    {
        [Test]
        public void Add_Valid()
        {
            Assert.AreEqual(3, Program.Add("1", "2"));
            Assert.AreEqual(5, Program.Add("3", "2"));
            Assert.AreEqual(12, Program.Add("5", "7"));
        }

        [Test]
        public void Add_Invalid()
        {
            Assert.Throws<FormatException>(() => Program.Add("1", "a"));
            Assert.Throws<FormatException>(() => Program.Add("a", "1"));
            Assert.Throws<FormatException>(() => Program.Add("a", "a"));
        }

        [Test]
        public void Add_Null()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Add("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, null));
        }

        // Implement 3 tests per operation, following a similar pattern as above
        [Test]
        public void Subtract_Valid()
        {
            Assert.AreEqual(5, Program.Subtract("10", "5"));
            Assert.AreEqual(74, Program.Subtract("77", "3"));
            Assert.AreEqual(4, Program.Subtract("7", "3"));
        }

        [Test]
        public void Subtract_Invalid()
        {
            Assert.Throws<FormatException>(() => Program.Subtract("3", "h"));
            Assert.Throws<FormatException>(() => Program.Subtract("a", "l"));
            Assert.Throws<FormatException>(() => Program.Subtract("8", "b"));
        }

        [Test]
        public void Subtract_Null()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Subtract("8", null));
            Assert.Throws<ArgumentNullException>(() => Program.Subtract(null, null));
            Assert.Throws<ArgumentNullException>(() => Program.Subtract(null, "99"));
        }

        [Test]
        public void Multiply_Valid()
        {
            Assert.AreEqual(64, Program.Multiply("8", "8"));
            Assert.AreEqual(198, Program.Multiply("99", "2"));
            Assert.AreEqual(12, Program.Multiply("4", "3"));
        }

        [Test]
        public void Multiply_Invalid()
        {
            Assert.Throws<FormatException>(() => Program.Multiply("f", "7"));
            Assert.Throws<FormatException>(() => Program.Multiply("99", "o"));
            Assert.Throws<FormatException>(() => Program.Multiply("a", "p"));
        }

        [Test]
        public void Multiply_Null()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Multiply("9", null));
            Assert.Throws<ArgumentNullException>(() => Program.Multiply(null, null));
            Assert.Throws<ArgumentNullException>(() => Program.Multiply(null, "80"));
        }

        [Test]
        public void Divide_Valid()
        {
            Assert.AreEqual(8, Program.Divide("64", "8"));
            Assert.AreEqual(2, Program.Divide("10", "5"));
            Assert.AreEqual(44, Program.Divide("220", "5"));
        }

        [Test]
        public void Divide_Invalid()
        {
            Assert.Throws<FormatException>(() => Program.Divide("99", "e"));
            Assert.Throws<DivideByZeroException>(() => Program.Divide("9", "0"));
            Assert.Throws<FormatException>(() => Program.Divide("a", "e"));
        }

        [Test]
        public void Divide_Null()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Divide(null, "33"));
            Assert.Throws<ArgumentNullException>(() => Program.Divide("3", null));
            Assert.Throws<ArgumentNullException>(() => Program.Divide(null, null));
        }

        [Test]
        public void Power_Valid()
        {
            Assert.AreEqual(24, Program.Power("3", "3"));
            Assert.AreEqual(64, Program.Power("8", "2"));
            Assert.AreEqual(144, Program.Power("12", "2"));
        }

        [Test]
        public void Power_Invalid()
        {
            Assert.Throws<FormatException>(() => Program.Power("d", "9"));
            Assert.Throws<FormatException>(() => Program.Power("d", "a"));
            Assert.Throws<FormatException>(() => Program.Power("10", "y"));
        }

        [Test]
        public void Power_Null()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Power(null, "19"));
            Assert.Throws<ArgumentNullException>(() => Program.Power(null, null));
            Assert.Throws<ArgumentNullException>(() => Program.Power("4", null));
        }
    }
}
