using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ClassLibrary3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{

    
    [Binding]
    public class CalculatorSteps
    {
        private int result;
        private Calculator calculator = new Calculator();
        //private int expectedResult;

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int number)
        {

            //  IWebDriver driver = new ChromeDriver();
            //  driver.Url = "https://testqa.torrow.net";
            //  ScenarioContext.Current.Pending();
            calculator.FirstNumber = number;
        }
        
        [Given(@"I have also entered (.*) into the calculator")]
        public void GivenIHaveAlsoEnteredIntoTheCalculator(int number)
        {
            // ScenarioContext.Current.Pending();
            calculator.SecondNumber = number;
        }
        
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            //ScenarioContext.Current.Pending();
            result = calculator.Add();
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int expectedResult)
        {
            //ScenarioContext.Current.Pending();
            Assert.AreEqual(expectedResult, result);
        }
    }
}
