using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using StringReverseLibrary;

namespace StringReverseTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ReverseString_Stringishello()
        {
            string textString = "hello";
            string expected = "olleh";

            string result = new StringReversClass().ReverseString(textString);

            Assert.AreEqual(expected, result); 
        }
        [TestMethod]
        public void ReverseString_StringisEmpty()
        {
            string textString = "";

            Action result = () => new StringReversClass().ReverseString(textString);

            Assert.ThrowsException<Exception>(result);
        }
        [TestMethod]
        public void ReverseString_StringisHello()
        {
            string textString = "Hello";
            string expected = "olleh";

            string result = new StringReversClass().ReverseString(textString);

            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void ReverseString_StringisHelloAndSymbol()
        {
            string textString = "Hello!";
            string expected = "!olleh";

            string result = new StringReversClass().ReverseString(textString);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ReverseString_StringisEmpty2()
        {
            string textString = "";

            Action result = () => new StringReversClass().IsPalindrome(textString);

            Assert.ThrowsException<Exception>(result);
        }
        [TestMethod]
        public void ReverseString_StringHelloAndSymbol_ResultFalse()
        {
            string textString = "Hello!";

            bool result = new StringReversClass().IsPalindrome(textString);

            Assert.IsFalse(result);
        }
        [TestMethod]
        public void ReverseString_StringiText_ResultFalse()
        {
            string textString = "айлалалай нанай";

            bool result = new StringReversClass().IsPalindrome(textString);

            Assert.IsFalse(result);
        }
        [TestMethod]
        public void ReverseString_StringNumber_ResultTrue()
        {
            string textString = "2002";

            bool result = new StringReversClass().IsPalindrome(textString);

            Assert.IsTrue(result);
        }
        [TestMethod]
        public void ReverseString_StringiText_ResultTrue()
        {
            string textString = "топот";

            bool result = new StringReversClass().IsPalindrome(textString);

            Assert.IsFalse(result);
        }

    }
}
