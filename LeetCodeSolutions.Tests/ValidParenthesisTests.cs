using LeetCodeSolutions;
using NUnit.Framework;
using System;
using NUnit.Framework.Constraints;

namespace LeetCodeSolutions.Tests
{
    [TestFixture]
    public class ValidParenthesisTests
    {



        private ValidParenthesis CreateValidParenthesis()
        {
            return new ValidParenthesis();
        }

        [Test]
        public void IsValid_True_ExpectedBehavior()
        {
            // Arrange
            var unitUnderTest = this.CreateValidParenthesis();
            string s = "{[{}]}";

            // Act
            var result = unitUnderTest.IsValid(
                s);

            // Assert
            Assert.True(result);
        }

        [Test]
        public void IsValid_False_ExpectedBehavior()
        {
            // Arrange
            var unitUnderTest = this.CreateValidParenthesis();
            string s = "{[{]}}";

            // Act
            var result = unitUnderTest.IsValid(
                s);

            // Assert
            Assert.False(result);
        }
    }
}
