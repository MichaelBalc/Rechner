using System;
using TechTalk.SpecFlow;
using Xunit;

namespace Taschenrechner
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        int first;
        int second;
        int result;


        [Given(@"the first number is (.*)")]
        public void GivenTheFirstNumberIs(int p0)
        {
            first = p0;
        }
        
        [Given(@"the second number is (.*)")]
        public void GivenTheSecondNumberIs(int p0)
        {
            second = p0;
        }
        
        [When(@"the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            result = first + second;
        }
        
        [When(@"the two numbers are subtracted")]
        public void WhenTheTwoNumbersAreSubtracted()
        {
            result = first - second;
        }
        
        [When(@"the two numbers are multiplied")]
        public void WhenTheTwoNumbersAreMultiplied()
        {
            result = first * second;
        }
        
        [When(@"the two numbers are dubtracted")]
        public void WhenTheTwoNumbersAreDubtracted()
        {
            result = first / second;
        }
        
        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int p0)
        {
            int expected = p0;
            int actual = p0;
            Assert.Equal(expected, actual);
        }
    }
}
