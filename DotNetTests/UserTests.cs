using Microsoft.VisualStudio.TestTools.UnitTesting;
using DotNetClassLib;
using System;

namespace DotNetTests
{
    [TestClass]
    public class UserTests
    {
        /// <summary>
        /// Tests that the username is a:
        /// - concatenation of the firstname and lastname with a single full-stop
        /// - with all non-alpha characters removed
        /// - all lower case
        /// </summary>
        [TestMethod]
        [TestCategory("Property tests")]
        public void Username_Is_Correct()
        {
         
        }

        /// <summary>
        /// Tests that IsValid returns false when Firstname is null
        /// </summary>
        [TestMethod]
        [TestCategory("Property tests")]
        public void IsValid_When_Firstname_Is_Null()
        {

        }

        /// <summary>
        /// Tests that IsValid returns false when Description contains more than 100 words
        /// </summary>
        [TestMethod]
        [TestCategory("Property tests")]
        public void IsValid_When_Description_Longer_Than_100_Words()
        {

        }
    }
}