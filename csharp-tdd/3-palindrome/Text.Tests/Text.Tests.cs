using NUnit.Framework;
using System.Collections.Generic;
using Text;

namespace Text.Tests
{
    public class Tests
    {

        private string s;

        [SetUp]
        public void Setup()
        {
            s = "";
        }

        [Test]
        public void NullString()
        {
            s = null;
            Assert.IsTrue(Str.IsPalindrome(s));
        }

        [Test]
        public void OneCharString()
        {
            s = "r";
            Assert.IsTrue(Str.IsPalindrome(s));
        }

        [Test]
        public void JustAPalindrome()
        {
            s = "racecar";
            Assert.IsTrue(Str.IsPalindrome(s));
        }

        [Test]
        public void UpperLower()
        {
            s = "RaceCar";
            Assert.IsTrue(Str.IsPalindrome(s));
        }

        [Test]
        public void Punctuation()
        {
            s = "racecar!";
            Assert.IsTrue(Str.IsPalindrome(s));
        }

        [Test]
        public void Spaces()
        {
            s = "race car";
            Assert.IsTrue(Str.IsPalindrome(s));
        }
    }
}