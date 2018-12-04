using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SampleIntroApp
{
    [Binding]
    public sealed class TestFixture
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeScenario]
        public void BeforeScenario()
        {
            Console.WriteLine("Calling before scenario");
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Console.WriteLine("Calling after scenario");
        }
    }
}
