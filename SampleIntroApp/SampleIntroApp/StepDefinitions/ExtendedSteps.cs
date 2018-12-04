using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SampleIntroApp.StepDefinitions
{
    [Binding]
    public sealed class ExtendedSteps
    {
        //this is the POCO object having shared data
        public readonly EmployeeDetails employee;
        //this will enable context injection feature
        public ExtendedSteps(EmployeeDetails emp)
        {
            this.employee = emp;
        }

        [Then(@"I should get the same value from Extended Steps")]
        public void ThenIShouldGetTheSameValueFromExtendedSteps()
        {
            Console.WriteLine(employee.Age);
            Console.WriteLine(employee.Name);
        }

    }
}
