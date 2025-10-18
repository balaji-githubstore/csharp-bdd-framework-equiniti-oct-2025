using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementAutomation.StepDefinitions
{
    public class DemoTest
    {
        [Test]
        public void ReportSteps()
        {
            //[BeforeTest] - initialized only once for whole project
            var extent = new ExtentReports();
            var spark = new ExtentSparkReporter("Spark.html");
            extent.AttachReporter(spark);

            //[BeforeScenario]
            ExtentTest test = extent.CreateTest("MyFirstTest");

            test.Log(Status.Info, "This is a logging event for MyFirstTest, and it passed!");

            //  [AfterScenario]
            test.Log(Status.Pass, "This is a logging event for MyFirstTest, and it passed!");
            
            
            //[AfterTest] - run at the last after all scenario execution
            extent.Flush();
        }
    }
}
