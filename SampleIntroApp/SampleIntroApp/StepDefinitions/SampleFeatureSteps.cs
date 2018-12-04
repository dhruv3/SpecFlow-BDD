using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using SpecFlow.Assist.Dynamic;

namespace SampleIntroApp
{
    [Binding]
    class SampleFeatureSteps
    {
        public readonly StepDefinitions.EmployeeDetails employee;
        //this will enable context injection feature
        public SampleFeatureSteps(StepDefinitions.EmployeeDetails emp)
        {
            this.employee = emp;
        }
        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int numbers)
        {
            Console.WriteLine(numbers);
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            Console.WriteLine("Add button is pressed");
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int result)
        {
            if (result == 120)
                Console.WriteLine("PASS");
            else
                Console.WriteLine("FAIL");
        }

        [When(@"I fill all the mandatory details in form")]
        public void WhenIFillAllTheMandatoryDetailsInForm(Table table)
        {
            //var details = table.CreateSet<StepDefinitions.EmployeeDetails>();
            //foreach(var item in details)
            //{
            //    Console.WriteLine("Details of Employee : " + item.Name);
            //    Console.WriteLine(item.Age);
            //    Console.WriteLine(item.Email);
            //    Console.WriteLine(item.Name);
            //    Console.WriteLine(item.Phone);
            //}

            //Work with Dynamic Assist
            //var details = table.CreateDynamicSet();
            //foreach(var item in details)
            //{
            //    Console.WriteLine("Details of Employee : " + item.Name);
            //    Console.WriteLine(item.Age);
            //    Console.WriteLine(item.Email);
            //    Console.WriteLine(item.Name);
            //    Console.WriteLine(item.Phone);
            //}
            var data = table.CreateDynamicSet();
            foreach(var item in data)
            {
                employee.Age = (int)item.Age;
                employee.Email = (string)item.Email;
                employee.Name = (string)item.Name;
                employee.Phone = (long)item.Phone;
            }

        }

        [When(@"I fill all the mandatory details in form (.*), (.*) and (.*)")]
        public void WhenIFillAllTheMandatoryDetailsInFormJohnAnd(string name, int age, Int64 phone)
        {
            Console.WriteLine(age);
            Console.WriteLine(name);
            Console.WriteLine(phone);
        }




    }
}
